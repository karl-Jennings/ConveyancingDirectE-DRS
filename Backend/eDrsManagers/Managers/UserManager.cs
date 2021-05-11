using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsDB.Password;
using eDrsManagers.Interfaces;
using eDrsManagers.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace eDrsManagers.Managers
{
    public class UserManager : IUserManager
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public UserManager(AppDbContext context, IConfiguration configuration, IMapper mapper)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
        }

        public UserViewModel Login(LoginViewModel viewModel)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == viewModel.Email);
            if (user == null) // Email does not exist
            {
                return new UserViewModel { IsUserValid = false };
            }
            else
            {
                if (!PasswordManager.VerifyPassword(viewModel.Password, user.PasswordHash, user.PasswordSalt)) // checking whether password matches
                {
                    return new UserViewModel { IsUserValid = false };
                }
                else
                {
                    var token = GenerateToken(user.UserId.ToString(), user.Designation, DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["Token:Expiration"])));

                    return new UserViewModel
                    {
                        IsUserValid = true,
                        UserId = user.UserId,
                        Token = token,
                        Fullname = user.Firstname + " " + user.Lastname,
                        Designation = user.Designation
                    };

                }
            }

        }


        public List<UserViewModel> Get()
        {
            var userList = _context.Users.Where(x => x.Status).ToList();
            return _mapper.Map<List<User>, List<UserViewModel>>(userList);
        }

        public bool Update(UserViewModel viewModel)
        {
            var user = _mapper.Map<UserViewModel, User>(viewModel);

            if (!string.IsNullOrEmpty(viewModel.Password))
            {
                var passwordByte = PasswordManager.CreatePasswordHash(viewModel.Password);
                user.PasswordSalt = passwordByte[0];
                user.PasswordHash = passwordByte[1];
            }

            user.Status = true; 
            _context.Users.Update(user);

            return _context.SaveChanges() > 0;
        }


        private string GenerateToken(string id, string role, DateTime exp)
        {
            var tokenDescriptor = new SecurityTokenDescriptor // generating a token
            {
                Issuer = null,              // Not required as no third-party is involved
                Audience = null,            // Not required as no third-party is involved
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now,
                Expires = exp,
                Subject = new ClaimsIdentity(new List<Claim> {
                    new Claim(ClaimTypes.Name, id),
                    new Claim(ClaimTypes.Role, role)
                }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecretKey"])), SecurityAlgorithms.HmacSha256Signature)
            };
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(jwtToken);
        }

    }
}
