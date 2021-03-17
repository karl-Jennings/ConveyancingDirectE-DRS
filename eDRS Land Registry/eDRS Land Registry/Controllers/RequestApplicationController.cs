using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
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

    public class RequestApplicationController : ApiController
    {
        private readonly RestrictionConverter _restrictionConverter = new RestrictionConverter();


        public class TempClass
        {
            public string Value { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }


        }

        public RequestLog Post([FromBody] TempClass tempClass)
        {
            try
            {
                DocumentReference docRef = JsonConvert.DeserializeObject<DocumentReference>(tempClass.Value);

                var apiModel = _restrictionConverter.ArrangeLrApi(docRef);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                var response = _services.eDRSApplicationRequest(tempClass.Username, tempClass.Password, apiModel);

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;

                List<RequestLog> attachmentResponse = new List<RequestLog>();
                if (response.Successful)
                {
                    var count = 1;
                    docRef.Applications.ForEach(app =>
                    {
                        var attResponse = _restrictionConverter.ArrangeAttachmentApi(app, docRef.MessageID, count++);
                        var attachmentRequest = _services.AttachmentRequest(tempClass.Username, tempClass.Password, attResponse);
                        var attachmentRequestLog = new RequestLog() { Type = "Attachment"};

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

                }

                requestLog.Type = "Application";
                requestLog.TypeCode = response.GatewayResponse.GatewayResponse.TypeCode.ToString();
                requestLog.ResponseJson = JsonConvert.SerializeObject(response.GatewayResponse.GatewayResponse);
                if (response.GatewayResponse.GatewayResponse.Acknowledgement != null)
                {
                    requestLog.Description = response.GatewayResponse.GatewayResponse.Acknowledgement.MessageDescription;
                    requestLog.CreatedDate = Convert.ToDateTime(response.GatewayResponse.GatewayResponse.Acknowledgement.Items[0].ToString());
                    requestLog.ResponseType = "Acknowledgement";

                }
                else if (response.GatewayResponse.GatewayResponse.Rejection != null)
                {
                    requestLog.Description = response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.Code;
                    requestLog.RejectionReason = response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.Reason;

                    requestLog.ValidationErrors = JsonConvert.SerializeObject(response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.ValidationErrors);

                    requestLog.ResponseType = "Rejection";

                }
                else if (response.GatewayResponse.GatewayResponse.Results != null)
                {
                    requestLog.ResponseType = "Results";
                }

                requestLog.AttachmentResponse = attachmentResponse;
                return requestLog;

            }
            catch (Exception ex)
            {
                var requestLog = new RequestLog();
                requestLog.IsSuccess = false;
                return requestLog;
            }

        }


    }
}
