using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class PollOS1Repository
    {
        public PollOS1Repository() { }
        public PollOS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type GetOS1(string MessageId, string Username, string Password)
        {
            PollOS1.PollRequestType _request = new PollOS1.PollRequestType();
            PollOS1.OfficialSearchV2_1PollServiceClient _service = new PollOS1.OfficialSearchV2_1PollServiceClient();
            _request.ID = new PollOS1.Q1IdentifierType { MessageID = new PollOS1.MessageIDTextType { Value = MessageId } };
             _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(Username, Password));
             PollOS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type _response = _service.getResponse(_request);
            return _response;
        }

    }
}
