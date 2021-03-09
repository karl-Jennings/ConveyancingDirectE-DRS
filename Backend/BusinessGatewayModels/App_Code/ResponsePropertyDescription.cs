using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessGatewayRepositories;
using BusinessGatewayModels;


namespace BusinessGatewayModels
{

    public static class TenureType
    {
        public static string TenureDescription(BusinessGatewayRepositories.PropertyDescription.TenureCodeType Tenure)
        {
            switch (Tenure.Value.ToString())
            {
                case "Item0":
                    return "Other";
                case "Item10":
                    return "Freehold";
                case "Item20":
                    return "Leasehold";
                case "Item30":
                    return "Commonhold";
                case "Item40":
                    return "Feuhold";
                case "Item100":
                    return "Mixed";
                case "Item110":
                    return "Unknown";
                case "Item120":
                    return "Unavailable";
                case "Item130":
                    return "Caution Against First Registration";
                case "Item140":
                    return "Rent Charge";
                case "Item150":
                    return "Franchise";
                case "Item160":
                    return "Profit A Prendre In Gross";
                case "Item170":
                    return "Manor";
                default:
                    return "Unknown";
            }
        }
    }

    public class ResponsePropertyDescription
    {
        public string UniqueReference { get; set; }
        public string Reference { get; set; }
        public List<Property> Properties { get; set; }
        public bool Successful { get; set; }
        public string FailedReason { get; set; }
        public ResponsePropertyDescription(BusinessGatewayRepositories.PropertyDescription.ResponseSearchByPropertyDescriptionV2_0Type item)
        {
            try
            {
                var _results = item.GatewayResponse.Results != null ? item.GatewayResponse.Results.Title : null;
                Successful = false;
                UniqueReference = item.GatewayResponse.Acknowledgement != null ? item.GatewayResponse.Acknowledgement.AcknowledgementDetails.UniqueID.Value : "";
                Reference = item.GatewayResponse.Results != null ? item.GatewayResponse.Results.ExternalReference.Reference.Value : null;
                Properties = new List<Property>();
                List<ResponsePropertyDescription> _response_list = new List<ResponsePropertyDescription>();
                //If there is a rejection reason then we fail the request and add the reason to the object
                if (item.GatewayResponse.Rejection != null)
                {
                    Reference = item.GatewayResponse.Rejection.ExternalReference != null ?
                        item.GatewayResponse.Rejection.ExternalReference.Reference.Value : null;
                    //fail the result because we have a rejection reason
                    Successful = false;
                    FailedReason = item.GatewayResponse.Rejection.RejectionResponse.Reason.Value;
                }
                //If there are any results for us then we can itearate through them otherwise we just return the failed object
                if (_results != null)
                {
                    foreach (var _title in _results)
                    {
                        Properties.Add(new Property
                        {
                            BuildingName = _title.Address.BuildingName != null ? _title.Address.BuildingName.Value : null,
                            BuildingNumber = _title.Address.BuildingNumber != null ? _title.Address.BuildingNumber.Value : null,
                            SubBuildingName = _title.Address.SubBuildingName != null ? _title.Address.SubBuildingName.Value : null,
                            StreetName = _title.Address.StreetName != null ? _title.Address.StreetName.Value : null,
                            CityName = _title.Address.CityName != null ? _title.Address.CityName.Value : null,
                            PostCode = _title.Address.PostcodeZone != null ? _title.Address.PostcodeZone.Postcode.Value : null,
                            TenureCode = TenureType.TenureDescription(_title.TenureInformation.TenureTypeCode),
                            TitleNumber = _title.TitleNumber != null ? _title.TitleNumber.Value : null
                        });
                    }
                    //We flag the result as true because we have processed it
                    Successful = true;
                }
                else
                {
                    if (item.GatewayResponse.Acknowledgement != null)
                    {
                        if (item.GatewayResponse.Acknowledgement.AcknowledgementDetails.MessageDescription.Value != null)
                        {
                            FailedReason = item.GatewayResponse.Acknowledgement.AcknowledgementDetails.MessageDescription.Value;
                            Successful = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Rethrow the error to the calling method
                throw;
            }
        
        }
        public void AddPropertyEntry(string ClientRef,string BuildingName, string BuildingNumber, string Postcode, string StreetName,string City, bool? Success, string FailedReason)
        {
            try
            {
                //BusinessGatewayDB.BGEntities _Context = new BGEntities();
                //PropertyRequest _propertyRequest = new BusinessGatewayDB.PropertyRequest
                //{
                //    ClientRef = ClientRef,
                //    BuildingName = BuildingName,
                //    BuildingNumber = BuildingNumber,
                //    DateRequested = DateTime.Now,
                //    Postcode = Postcode,
                //    StreetName = StreetName,
                //    City = City,
                //    Success = Success,
                //    FailedReason = FailedReason
                //};
                //_Context.PropertyRequests.Add(_propertyRequest);
                //_Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public ResponsePropertyDescription() { }
    }
}
