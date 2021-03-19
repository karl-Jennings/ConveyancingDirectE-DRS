using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eDrsDB.Data;
using eDrsManagers.Interfaces;

namespace eDrsManagers.Managers
{
    public class AttachmentManager : IAttachmentManager
    {
        private readonly AppDbContext _context;

        public AttachmentManager(AppDbContext context)
        {
            _context = context;
        }

        public byte[] GetApplicationPollAttached(long requestId)
        {
            var requestLog = _context.RequestLogs.FirstOrDefault(x => x.RequestLogId == requestId);
            byte[] bytes = System.Convert.FromBase64String(requestLog?.File);
            return bytes;
            throw new NotImplementedException();
        }
    }
}
