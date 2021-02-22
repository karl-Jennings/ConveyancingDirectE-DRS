using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using LrApiManager.XMLClases;
using Microsoft.Extensions.FileProviders;
using LrApiManager.XMLClases.Restriction;

namespace LrApiManager.SOAPManager
{
    public class RestrictionPollRequest
    {
        public RestrictionPollResponse PoolRequest(string MessageID)
        {
            PoolRequest PoolRequest = new PoolRequest
            {
                MessageID = MessageID
            };

            XmlDocument doc = SerializeToXml(PoolRequest);

            string xmlString = doc.InnerXml;
            // Replace SOAP body root element properties

            // web service name=>eDocumentRegistration
            xmlString = xmlString.Replace("PoolRequest", "getResponse");
            xmlString = xmlString.Replace("xmlns:xsi", "xmlns:ns2");
            xmlString = xmlString.Replace("xmlns:xsd", "xmlns:ns3");
            xmlString = xmlString.Replace("http://www.w3.org/2001/XMLSchema-instance", "http://www.oscre.org/ns/eReg/MR01-20090605/PollRequest");
            xmlString = xmlString.Replace("http://www.w3.org/2001/XMLSchema", "http://poll.drsv2_1.ws.bg.lr.gov/");
            xmlString = xmlString.Replace("<MessageID>", "<arg0><ID><MessageID>");
            xmlString = xmlString.Replace("</MessageID>", "</MessageID></ID></arg0>");

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

            RestrictionPollResponse _restrictionPoolResponse = GetPoolResponse();

            return _restrictionPoolResponse;
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

        public RestrictionPollResponse GetPoolResponse()
        {
            Directory.CreateDirectory("XMLTest");
            var rootFolder = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "XMLTest")).Root;

            string xml = System.IO.File.ReadAllText(rootFolder + @"PoolResponse.txt");
            //string xml = System.IO.File.ReadAllText(@"E:\Accura-tech\eDRS DEV2\Backend\eDrsAPI\XMLTest\PoolResponse.txt");

            xml = xml.Replace("ns3:", "");
            xml = xml.Replace("ns4:", "");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            // XML convert to Jason
            string json = JsonConvert.SerializeXmlNode(doc);
            var jo = JObject.Parse(json);

            //get GatewayResponse from Jason object
            var _GatewayResponse = jo["getResponseResponse"]["GatewayResponse"].ToString();

            _GatewayResponse = _GatewayResponse.Replace("@filename", "filename");
            _GatewayResponse = _GatewayResponse.Replace("@format", "format");
            _GatewayResponse = _GatewayResponse.Replace("#text", "byteArray");

            // Deserialize Jason to object
            RestrictionPollResponse gatewayResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<RestrictionPollResponse>(_GatewayResponse);

            return gatewayResponse;
        }

    }
}
