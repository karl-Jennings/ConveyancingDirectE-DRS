using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                //Select only the attachements whitch need to send Requisition

                docRef.Applications.ToList().ForEach(application =>
                {
                    if (application.Document.ApplyToRespondToRequisition==null 
                    || application.Document.ApplyToRespondToRequisition != true) {

                        application.Document = null;

                    }                
                }                
                );

                docRef.SupportingDocuments = docRef.SupportingDocuments.Where(r => r.ApplyToRespondToRequisition == true).ToList();

                //Get ApplicationMessageID from Requisition Table
                docRef = SetApplicationMessageIDForREquisition(docRef);

                attachmentViewModel.DocumentReference = docRef;

                var attachmentRequest = _httpInterceptor.CallAttachmentRequestApi(attachmentViewModel);

                docRef.RequestLogs = attachmentRequest;

                _context.RequestLogs.AddRange(attachmentRequest);

                //Update Requisition status
                var _requisition = _context.Requisition.FirstOrDefault(r => r.AppMessageId == docRef.MessageID && r.Status == 0);

                _requisition.Status = 1; // Responded to requisition

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
          
                // set  ApplicationMessageID in ApplicationDocuments
                var _applications = docref.Applications;

                if (_applications != null)
                {
                    _applications.ToList().ForEach(app =>
                    {
                        if (app.Document != null)
                        {
                            app.Document.ApplicationMessageId = docref.MessageID;
                        }
                    });
                }

                // set  ApplicationMessageID in SupportingDocuments

                var _supportingDocuments = docref.SupportingDocuments;

                if (_supportingDocuments != null)
                {
                    _supportingDocuments.ToList().ForEach(doc =>
                    {
                        //Get ApplocationMessageID from Requisitions                     
                        doc.ApplicationMessageId = docref.MessageID;

                    });
                }          


            return docref;
        }

        public object RespondToRequisitionByReference(string reference)
        {
            try
            {
                //Get DocumentReference by Reference

                var _documentReference = _context.DocumentReferences.Where(r => r.Reference == reference).FirstOrDefault();

                if (_documentReference != null)
                {
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

                var attachmentResponse = _httpInterceptor.CallAttachmentRequestApi(attachmentViewModel);

                docRef.RequestLogs = attachmentResponse;

                _context.RequestLogs.AddRange(attachmentResponse);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<dynamic> CollectAttachmentResultsAsync(string AdditionalProviderFilter)
        {

            int serviceId = 105;

            // var docRef = _context.DocumentReferences.FirstOrDefault(x => x.DocumentReferenceId == docRefId);

            OutstaningRequestViewModel outstaningRequest = new OutstaningRequestViewModel();
            //outstaningRequest.Username = "BGUser001";
            outstaningRequest.Username = lrCredentials.Username;
            outstaningRequest.Service = serviceId;
            outstaningRequest.MessageId = Guid.NewGuid().ToString();
            outstaningRequest.AdditionalProviderFilter = AdditionalProviderFilter;


            var outstandingResponse = _httpInterceptor.CallOutstandingApi(outstaningRequest);

            var outstandings = new List<Outstanding>();

            outstandingResponse.Requests.ForEach(async x =>
            {
                var _outstanding = new Outstanding
                {
                    LandRegistryId = x.Id,
                    NewResponse = x.NewResponse,
                    Type = "attachment_outstanding",
                    TypeCode = x.TypeCode,
                    ServiceType = x.ServiceType,
                    MessageId = outstaningRequest.MessageId,
                    DateCreated = DateTime.Now

                };

                outstandings.Add(_outstanding);
                _context.Outstanding.Add(_outstanding);

            });

            _context.SaveChanges();

            var resultList = new List<AttachmentResult>();
            outstandings.ForEach(async x =>
            {
                AttachmentPollRequestViewModel attachmentPoll = new AttachmentPollRequestViewModel();
                attachmentPoll.Username = lrCredentials.Username;
                attachmentPoll.MessageId = x.LandRegistryId;

                var pollResponse = _httpInterceptor.CallAttachmentPollApi(attachmentPoll);

                if (pollResponse != null)
                {
                    pollResponse.DocumentReferenceId = null;
                    resultList.Add(pollResponse);
                    _context.AttachmentResult.Add(pollResponse);
                }

            });

            _context.SaveChanges();

            return resultList;
        }

        public async Task<dynamic> SendAttachments(long docRefId)
        {
            try
            {
                //Get DocumentReference by Reference

                var _documentReference =  _context.DocumentReferences.FirstOrDefault(r => r.DocumentReferenceId == docRefId);

                if (_documentReference != null)
                {
                    var application = _context.ApplicationForms.Include(x => x.Document).Where(x => x.DocumentReferenceId == _documentReference.DocumentReferenceId).ToList();
                    var docRef = _context.DocumentReferences.Include(s => s.SupportingDocuments)
                        .FirstOrDefault(x => x.DocumentReferenceId == _documentReference.DocumentReferenceId);
                    AttachmentViewModel attachmentViewModel = new AttachmentViewModel();
                    docRef.Applications = application;
                    attachmentViewModel.DocumentReference = docRef;

                    var attachmentResponse = _httpInterceptor.CallAttachmentRequestApi(attachmentViewModel);

                    docRef.RequestLogs = attachmentResponse;

                    _context.RequestLogs.AddRange(attachmentResponse);
                    _context.SaveChanges();
                    return attachmentResponse;
                }

                return false;

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

    }
}
