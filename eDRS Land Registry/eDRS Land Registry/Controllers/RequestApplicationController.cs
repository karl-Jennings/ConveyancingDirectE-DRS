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
using System.IO;

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

                File.WriteAllText(@"\\cdhpc73\c$\LR_APItempClassError.txt", ObjectDumper.Dump(tempClass).ToString());

                DocumentReference docRef = JsonConvert.DeserializeObject<DocumentReference>(tempClass.Value);

                var apiModel = _restrictionConverter.ArrangeLrApi(docRef);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                if (apiModel == null)
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_APIapiModelError.txt", @"Empty Response");
                }
                else
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_APIapiModelError.txt", ObjectDumper.Dump(apiModel).ToString());
                }

                var response = _services.eDRSApplicationRequest(tempClass.Username, tempClass.Password, apiModel);


                if (response == null)
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_APIError.txt", @"Empty Response");
                }
                else
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_APIError.txt", ObjectDumper.Dump(response).ToString());
                }

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;

                List<RequestLog> attachmentResponse = new List<RequestLog>();
                if (response.Successful)
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_APIresponse.txt", @"response.SuccessFul");
                    var count = 1;
                    docRef.Applications.Where(x => x.IsChecked).ToList().ForEach(app =>
                    {
                        var attResponse = _restrictionConverter.ArrangeAttachmentApi(app, null, docRef.MessageID, count++);
                        File.WriteAllText(@"\\cdhpc73\c$\LR_attResponse.txt", @"attResponse.SuccessFul");
                        var attachmentRequest = _services.AttachmentRequest(tempClass.Username, tempClass.Password, attResponse);
                        File.WriteAllText(@"\\cdhpc73\c$\LR_attachmentRequestResponse.txt", @"attachmentRequest.SuccessFul");
                        var attachmentRequestLog = new RequestLog() { Type = "Attachment" };
                        File.WriteAllText(@"\\cdhpc73\c$\LR_attachmentRequestLog.txt", @"attachmentRequestLog.SuccessFul");
                        attachmentRequestLog.TypeCode = attachmentRequest.GatewayResponse.GatewayResponse.TypeCode.ToString();
                        File.WriteAllText(@"\\cdhpc73\c$\LR_attachmentRequestLog2.txt", @"attachmentRequest2.SuccessFul");
                        attachmentRequestLog.ResponseJson = JsonConvert.SerializeObject(attachmentRequest.GatewayResponse.GatewayResponse);
                        File.WriteAllText(@"\\cdhpc73\c$\LR_attachmentRequestLog3.txt", @"attachmentRequestLog3.SuccessFul");
                        attachmentRequestLog.AttachmentName = app.Document.FileName;
                        File.WriteAllText(@"\\cdhpc73\c$\LR_attachmentRequestLog4.txt", @"attachmentRequestLog4.SuccessFul");
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
                        var attResponse = _restrictionConverter.ArrangeAttachmentApi(null, supDoc, docRef.MessageID, count++);
                        var attachmentRequest = _services.AttachmentRequest(tempClass.Username, tempClass.Password, attResponse);
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

                }

                requestLog.Type = "Application";
                File.WriteAllText(@"\\cdhpc73\c$\ZLR_RequestLogType.txt", @"ZLR_RequestLogType worked");
                requestLog.TypeCode = response.GatewayResponse.GatewayResponse.TypeCode.ToString();
                File.WriteAllText(@"\\cdhpc73\c$\ZLR_RequestLogTypeCode.txt", @"ZLR_RequestLogTypeCode worked");
                requestLog.ResponseJson = JsonConvert.SerializeObject(response.GatewayResponse.GatewayResponse);
                if (response.GatewayResponse.GatewayResponse.Acknowledgement != null)
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_Acknowledgement.txt", @"Acknowledgement not null");
                    requestLog.Description = response.GatewayResponse.GatewayResponse.Acknowledgement.MessageDescription;
                    requestLog.CreatedDate = Convert.ToDateTime(response.GatewayResponse.GatewayResponse.Acknowledgement.Items[0].ToString());
                    requestLog.ResponseType = "Acknowledgement";

                }
                else if (response.GatewayResponse.GatewayResponse.Rejection != null)
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_Rejection.txt", @"Rejection not null");
                    requestLog.Description = response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.Code;
                    requestLog.RejectionReason = response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.Reason;

                    requestLog.ValidationErrors = JsonConvert.SerializeObject(response.GatewayResponse.GatewayResponse.Rejection.RejectionResponse.ValidationErrors);

                    requestLog.ResponseType = "Rejection";

                }
                else if (response.GatewayResponse.GatewayResponse.Results != null)
                {
                    File.WriteAllText(@"\\cdhpc73\c$\LR_Results.txt", @"Results not null");
                    requestLog.ResponseType = "Results";
                }

                requestLog.AttachmentResponse = attachmentResponse;
                return requestLog;

            }
            catch (Exception ex)
            {
                var requestLog = new RequestLog();
                requestLog.IsSuccess = false;
               
            if (ex == null)
            {
                File.WriteAllText(@"\\cdhpc73\c$\LR_NotAPIError.txt", @"Empty Response");
            }
            else
            {
                File.WriteAllText(@"\\cdhpc73\c$\LR_NotAPIError.txt", ex.ToString());
            }
                return requestLog;
            }

        }


    }
}
