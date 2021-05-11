using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsManagers.Interfaces;

namespace eDrsManagers.Managers
{
    public class SettingsManager : ISettingsManager
    {
        private readonly AppDbContext _context;

        public SettingsManager(AppDbContext context)
        {
            _context = context;
        }

        public bool ChangeCredentials(LrCredential model)
        {
            try
            {
                _context.LrCredentials.Update(model);
                return _context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public LrCredential GetCredentials()
        {
            try
            {
                return _context.LrCredentials.FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
