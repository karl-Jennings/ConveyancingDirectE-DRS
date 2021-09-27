using BusinessGatewayRepositories.AttachmentPollRequest;
using BusinessGatewayRepositories.AttachmentServiceRequestV2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class AttachmentRequestRepositoryV2_1
    {
        public AttachmentRequestRepositoryV2_1() { }
        public AttachmentServiceRequestV2_1.AttachmentResponseV2_1Type AttachmentRequest(AttachmentV2_1Type _request,  string username,string password)
        {        
            AttachmentV2_1ServiceClient _service = new AttachmentV2_1ServiceClient();
            AttachmentServiceRequestV2_1.AttachmentResponseV2_1Type _response = new AttachmentServiceRequestV2_1.AttachmentResponseV2_1Type();
             
            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));
            _response=_service.newAttachment(_request);

            return _response;
        }
      
    }
}
