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
using BusinessGatewayRepositories.AttachmentServiceRequestV2_1;

namespace eDRS_Land_Registry.Controllers
{

    public class RequestApplicationController : ApiController
    {
        private readonly RestrictionConverter _restrictionConverter = new RestrictionConverter();
        private readonly ApiConverter _apiConverter = new ApiConverter();


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
                apiModel = _apiConverter.ArrangeLrApi(docRef);
                var response = _services.eDRSApplicationRequestV2_1(tempClass.Username, tempClass.Password, apiModel);

                var requestLog = new RequestLog();
                requestLog.IsSuccess = true;
                requestLog.Type = "Application";

                //Convert Request to XML
                if (apiModel!=null) {
                    requestLog.CreateRegistrationXMLRequest = SerializeToXMLString(apiModel);
                }
               

                List<RequestLog> attachmentResponse = new List<RequestLog>();

                //Sent Attachments to the Attachment service
                if (response.Successful 
                    && response.GatewayResponse!=null
                    && response.GatewayResponse.GatewayResponse!=null 
                    && ( response.GatewayResponse.GatewayResponse.TypeCode.ToString()=="Item10" ||
                    response.GatewayResponse.GatewayResponse.TypeCode.ToString() == "Item30"))
                {                 
                
                    docRef.Applications.Where(x => x.IsChecked).ToList().ForEach(app =>
                    {                    
                        var attchemnt = _apiConverter.ArrangeAttachmentApi(app, null, docRef.MessageID, docRef.AdditionalProviderFilter);
                        var attachmentRequest= AttachmentRequest(attchemnt, tempClass.Username, tempClass.Password, app.Document.FileName);
                     
                        attachmentResponse.Add(attachmentRequest);
                    });

                    if (docRef.SupportingDocuments!=null) {

                        docRef.SupportingDocuments.Where(x => x.IsChecked).ToList().ForEach(supDoc =>
                        {
                            var attchemnt = _apiConverter.ArrangeAttachmentApi(null, supDoc, docRef.MessageID, docRef.AdditionalProviderFilter);
                            var attachmentRequest = AttachmentRequest(attchemnt, tempClass.Username, tempClass.Password, supDoc.FileName);
                        
                            attachmentResponse.Add(attachmentRequest);
                        });
                    }               
                }

              

                if (response.GatewayResponse != null && response.GatewayResponse.GatewayResponse != null)
                {
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
                }

                requestLog.AttachmentResponse = attachmentResponse;

                if (!response.Successful)
                {

                    requestLog.IsSuccess = false;
                    requestLog.Description = response.Error.Message;
                    requestLog.ValidationErrors = JsonConvert.SerializeObject(response.Error);

                }

                return requestLog;

            }
            catch (Exception ex)
            {                

                var requestLog = new RequestLog();

                if (apiModel!=null) {
                    requestLog.CreateRegistrationXMLRequest = SerializeToXMLString(apiModel);
                }              

                requestLog.IsSuccess = false;
                requestLog.ResponseJson = JsonConvert.SerializeObject(ex.InnerException);

                return requestLog;
            }

        }

        private RequestLog AttachmentRequest(AttachmentV2_1Type attchemnt,string username,string Password ,string filename) {

            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            RequestLog attachmentRespons = new RequestLog();

            var attachmentResponse = _services.AttachmentRequestV2_1(username, Password, attchemnt);

            var attachmentRequestLog = new RequestLog() { Type = "Attachment" };

            attachmentRequestLog.MessageId = attchemnt.MessageId;
            
            if (attachmentResponse.GatewayResponse!=null
                && attachmentResponse.GatewayResponse.GatewayResponse!=null) {

                attachmentRequestLog.TypeCode = attachmentResponse.GatewayResponse.GatewayResponse.TypeCode.ToString();
                attachmentRequestLog.ResponseJson = JsonConvert.SerializeObject(attachmentResponse.GatewayResponse.GatewayResponse);
                attachmentRequestLog.AttachmentName = filename;
                if (attachmentResponse.GatewayResponse.GatewayResponse.Acknowledgement != null)
                {
                    attachmentRequestLog.Description = attachmentResponse.GatewayResponse.GatewayResponse.Acknowledgement.MessageDescription;
                    attachmentRequestLog.CreatedDate = (attachmentResponse.GatewayResponse.GatewayResponse.Acknowledgement.ExpectedResponseDateTime);
                    attachmentRequestLog.ResponseType = "Acknowledgement";
                }
                else if (attachmentResponse.GatewayResponse.GatewayResponse.Rejection != null)
                {
                    attachmentRequestLog.Description = attachmentResponse.GatewayResponse.GatewayResponse.Rejection.Code;
                    attachmentRequestLog.RejectionReason = attachmentResponse.GatewayResponse.GatewayResponse.Rejection.Reason;
                    attachmentRequestLog.ValidationErrors = JsonConvert.SerializeObject(attachmentResponse.GatewayResponse.GatewayResponse.Rejection.ValidationErrors);
                    attachmentRequestLog.ResponseType = "Rejection";
                }
            }            
         
            return attachmentRequestLog;
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
