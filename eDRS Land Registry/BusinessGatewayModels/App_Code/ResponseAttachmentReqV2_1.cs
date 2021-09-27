using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Configuration;
using BusinessGatewayRepositories;
using BusinessGatewayModels;
using BusinessGatewayRepositories.EDRSApplication;
using BusinessGatewayRepositories.AttachmentServiceRequestV2_1;

namespace BusinessGatewayModels
{
    public class ResponseAttachmentRequestV2_1
    {
        public ResponseAttachmentRequestV2_1() { }
        public Exception Error { get; set; }
        public string UniqueReference { get; set; }
        public decimal ActualPrice { get; set; }
        public bool Successful { get; set; }
        public string MessageDetails { get; set; }
        public DateTime ExpiryDate { get; set; }       
        public string UserName { get; set; }
        public bool Attachment { get; set; }
        public AttachmentResponseV2_1Type GatewayResponse { get; set; }
    }
     
}
