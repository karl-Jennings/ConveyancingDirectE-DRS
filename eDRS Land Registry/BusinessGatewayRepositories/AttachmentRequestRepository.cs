using BusinessGatewayRepositories.AttachmentPollRequest;
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
        public AttachmentServiceRequest.AttachmentResponseV2_0Type AttachmentRequest(AttachmentV2_0Type _request,  string username,string password)
        {        
            AttachmentV2_0ServiceClient _service = new AttachmentV2_0ServiceClient();
            AttachmentServiceRequest.AttachmentResponseV2_0Type _response = new AttachmentServiceRequest.AttachmentResponseV2_0Type();
             
            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));
            _response=_service.newAttachment(_request);

            return _response;
        }



        public AttachmentPollRequest.AttachmentResponseV2_0Type AttachmentPollRequest(BusinessGatewayRepositories.AttachmentPollRequest.PollRequestType _request, string MessageId, string username, string password)
        {
            AttachmentV2_1PollRequestServiceClient _service = new AttachmentV2_1PollRequestServiceClient();
            AttachmentPollRequest.AttachmentResponseV2_0Type _response = new AttachmentPollRequest.AttachmentResponseV2_0Type();

            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(username, password));

            _request.ID=  new  AttachmentPollRequest.Q1IdentifierType { MessageID = new AttachmentPollRequest.MessageIDTextType { Value = MessageId } };

            _response = _service.getResponse(_request);

            return _response;
        }
    }
}
