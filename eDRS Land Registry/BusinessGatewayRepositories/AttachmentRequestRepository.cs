using BusinessGatewayRepositories.AttachmentServiceRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class AttachmentRequestRepository
    {
        public AttachmentRequestRepository() { }
        public AttachmentResponseV2_0Type AttachmentRequest(AttachmentV2_0Type _request,  string username,string password)
        {        
            AttachmentV2_0ServiceClient _service = new AttachmentV2_0ServiceClient();
            AttachmentResponseV2_0Type _response = new AttachmentResponseV2_0Type();
             
            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));
            _response=_service.newAttachment(_request);

            return _response;
        }

    }
}
