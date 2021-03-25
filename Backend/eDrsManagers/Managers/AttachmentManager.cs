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

        public byte[] GetAttachment(long requestId)
        {
            try
            {
                var requestLog = _context.RequestLogs.FirstOrDefault(x => x.RequestLogId == requestId);
                var bytes = Convert.FromBase64String(requestLog?.File);
                return bytes;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public object RespondToRequisition(long docRefId)
        {
            try
            {
                var supDoc = _context.SupportingDocuments.FirstOrDefault(x => x.DocumentReferenceId == docRefId);
                var requestLog = _context.RequestLogs.FirstOrDefault(x => x.DocumentReferenceId == docRefId && x.Type == "attachment_poll");
            


                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
