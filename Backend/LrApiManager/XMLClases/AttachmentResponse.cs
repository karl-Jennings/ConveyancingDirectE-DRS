using System;
using System.Collections.Generic;
using System.Text;

namespace LrApiManager.XMLClases
{

   
    public class AttachmentResponse
    {
        public int TypeCode { get; set; }
        public AtacmntResponseAcknowledgement Acknowledgement { get; set; }
    }

    public class AtacmntResponseAcknowledgement
    {
        public string UniqueID { get; set; }
        public string MessageDescription { get; set; }
    }

}
