using System;
using System.Collections.Generic;
using System.Text;

namespace LrApiManager.XMLClases
{
    public class AttachmentNotesRequest
    {
        public AttachmentNotesRequest() { }
        public string AdditionalProviderFilter { get; set; }
        public string MessageId { get; set; }
        public string ExternalReference { get; set; }
        public string ApplicationMessageId { get; set; }
        public string ApplicationService { get; set; }
        public string Notes { get; set; }
       
    }
}
