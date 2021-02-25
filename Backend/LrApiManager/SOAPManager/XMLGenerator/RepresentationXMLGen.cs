using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;
using LrApiManager.XMLClases;
using System.Xml.XPath;
using System.Xml.Serialization;
using LrApiManager.XMLClases.Requestapplicationtochangeregister;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.FileProviders;

namespace LrApiManager.SOAPManager
{
    public class RepresentationXMLGen
    {
        public RepresentationXMLGen()
        {

        }
        public void GenerateReprecentationElements(Representations representations)
        {


            XmlDocument doc = SerializeToXml(representations);

            string xmlString = doc.InnerXml;

            // Replace SOAP body root element properties

           

            xmlString = xmlString.Replace("<RepresentationsList>", "");
            xmlString = xmlString.Replace("</RepresentationsList>", "");
           

         

            
            
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


      
    }


}
