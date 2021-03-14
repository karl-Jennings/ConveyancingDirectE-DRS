using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessGatewayRepositories.EarlyCompletion;

namespace BusinessGatewayRepositories
{
    public class EarlyCompletionRepository
    {
        public EarlyCompletionRepository() { }
        public BusinessGatewayRepositories.EarlyCompletion.ResponseEarlyCompletionV2_0Type EarlyCompletionRequest(string MessageID,  string username,string password)
        {

            BusinessGatewayRepositories.EarlyCompletion.PollRequestType _request = new BusinessGatewayRepositories.EarlyCompletion.PollRequestType();
            BusinessGatewayRepositories.EarlyCompletion.EarlyCompletionV2_1PollRequestServiceClient _service = new BusinessGatewayRepositories.EarlyCompletion.EarlyCompletionV2_1PollRequestServiceClient();
            BusinessGatewayRepositories.EarlyCompletion.ResponseEarlyCompletionV2_0Type _response = new BusinessGatewayRepositories.EarlyCompletion.ResponseEarlyCompletionV2_0Type();
            _request.ID = new EarlyCompletion.Q1IdentifierType { MessageID = new EarlyCompletion.MessageIDTextType { Value = MessageID } };

            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));
            _response=_service.getResponse(_request);

            return _response;

         }


    }
}
