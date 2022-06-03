using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessGatewayServices;
using BusinessGatewayRepositories.EDRSApplication;
using BusinessGatewayModels;
using eDRS_Land_Registry.ApiConverters;
using eDRS_Land_Registry.Models;
using eDrsDB.Models;
using Newtonsoft.Json;
using BusinessGatewayRepositories.AttachmentServiceRequestV2_1;

namespace eDRS_Land_Registry.Controllers
{

    public class AttachmentRequestController : ApiController
    {
        private readonly RestrictionConverter _restrictionConverter = new RestrictionConverter();
        private readonly ApiConverter _apiConverter = new ApiConverter();

        public List<RequestLog> Post([FromBody] TempClass tempClass)
        {
            try
            {
                var services = new Services();

                var attachmentViewModel = JsonConvert.DeserializeObject<AttachmentViewModel>(tempClass.Value);
                var docRef = attachmentViewModel.DocumentReference;
                var attachmentResponse = new List<RequestLog>();

                docRef.Applications.Where(x => x.IsChecked).ToList().ForEach(app =>
                  {

                      if (app.Document!=null) {

                          string _applicationMessageId = docRef.MessageID;

                          if (!String.IsNullOrEmpty(app.Document.ApplicationMessageId))
                          {
                              _applicationMessageId = app.Document.ApplicationMessageId;
                          }

                          var attchemnt = _apiConverter.ArrangeAttachmentApi(app, null, _applicationMessageId, docRef.AdditionalProviderFilter);
                          var attachmentRequest = AttachmentRequest(attchemnt, attachmentViewModel.Username, attachmentViewModel.Password, app.Document.FileName);
                          attachmentResponse.Add(attachmentRequest);
                      }                     

                  });

                docRef.SupportingDocuments.Where(x => x.IsChecked).ToList().ForEach(supDoc =>
                {
                    
                    string _applicationMessageId = docRef.MessageID;

                    if (!String.IsNullOrEmpty(supDoc.ApplicationMessageId))
                    {
                        _applicationMessageId = supDoc.ApplicationMessageId;
                    }

                    var attchemnt = _apiConverter.ArrangeAttachmentApi(null, supDoc, _applicationMessageId, docRef.AdditionalProviderFilter);
                    var attachmentRequest = AttachmentRequest(attchemnt, attachmentViewModel.Username, attachmentViewModel.Password, supDoc.FileName);

                    attachmentResponse.Add(attachmentRequest);
                });


                return attachmentResponse;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private RequestLog AttachmentRequest(AttachmentV2_1Type attchemnt, string username, string Password, string filename)
        {

            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            RequestLog attachmentRespons = new RequestLog();

            var attachmentRequest = _services.AttachmentRequestV2_1(username, Password, attchemnt);

            var attachmentRequestLog = new RequestLog() { Type = "Attachment" };

            attachmentRequestLog.MessageId = attchemnt.MessageId;

            if (attachmentRequest.GatewayResponse!=null && attachmentRequest.GatewayResponse.GatewayResponse!=null) {

                attachmentRequestLog.TypeCode = attachmentRequest.GatewayResponse.GatewayResponse.TypeCode.ToString();
                attachmentRequestLog.ResponseJson = JsonConvert.SerializeObject(attachmentRequest.GatewayResponse.GatewayResponse);
                attachmentRequestLog.AttachmentName = filename;
                if (attachmentRequest.GatewayResponse.GatewayResponse.Acknowledgement != null)
                {
                    attachmentRequestLog.Description = attachmentRequest.GatewayResponse.GatewayResponse.Acknowledgement.MessageDescription;
                    attachmentRequestLog.CreatedDate = (attachmentRequest.GatewayResponse.GatewayResponse.Acknowledgement.ExpectedResponseDateTime);
                    attachmentRequestLog.ResponseType = "Acknowledgement";
                }
                else if (attachmentRequest.GatewayResponse.GatewayResponse.Rejection != null)
                {
                    attachmentRequestLog.Description = attachmentRequest.GatewayResponse.GatewayResponse.Rejection.Code;
                    attachmentRequestLog.RejectionReason = attachmentRequest.GatewayResponse.GatewayResponse.Rejection.Reason;
                    attachmentRequestLog.ValidationErrors = JsonConvert.SerializeObject(attachmentRequest.GatewayResponse.GatewayResponse.Rejection.ValidationErrors);
                    attachmentRequestLog.ResponseType = "Rejection";
                }
            }
          

            return attachmentRequestLog;
        }
    }
}
