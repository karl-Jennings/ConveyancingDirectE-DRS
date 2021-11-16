using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using eDRS_Land_Registry.Models;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsManagers.Http;
using eDrsManagers.Interfaces;
using eDrsManagers.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace eDrsManagers.Managers
{
    public class AttachmentManager : IAttachmentManager
    {
        private readonly AppDbContext _context;
        private readonly IHttpEdrsCall _httpInterceptor;
        private readonly IMapper _mapper;
        public AttachmentManager(AppDbContext context, IHttpEdrsCall httpInterceptor, IMapper mapper)
        {
            _context = context;
            _httpInterceptor = httpInterceptor;
            _mapper = mapper;
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

                docRef.RequestLogs = attachmentRequest;

                _context.RequestLogs.AddRange(attachmentRequest);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public object RespondToRequisitionByReference(string reference)
        {
            try
            {
                //Get DocumentReference by Reference

                var _documentReference = _context.DocumentReferences.Where(r => r.Reference == reference).FirstOrDefault();
                
                if (_documentReference!=null) {
                    var application = _context.ApplicationForms.Include(x => x.Document).Where(x => x.DocumentReferenceId == _documentReference.DocumentReferenceId).ToList();
                    var docRef = _context.DocumentReferences.Include(s => s.SupportingDocuments)
                        .FirstOrDefault(x => x.DocumentReferenceId == _documentReference.DocumentReferenceId);
                    AttachmentViewModel attachmentViewModel = new AttachmentViewModel();
                    docRef.Applications = application;
                    attachmentViewModel.DocumentReference = docRef;

                    var attachmentRequest = _httpInterceptor.CallAttachmentRequestApi(attachmentViewModel);

                    docRef.RequestLogs = attachmentRequest;

                    _context.RequestLogs.AddRange(attachmentRequest);
                    _context.SaveChanges();
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public object DirectRespondToRequisition(DocumentReferenceViewModel viewModel)
        {
            try
            {
                //var application = _context.ApplicationForms.Include(x => x.Document).Where(x => x.DocumentReferenceId == docRefId).ToList();
                //var docRef = _context.DocumentReferences.Include(s => s.SupportingDocuments)
                //    .FirstOrDefault(x => x.DocumentReferenceId == docRefId);

                // docRef.Applications = application;


                AttachmentViewModel attachmentViewModel = new AttachmentViewModel();

                var docRef = _mapper.Map<DocumentReferenceViewModel, DocumentReference>(viewModel);

                attachmentViewModel.DocumentReference = docRef;

                var attachmentRequest = _httpInterceptor.CallAttachmentRequestApi(attachmentViewModel);

                docRef.RequestLogs = attachmentRequest;

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
