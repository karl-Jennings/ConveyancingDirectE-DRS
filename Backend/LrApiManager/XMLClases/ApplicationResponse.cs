using System;
using System.Collections.Generic;
using System.Text;

namespace LrApiManager.XMLClases
{  

    public class ApplicationResponse
    {
        public int TypeCode { get; set; }
        public Acknowledgement Acknowledgement { get; set; }
    }

    public class Acknowledgement
    {
        public string UniqueID { get; set; }
        public string MessageDescription { get; set; }
        public string PriorityDateTime { get; set; }
        public string ABR { get; set; }
    }

}
