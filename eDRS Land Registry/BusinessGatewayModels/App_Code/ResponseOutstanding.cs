
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            if (item.Results != null)
            {

                var value = item.TypeCode.Value;

                var _typecode = ((XmlEnumAttribute)typeof(BusinessGatewayRepositories.OutstandingRequests.ProductResponseCodeContentType)
                                        .GetMember(value.ToString())[0]
                                        .GetCustomAttributes(typeof(XmlEnumAttribute), false)[0])
                                        .Name;

                if (item.Results.OutstandingRequests != null)
                {
                    Requests = new List<OutstandingRequests>();
                    foreach (var _req in item.Results.OutstandingRequests)
                    {
                        Requests.Add(new OutstandingRequests { Id = _req.ID.MessageID, NewResponse = _req.NewResponse.Value, ServiceType = ServiceType(_req.ServiceType), TypeCode = Convert.ToInt32(_typecode) });
                    }
                }
            }
        }
        private string ServiceType(int Service)
        {
            string _service = "";
            switch (Service)
            {
                //case 80:
                //    _service = "Bankruptcy Search V2_1";
                //    break;
                //case 81:
                //    _service = "Official Search of Part V2_1 ";
                //    break;
                //case 82:
                //    _service = "Official Search of Whole V2_1 ";
                //    break;
                //case 83:
                //    _service = "Full Search V2_1 ";
                //    break;
                //case 84:
                //    _service = "Official Copy - Title Known V2_1 ";
                //    break;
                //case 85:
                //    _service = "Search of the Index Map V2_1 ";
                //    break;
                //case 86:
                //    _service = "OC With Summary V2_1 ";
                //    break;
                //case 87:
                //    _service = "Application to Change Register V1_0 ";
                //    break;
                //case 88:
                //    _service = "Attachment V1_0 ";
                //    break;
                //case 89:
                //    _service = "Correspondence V1_0";
                //    break;
                //case 90:
                //    _service = "Early Completion V1_0 ";
                //    break;
                //case 92:
                //    _service = "Application to Change Register V2_0 ";
                //    break;
                //case 93:
                //    _service = "Attachment V2_0 ";
                //    break;
                //case 94:
                //    _service = "Early Completion V2_0 ";
                //    break;


                ////
                ///

                case 53:
                    _service = "Official Copy -Title Known";
                    break;
                case 54:
                    _service = "Official Search of Whole";
                    break;
                case 55:
                    _service = "Bankruptcy Search";
                    break;
                case 56:
                    _service = "Search by Property Description";
                    break;
                case 58:
                    _service = "OC With Summary";
                    break;
                case 60:
                    _service = "Bankruptcy Search V1_1";
                    break;
                case 61:
                    _service = "Search by Property Description V1_1";
                    break;
                case 63:
                    _service = "Official Copy -Title Known V1_1";
                    break;
                case 64:
                    _service = "Official Search of Whole V1_1";
                    break;
                case 65:
                    _service = "OC With Summary V1_1";
                    break;
                case 70:
                    _service = "Daylist Enquiry V2_0";
                    break;
                case 71:
                    _service = "Bankruptcy Search V2_0";
                    break;
                case 72:
                    _service = "Official Search of Part V2_0";
                    break;
                case 73:
                    _service = "Official Search of Whole V2_0";
                    break;
                case 74:
                    _service = "Full Search V2_0";
                    break;
                case 75:
                    _service = "Search by Property Description V2_0";
                    break;
                case 76:
                    _service = "Official Copy -Title Known V2_0";
                    break;
                case 77:
                    _service = "Search of the Index Map V2_0";
                    break;
                case 79:
                    _service = "OC With Summary V2_0";
                    break;
                case 80:
                    _service = "Bankruptcy Search V2_1";
                    break;
                case 81:
                    _service = "Official Search of Part V2_1"; 
                    break;
                case 82:
                    _service = "Official Search of Whole V2_1";
                    break;
                case 83:
                    _service = "Full Search V2_1"; 
                    break;
                case 84:
                    _service = "Official Copy -Title Known V2_1";
                    break;
                case 85:
                    _service = "Search of the Index Map V2_1"; 
                    break;
                case 86:
                    _service = "OC With Summary V2_1"; 
                    break;
                case 87:
                    _service = "Application to Change Register V1_0"; 
                    break;
                case 88:
                    _service = "Attachment V1_0"; 
                    break;
                case 89:
                    _service = "Correspondence V1_0"; 
                    break;
                case 90:
                    _service = "Early Completion V1_0"; 
                    break;
                case 91:
                    _service = "Online Ownership Verification V1_0"; 
                    break;
                case 92:
                    _service = "Application to Change Register V2_0"; 
                    break;
                case 93:
                    _service = "Attachment V2_0"; 
                    break;
                case 94:
                    _service = "Early Completion V2_0"; 
                    break;
                case 104:
                    _service = "Application to Change Register V2_1"; 
                    break;
                case 105:
                    _service = "Attachment V2_1"; 
                    break;
                case 107:
                    _service = "Correspondence V2_1"; 
                    break;
                case 108:
                    _service = "Early Completion V2_1"; 
                    break;
                case 110:
                    _service = "Local Land Charges Search V2_0"; 
                    break;
                case 111:
                    _service = "Application Enquiry V1_0"; 
                    break;
                case 112:
                    _service = "Discharge Activity V1_0"; 
                    break;
            }
            return _service;
        }
    }
    public class OutstandingRequests
    {
        public string Id { get; set; }
        public string ServiceType { get; set; }
        public bool NewResponse { get; set; }
        public int TypeCode { get; set; }
    }
}
