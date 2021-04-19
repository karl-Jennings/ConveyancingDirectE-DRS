using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eDRS_Land_Registry.Models;
using eDrsDB.Data;
using eDrsManagers.Http;
using eDrsManagers.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eDrsManagers.Managers
{
    public class AttachmentManager : IAttachmentManager
    {
        private readonly AppDbContext _context;
        private readonly IHttpEdrsCall _httpInterceptor;

        public AttachmentManager(AppDbContext context, IHttpEdrsCall httpInterceptor)
        {
            _context = context;
            _httpInterceptor = httpInterceptor;
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
                var application = _context.ApplicationForms.Include(x => x.Document).Where(x => x.DocumentReferenceId == docRefId).ToList();
                var docRef = _context.DocumentReferences.Include(s => s.SupportingDocuments)
                    .FirstOrDefault(x => x.DocumentReferenceId == docRefId);
                AttachmentViewModel attachmentViewModel = new AttachmentViewModel();
                docRef.Applications = application;
                attachmentViewModel.DocumentReference = docRef;

                var attachmentRequest = _httpInterceptor.CallAttachmentRequestApi(attachmentViewModel);

                _context.RequestLogs.AddRange(attachmentRequest);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
