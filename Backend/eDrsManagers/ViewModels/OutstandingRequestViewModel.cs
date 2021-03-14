using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrsManagers.ViewModels
{
    public class OutstaningRequestViewModel
    {
        public string MessageId { get; set; }
        public int Service { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class OutstaningResponseViewModel
    {
        public string UniqueReference { get; set; }
        public string Reference { get; set; }
        public bool Successful { get; set; }
        public string FailedReason { get; set; }
        public string ResponseType { get; set; }
        public string Error { get; set; }
        public List<OutstandingRequests> Requests { get; set; }
    }

    public class OutstandingRequests
    {
        public string Id { get; set; }
        public string ServiceType { get; set; }
        public bool NewResponse { get; set; }
        public int TypeCode { get; set; }
    }
}
