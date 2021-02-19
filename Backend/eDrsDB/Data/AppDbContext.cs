using System;
using System.Collections.Generic;
using eDrsDB.Models;
using eDrsDB.Password;
using Microsoft.EntityFrameworkCore;

namespace eDrsDB.Data
{
    public class AppDbContext : DbContext
    {
        public List<byte[]> PasswordByte { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
            PasswordByte = PasswordManager.CreatePasswordHash("Admin123"); // getting hash for default password
        }
        public DbSet<User> Users { get; set; }
        public DbSet<RegistrationType> RegistrationTypes { get; set; }
        public DbSet<DocumentReference> DocumentReferences { get; set; }
        public DbSet<TitleNumber> TitleNumbers { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<SupportingDocuments> SupportingDocuments { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<ErrorLogs> ErrorLogs { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<AttachmentNote> AttachmentNotes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(x => x.Status)
                .HasDefaultValue(true);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<User>()
                .Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<RequestLog>()
                .Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<User>()
                .HasData(new User
                {
                    UserId = 1,
                    Status = true,
                    Firstname = "Admin",
                    Designation = "admin",
                    Email = "dushyanthaccura@gmail.com",
                    PasswordSalt = PasswordByte[0],
                    PasswordHash = PasswordByte[1]
                });

            modelBuilder.Entity<RegistrationType>()
                .Property(x => x.Status)
                .HasDefaultValue(true);

            modelBuilder.Entity<RegistrationType>()
                .HasData(new RegistrationType
                {
                    RegistrationTypeId = 1,
                    Status = true,
                    TypeCode = "doc_reg",
                    TypeName = "Transfer and charge",
                    Url = "document-registration",
                    UpdatedDate = DateTime.Now
                },
                new RegistrationType
                {
                    RegistrationTypeId = 2,
                    Status = true,
                    TypeCode = "lease_ext",
                    TypeName = "Remortgage",
                    Url = "lease-extension",
                    UpdatedDate = DateTime.Now
                },
                new RegistrationType
                {
                    RegistrationTypeId = 3,
                    Status = true,
                    TypeCode = "new_lease",
                    TypeName = "Transfer of equity",
                    Url = "new-lease",
                    UpdatedDate = DateTime.Now
                },
                new RegistrationType
                {
                    RegistrationTypeId = 4,
                    Status = true,
                    TypeCode = "rem_frm",
                    TypeName = "Restriction, hostile takeover",
                    Url = "removal-form",
                    UpdatedDate = DateTime.Now
                },
                new RegistrationType
                {
                    RegistrationTypeId = 5,
                    Status = true,
                    TypeCode = "transfer",
                    TypeName = "Change of name",
                    Url = "transfer",
                    UpdatedDate = DateTime.Now
                },
                new RegistrationType
                {
                    RegistrationTypeId = 6,
                    Status = true,
                    TypeCode = "transfer",
                    TypeName = "Dispositionary first lease",
                    Url = "transfer",
                    UpdatedDate = DateTime.Now
                },
                new RegistrationType
                {
                    RegistrationTypeId = 7,
                    Status = true,
                    TypeCode = "transfer",
                    TypeName = "Transfer of part",
                    Url = "transfer",
                    UpdatedDate = DateTime.Now
                },
                new RegistrationType
                {
                    RegistrationTypeId = 8,
                    Status = true,
                    TypeCode = "lease_ext",
                    TypeName = "Lease extension",
                    Url = "lease-extension",
                    UpdatedDate = DateTime.Now
                }
                );

            modelBuilder.Entity<DocumentReference>()
                .Property(x => x.Status)
                .HasDefaultValue(true);

            modelBuilder.Entity<TitleNumber>()
                .Property(x => x.Status)
                .HasDefaultValue(true);

            modelBuilder.Entity<TitleNumber>()
                .Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<ErrorLogs>()
                .Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Party>().Ignore(c => c.ViewModelRoles);

        }
    }
}
