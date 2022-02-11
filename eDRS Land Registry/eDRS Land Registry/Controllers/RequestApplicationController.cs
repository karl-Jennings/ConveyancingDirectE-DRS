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
using System.Xml.Serialization;
using BusinessGatewayRepositories.EDRSApplicationV2_1;

namespace eDRS_Land_Registry.Controllers
{

    public class RequestApplicationController : ApiController
    {
        private readonly RestrictionConverter _restrictionConverter = new RestrictionConverter();
        private readonly RestrictionConverterV2_1 _restrictionConverterV2_1 = new RestrictionConverterV2_1();


        public class TempClass
        {
            public string Value { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

        }

        public RequestLog Post([FromBody] TempClass tempClass)
        {

            RequestApplicationToChangeRegisterV2_1Type apiModel = new RequestApplicationToChangeRegisterV2_1Type();
            try
            {
                DocumentReference docRef = JsonConvert.DeserializeObject<DocumentReference>(tempClass.Value);
                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                //DocumentReference docRef = tempClass.Value;

                //V1_0
                //var apiModel = _restrictionConverter.ArrangeLrApi(docRef);
                //var response = _services.eDRSApplicationRequest(tempClass.Username, tempClass.Password, apiModel);

                //V2_1
                apiModel = _restrictionConverterV2_1.ArrangeLrApi(docRef);
                var response = _services.eDRSApplicationRequestV2_1(tempClass.Username, tempClass.Password, apiModel);

                             var requestLog = new RequestLog();
                requestLog.IsSuccess = true;

                //Convert Request to XML
                if (apiModel!=null) {
                    requestLog.CreateRegistrationXMLRequest = SerializeToXMLString(apiModel);
                }
               

                List<RequestLog> attachmentResponse = new List<RequestLog>();

                if (response.Successful)
                {                  

                    var count = 1;
                    docRef.Applications.Where(x => x.IsChecked).ToList().ForEach(app =>
                    {
                        // var attchemnt = _restrictionConverter.ArrangeAttachmentApi(app, null, docRef.MessageID, count++);
                        // var attachmentRequest = _services.AttachmentRequest(tempClass.Username, tempClass.Password, attchemnt);
                   

                        var attchemnt = _restrictionConverterV2_1.ArrangeAttachmentApi(app, null, docRef.MessageID, docRef.MessageID, count++,docRef.AdditionalProviderFilter);
                        var attachmentRequest = _services.AttachmentRequestV2_1(tempClass.Username, tempClass.Password, attchemnt);
                       
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


                    if (docRef.SupportingDocuments!=null) {
                        docRef.SupportingDocuments.Where(x => x.IsChecked).ToList().ForEach(supDoc =>
                        {
                            //var attResponse = _restrictionConverter.ArrangeAttachmentApi(null, supDoc, docRef.MessageID, count++);
                            //var attachmentRequest = _services.AttachmentRequest(tempClass.Username, tempClass.Password, attResponse);

                            var attResponse = _restrictionConverterV2_1.ArrangeAttachmentApi(null, supDoc, docRef.MessageID, docRef.MessageID, count++, docRef.AdditionalProviderFilter);
                            var attachmentRequest = _services.AttachmentRequestV2_1(tempClass.Username, tempClass.Password, attResponse);

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

                if (apiModel!=null) {
                    requestLog.CreateRegistrationXMLRequest = SerializeToXMLString(apiModel);
                }              

                requestLog.IsSuccess = false;
                return requestLog;
            }

        }

        private static string SerializeToXMLString<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch
            {
                throw;
            }
        }

    }
}
