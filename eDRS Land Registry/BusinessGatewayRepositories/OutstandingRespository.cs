using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class OutstandingRespository
    {
        public OutstandingRequests.ResponseOutstandingRequestsType GetRequests(string MessageId,int service,string Username, string Password)
        {
            OutstandingRequests.RequestOutstandingRequestsType _request = new OutstandingRequests.RequestOutstandingRequestsType();
            OutstandingRequests.Q1OutstandingRequestsProductType _product = new OutstandingRequests.Q1OutstandingRequestsProductType();
            OutstandingRequests.OutstandingRequestsV2_0ServiceClient _service = new OutstandingRequests.OutstandingRequestsV2_0ServiceClient();
            _product.ShowOnlyNewResponses = new OutstandingRequests.IndicatorType{ Value = true};
            _request.ID = new OutstandingRequests.Q1IdentifierType { MessageID = new OutstandingRequests.Q1TextType { Value = MessageId } };
          
            _product.SpecificService = service;
            _product.SpecificServiceSpecified = true;

            _request.Product = _product;
           
            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(Username, Password));

            OutstandingRequests.ResponseOutstandingRequestsType _reponse = _service.getOutstandingRequests(_request);
            return _reponse;

        }
    }
}
