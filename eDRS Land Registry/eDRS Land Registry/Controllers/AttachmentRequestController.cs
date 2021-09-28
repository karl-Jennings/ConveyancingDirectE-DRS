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

namespace eDRS_Land_Registry.Controllers
{

    public class AttachmentRequestController : ApiController
    {
        private readonly RestrictionConverter _restrictionConverter = new RestrictionConverter();
        private readonly RestrictionConverterV2_1 _restrictionConverterV2_1 = new RestrictionConverterV2_1();

        public List<RequestLog> Post([FromBody] TempClass tempClass)
        {
            try
            {
                var services = new Services();

                var attachmentViewModel = JsonConvert.DeserializeObject<AttachmentViewModel>(tempClass.Value);
                var docRef = attachmentViewModel.DocumentReference;
                var attachmentResponse = new List<RequestLog>();

                var count = 1;
                docRef.Applications.Where(x => x.IsChecked).ToList().ForEach(app =>
                  {
                      //var attResponse = _restrictionConverter.ArrangeAttachmentApi(app, null, docRef.MessageID, count++);
                      //var attachmentRequest = services.AttachmentRequest(attachmentViewModel.Username, attachmentViewModel.Username, attResponse);

                      var attResponse = _restrictionConverterV2_1.ArrangeAttachmentApi(app, null, docRef.MessageID, count++, docRef.AdditionalProviderFilter);
                      var attachmentRequest = services.AttachmentRequestV2_1(attachmentViewModel.Username, attachmentViewModel.Username, attResponse);


                      var attachmentRequestLog = new RequestLog() { Type = "Attachment" };

                      attachmentRequestLog.TypeCode = attachmentRequest.GatewayResponse.GatewayResponse.TypeCode.ToString();
                      attachmentRequestLog.ResponseJson = JsonConvert.SerializeObject(attachmentRequest.GatewayResponse.GatewayResponse);
                      attachmentRequestLog.AttachmentName = app.Document.FileName;
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

                      attachmentResponse.Add(attachmentRequestLog);
                  });

                docRef.SupportingDocuments.Where(x => x.IsChecked).ToList().ForEach(supDoc =>
                {
                    //var attResponse = _restrictionConverter.ArrangeAttachmentApi(null, supDoc, docRef.MessageID, count++);
                    //var attachmentRequest = services.AttachmentRequest(attachmentViewModel.Username, attachmentViewModel.Password, attResponse);

                    var attResponse = _restrictionConverterV2_1.ArrangeAttachmentApi(null, supDoc, docRef.MessageID, count++,docRef.AdditionalProviderFilter);
                    var attachmentRequest = services.AttachmentRequestV2_1(attachmentViewModel.Username, attachmentViewModel.Password, attResponse);

                    var attachmentRequestLog = new RequestLog() { Type = "Attachment" };

                    attachmentRequestLog.TypeCode = attachmentRequest.GatewayResponse.GatewayResponse.TypeCode.ToString();
                    attachmentRequestLog.ResponseJson = JsonConvert.SerializeObject(attachmentRequest.GatewayResponse.GatewayResponse);
                    attachmentRequestLog.AttachmentName = supDoc.FileName;
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

                    attachmentResponse.Add(attachmentRequestLog);
                });


                return attachmentResponse;

            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
