using System;
using System.Collections.Generic;
using System.Text;

namespace LrApiManager.XMLClases
{
    public class AttachmentRequest
    {
        public AttachmentRequest() { }
        public string AdditionalProviderFilter { get; set; }
        public string MessageId { get; set; }
        public string ExternalReference { get; set; }
        public string ApplicationMessageId { get; set; }
        public string ApplicationService { get; set; }
        public int?  AttachmentId { get; set; }
        public string CertifiedCopy { get; set; }
        public byte[] Attachment { get; set; }
    }
}
