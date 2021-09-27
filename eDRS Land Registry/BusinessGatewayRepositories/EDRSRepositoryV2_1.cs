using BusinessGatewayRepositories.EDRSApplicationV2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class EDRSRepositoryV2_1
    {
        public EDRSRepositoryV2_1() { }
        public BusinessGatewayRepositories.EDRSApplicationV2_1.ResponseApplicationToChangeRegisterV2_0Type edrsAllpicationRequest(RequestApplicationToChangeRegisterV2_1Type _request,  string username,string password)
        {
            // EDRSApplication.RequestApplicationToChangeRegisterV1_0Type _request = new EDRSApplication.RequestApplicationToChangeRegisterV1_0Type();

            EDRSApplicationV2_1.ApplicationType _application_type = new EDRSApplicationV2_1.ApplicationType();
            EDRSApplicationV2_1.ProductType _product = new EDRSApplicationV2_1.ProductType();
            EDRSApplicationV2_1.EDocumentRegistrationV2_1ServiceClient _service = new EDRSApplicationV2_1.EDocumentRegistrationV2_1ServiceClient();
            BusinessGatewayRepositories.EDRSApplicationV2_1.ResponseApplicationToChangeRegisterV2_0Type _response = new BusinessGatewayRepositories.EDRSApplicationV2_1.ResponseApplicationToChangeRegisterV2_0Type();
          
            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));
            _response=  _service.eDocumentRegistration(_request);

            return _response;

         }


    }
}
