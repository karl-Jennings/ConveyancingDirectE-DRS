using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayModels
{
    [Serializable]
    public class ResponseOutstanding
    {
        public string UniqueReference { get; set; }
        public string Reference { get; set; }
        public bool Successful { get; set; }
        public string FailedReason { get; set; }
        public string ResponseType { get; set; }
        public string Error { get; set; }
        public List<OutstandingRequests> Requests { get; set; }
        public ResponseOutstanding() 
        {
            Requests = new List<OutstandingRequests>();
        }
        public ResponseOutstanding(BusinessGatewayRepositories.OutstandingRequests.ResponseOutstandingRequestsType item)
        {
            if(item.Results != null)
            {
                if(item.Results.OutstandingRequests != null)
                {
                    Requests = new List<OutstandingRequests>();
                    foreach (var _req in item.Results.OutstandingRequests)
                    {
                        Requests.Add(new OutstandingRequests { Id = _req.ID.MessageID, NewRequest = _req.NewResponse.Value, ServiceType = ServiceType(_req.ServiceType) });
                    }
                }
            }
        }
        private string ServiceType(int Service)
        {
            string _service = "";
            switch (Service)
            {
                case 80:
                    _service = "Bankruptcy Search V2_1";
                    break;
                case 81:
                    _service = "Official Search of Part V2_1 ";
                    break;
                case 82:
                    _service = "Official Search of Whole V2_1 ";
                    break;
                case 83:
                    _service = "Full Search V2_1 ";
                    break;
                case 84:
                    _service = "Official Copy - Title Known V2_1 ";
                    break;
                case 85:
                    _service = "Search of the Index Map V2_1 ";
                    break;
                case 86:
                    _service = "OC With Summary V2_1 ";
                    break;
                case 87:
                    _service = "Application to Change Register V1_0 ";
                    break;
                case 88:
                    _service = "Attachment V1_0 ";
                    break;
                case 89:
                    _service = "Correspondence V1_0";
                    break;
                case 90:
                    _service = "Early Completion V1_0 ";
                    break;
                case 92:
                    _service = "Application to Change Register V2_0 ";
                    break;
                case 93:
                    _service = "Attachment V2_0 ";
                    break;
                case 94:
                    _service = "Early Completion V2_0 ";
                    break;

            }
            return _service;
        }
    }
    public class OutstandingRequests
    {
        public string Id { get; set; }
        public string ServiceType { get; set; }
        public bool NewRequest { get; set; } 
    }
}
