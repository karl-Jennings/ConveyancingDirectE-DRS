using System;
using System.Collections.Generic;
using System.Text;

namespace eDrsManagers.ViewModels
{
    public class OutstandingResponse
    {
        public string UniqueReference { get; set; }
        public string Reference { get; set; }
        public bool Successful { get; set; }
        public string FailedReason { get; set; }
        public string ResponseType { get; set; }
        public string Error { get; set; }
        public List<OutstandingRequests> Requests { get; set; }
    }
}
