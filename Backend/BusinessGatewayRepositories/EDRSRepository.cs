using BusinessGatewayRepositories.EDRSApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class EDRSRepository
    {
        public EDRSRepository() { }
        public BusinessGatewayRepositories.EDRSApplication.ResponseApplicationToChangeRegisterV1_0Type edrsAllpicationRequest(RequestApplicationToChangeRegisterV1_0Type _request,  string username,string password)
        {
           // EDRSApplication.RequestApplicationToChangeRegisterV1_0Type _request = new EDRSApplication.RequestApplicationToChangeRegisterV1_0Type();

            EDRSApplication.ApplicationType _application_type = new EDRSApplication.ApplicationType();
            EDRSApplication.ProductType _product = new EDRSApplication.ProductType();
            EDRSApplication.EDocumentRegistrationV1_0ServiceClient _service = new EDRSApplication.EDocumentRegistrationV1_0ServiceClient("https://bgtest.landregistry.gov.uk/b2b/ECBG_StubService/EnquiryByPropertyDescriptionV2_0WebService");
            BusinessGatewayRepositories.EDRSApplication.ResponseApplicationToChangeRegisterV1_0Type _response = new ResponseApplicationToChangeRegisterV1_0Type();
          
            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));
            _response=  _service.eDocumentRegistration(_request);

            return _response;

         }


    }
}
