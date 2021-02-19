using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;
using LrApiManager.XMLClases;
using System.Xml.XPath;
using System.Xml.Serialization;
using LrApiManager.XMLClases.TransferOfPart;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.FileProviders;

namespace LrApiManager.SOAPManager.TransferOfPart
{
    public class TransferOfPartRequestManager
    {
        public TransferOfPartRequestManager()
        {

        }
        public ApplicationResponse RequestTransferOfPartApplication(TransferOfPartApplicationRequest TransferOfPartApplicationRequest)
        {


            XmlDocument doc = SerializeToXml(TransferOfPartApplicationRequest);

            string xmlString = doc.InnerXml;

            // Replace SOAP body root element properties

            // web service name=>eDocumentRegistration
            xmlString = xmlString.Replace("TransferOfPartApplicationRequest", "eDocumentRegistration");
            xmlString = xmlString.Replace("xmlns:xsi", "xmlns:ns2");
            xmlString = xmlString.Replace("xmlns:xsd", "xmlns:ns3");
            xmlString = xmlString.Replace("http://www.w3.org/2001/XMLSchema-instance", "http://www.oscre.org/ns/eReg-Final/2012/RequestApplicationToChangeRegisterV2_1");
            xmlString = xmlString.Replace("http://www.w3.org/2001/XMLSchema", "http://drsv2_1.ws.bg.lr.gov/");
            xmlString = xmlString.Replace("<AdditionalProviderFilter>", "<arg0><AdditionalProviderFilter>");
            xmlString = xmlString.Replace("</eDocumentRegistration>", "</arg0></eDocumentRegistration>");


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

            ApplicationResponse applicationResponse = GetApplicationResponse();

            return applicationResponse;
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


        public ApplicationResponse GetApplicationResponse()
        {
            //Directory.CreateDirectory("XMLTest");
            //var rootFolder = new PhysicalFileProvider(
            //    Path.Combine(Directory.GetCurrentDirectory(), "XMLTest")).Root;

            string xml = System.IO.File.ReadAllText(@"D:\Development\EDRS Dev\ConveyancingDirect_e-DRS\Backend\eDrsAPI\XMLTest\ApplicationResponse.txt");

            xml = xml.Replace("ns3:", "");
            xml = xml.Replace("ns4:", "");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            // XML convert to Jason
            string json = JsonConvert.SerializeXmlNode(doc);
            var jo = JObject.Parse(json);

            //get GatewayResponse from Jason object
            var _GatewayResponse = jo["eDocumentRegistrationResponse"]["return"]["GatewayResponse"].ToString();



            // Deserialize Jason to object
            ApplicationResponse gatewayResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApplicationResponse>(_GatewayResponse);

            return gatewayResponse;
        }
    }


}
