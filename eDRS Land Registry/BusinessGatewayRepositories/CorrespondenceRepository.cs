using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessGatewayRepositories.Correspondence;

namespace BusinessGatewayRepositories
{
    public class CorrespondenceRepository
    {
        public CorrespondenceRepository() { }
        public BusinessGatewayRepositories.Correspondence.CorrespondenceV1_0Type CorrespondenceRequest(string MessageID,  string username,string password)
        {
            // EDRSApplication.RequestApplicationToChangeRegisterV1_0Type _request = new EDRSApplication.RequestApplicationToChangeRegisterV1_0Type();

            BusinessGatewayRepositories.Correspondence.PollRequestType _request = new BusinessGatewayRepositories.Correspondence.PollRequestType();
            Correspondence.CorrespondenceV2_1PollRequestServiceClient _service = new CorrespondenceV2_1PollRequestServiceClient();
            BusinessGatewayRepositories.Correspondence.CorrespondenceV1_0Type _response = new BusinessGatewayRepositories.Correspondence.CorrespondenceV1_0Type();
            _request.ID = new Correspondence.Q1IdentifierType { MessageID = new Correspondence.MessageIDTextType { Value = MessageID } };

            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));
            _response=_service.getResponse(_request);

            return _response;

         }


    }
}
