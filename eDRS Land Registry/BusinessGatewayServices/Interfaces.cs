using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BusinessGatewayRepositories;
using BusinessGatewayModels;

namespace BusinessGatewayServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServices
    {
        
        [OperationContract]
        bool PropertyDescription(string MessageId, string AllocatedBy, string Description, string CustomerReference,string ExternalReference, string BuildingName, string BuildingNumber, string StreetName, string CityName, string Postcode,string Username, string Password);
    
        [OperationContract]
        ResponsePropertyDescription PropertyDescriptionMessage(string MessageId, string AllocatedBy, string Description, string CustomerReference, string ExternalReference, string BuildingName, string BuildingNumber, string StreetName, string CityName, string Postcode, string Username, string Password);

        [OperationContract]
        ResponseBankruptcySearch BankruptcySearch(string MessageId, string AllocatedBy, string Description, string CustomerReference, string ExternalReference,
            string Contact, string Phone, decimal ExpectedAmount, BusinessGatewayModels.Search[] SearchDetails);

        [OperationContract]
        ResponseOwnerVerification OwnerVerification(string Reference, string MessageId, string FirstName, string MiddleName, string LastName, string TitleNumber, string HouseName, string HouseNumber, string Postcode, string UserName, string Password);
        [OperationContract]
        ResponseOutstanding Outstanding(string MessageId, int service,string Username, string Password);
    }

}
