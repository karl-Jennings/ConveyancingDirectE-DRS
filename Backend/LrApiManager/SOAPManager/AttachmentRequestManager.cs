using LrApiManager.XMLClases;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Serialization;

namespace LrApiManager.SOAPManager
{
    public class AttachmentRequestManager
    {

        public AttachmentResponse RequestAttachment(AttachmentRequest attachmentRequest) {

            XmlDocument doc = SerializeToXml(attachmentRequest);

            string xmlString = doc.InnerXml;
            // Replace SOAP body root element properties

            // web service name=>eDocumentRegistration
            xmlString = xmlString.Replace("AttachmentRequest", "newAttachment");
            xmlString = xmlString.Replace("xmlns:xsi", "xmlns:ns1");
            xmlString = xmlString.Replace("xmlns:xsd", "xmlns:ns3");
            xmlString = xmlString.Replace("http://www.w3.org/2001/XMLSchema-instance", "http://www.oscre.org/ns/eReg-Final/2012/RequestAttachmentV2_1");
            xmlString = xmlString.Replace("http://www.w3.org/2001/XMLSchema", "http://attachmentv2_1.ws.bg.lr.gov/");
            xmlString = xmlString.Replace("<AdditionalProviderFilter>", "<arg0><AdditionalProviderFilter>");
            xmlString = xmlString.Replace("</newAttachment>", "</arg0></newAttachment>");


            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request  
            SOAPReqBody.LoadXml(xmlString);


            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }


            ///GET RESPONSE FROM text file
            ///

            AttachmentResponse _attachmentResponse = GetAttachmentResponse();

            return _attachmentResponse;
            //Geting response from request  
            //using (WebResponse Serviceres = request.GetResponse())
            //{
            //    using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
            //    {
            //        //reading stream  
            //        var ServiceResult = rd.ReadToEnd();
            //        //writting stream result on console  
            //        Console.WriteLine(ServiceResult);
            //        Console.ReadLine();
            //    }
            //}


        }

        public XmlDocument SerializeToXml<T>(T source)
        {
            var document = new XmlDocument();
            var navigator = document.CreateNavigator();

            using (var writer = navigator.AppendChild())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, source);
            }
            return document;
        }

        public HttpWebRequest CreateSOAPWebRequest()
        {
            //Making Web Request  
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"http://localhost/Employee.asmx");
            //SOAPAction  
            Req.Headers.Add(@"SOAPAction:http://tempuri.org/Addition");
            //Content_type  
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method  
            Req.Method = "POST";
            //return HttpWebRequest  
            return Req;
        }

        public AttachmentResponse GetAttachmentResponse()
        {

            string xml = System.IO.File.ReadAllText(@"E:\Accura-tech\LR eDRS Dev\Backend\LrApiManager\AttachmentResponse.txt");

            xml = xml.Replace("ns3:", "");
            xml = xml.Replace("ns4:", "");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            // XML convert to Jason
            string json = JsonConvert.SerializeXmlNode(doc);
            var jo = JObject.Parse(json);

            //get GatewayResponse from Jason object
            var _GatewayResponse = jo["newAttachmentResponse"]["return"]["GatewayResponse"].ToString();



            // Deserialize Jason to object
            AttachmentResponse gatewayResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<AttachmentResponse>(_GatewayResponse);

            return gatewayResponse;
        }

    }
}
