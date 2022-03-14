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
        private LrCredential lrCredentials;
        public AttachmentManager(AppDbContext context, IHttpEdrsCall httpInterceptor, IMapper mapper)
        {
            _context = context;
            _httpInterceptor = httpInterceptor;
            _mapper = mapper;
            lrCredentials = _context.LrCredentials.FirstOrDefault();
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

                //Get ApplicationMessageID from Requisition Table
                docRef= SetApplicationMessageIDForREquisition(docRef);

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


        public DocumentReference SetApplicationMessageIDForREquisition(DocumentReference docref)
        {

            //Get Requisitions

            var _requisitions = _context.Requisition.Where(r => r.DocumentReferenceId == docref.DocumentReferenceId && r.Status==0);

            if (_requisitions != null)
            {

                // set  ApplicationMessageID in ApplicationDocuments

                var _applications = docref.Applications;

                if (_applications != null) {

                    _applications.ToList().ForEach( app=> {


                        //Get ApplocationMessageID frm Requisitions

                        var _file = _requisitions.Where(r => r.FileName == app.Document.FileName);

                        if (_file!=null && _file.Count()>0) {

                            app.Document.ApplicationMessageId = _file.FirstOrDefault().AppMessageId;
                        }

                    });

                }

                // set  ApplicationMessageID in SupportingDocuments

                var _supportingDocuments = docref.SupportingDocuments;

                if (_supportingDocuments!=null) {


                    _supportingDocuments.ToList().ForEach(doc => {

                        //Get ApplocationMessageID frm Requisitions

                        var _file = _requisitions.Where(r => r.FileName == doc.FileName);

                        if (_file != null && _file.Count()>0)
                        {
                            doc.ApplicationMessageId = _file.FirstOrDefault().AppMessageId;
                        }

                    });

                }

            }

            return docref;
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


        public dynamic CollectAttachmentResults(long docRefId)
        {

            int serviceId = 105;

            var docRef = _context.DocumentReferences.FirstOrDefault(x => x.DocumentReferenceId == docRefId);

            OutstaningRequestViewModel outstaningRequest = new OutstaningRequestViewModel();
            //outstaningRequest.Username = "BGUser001";
            outstaningRequest.Username = lrCredentials.Username;

            if (docRef != null)
            {
                outstaningRequest.Service = serviceId;
                outstaningRequest.MessageId = Guid.NewGuid().ToString();
                outstaningRequest.AdditionalProviderFilter = docRef.AdditionalProviderFilter;
            }

            var outstandingResponse = _httpInterceptor.CallOutstandingApi(outstaningRequest);

            var outstandings = new List<Outstanding>();

            outstandingResponse.Requests.ForEach(x =>
            {
                outstandings.Add(new Outstanding
                {
                    LandRegistryId = x.Id,
                    NewResponse = x.NewResponse,
                    Type = "attachment_outstanding",
                    DocumentReferenceId = docRef.DocumentReferenceId,
                    TypeCode = x.TypeCode,
                    ServiceType = x.ServiceType,
                    MessageId = outstaningRequest.MessageId

                });
            });

            var requestLogList = new List<RequestLog>();
            outstandings.ForEach(x =>
            {
                AttachmentPollRequestViewModel attachmentPoll = new AttachmentPollRequestViewModel();
                attachmentPoll.Username = lrCredentials.Username;
                if (docRef != null)
                {
                    attachmentPoll.MessageId = x.LandRegistryId;
                }

                var pollResponse = _httpInterceptor.CallAttachmentPollApi(attachmentPoll);

                if (pollResponse!=null) {

                    pollResponse.DocumentReferenceId = docRef.DocumentReferenceId;

                    requestLogList.Add(pollResponse);

                }            

            });

            if (outstandings!=null && outstandings.Count>0) {

                _context.Outstanding.AddRange(outstandings);
            }

            if (requestLogList!=null && requestLogList.Count>0) {

                _context.RequestLogs.AddRange(requestLogList);
            }         
           
            _context.SaveChanges();

            return requestLogList;

        }
    }


}
