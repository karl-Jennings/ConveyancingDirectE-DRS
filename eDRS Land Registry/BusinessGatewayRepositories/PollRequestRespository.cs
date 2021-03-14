using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class PollRequestRespository
    {
        public BusinessGatewayRepositories.PollService.ResponseApplicationToChangeRegisterV2_0Type GetRequests(string MessageId,string Username, string Password)
        {
            BusinessGatewayRepositories.PollService.PollRequestType _request = new BusinessGatewayRepositories.PollService.PollRequestType();
            BusinessGatewayRepositories.PollService.EDocumentRegistrationV2_1PollRequestServiceClient _service = new BusinessGatewayRepositories.PollService.EDocumentRegistrationV2_1PollRequestServiceClient();
            _request.ID = new BusinessGatewayRepositories.PollService.Q1IdentifierType { MessageID = new BusinessGatewayRepositories.PollService.MessageIDTextType { Value = MessageId } };
          
           _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(Username, Password));

            BusinessGatewayRepositories.PollService.ResponseApplicationToChangeRegisterV2_0Type _reponse = _service.getResponse(_request);
            return _reponse;

        }
    }
}
