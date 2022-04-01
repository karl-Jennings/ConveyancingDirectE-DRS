using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayRepositories
{
    public class OutstandingRespositoryV2_1
    {
        public OutstandingRequestsV2_1.ResponseOutstandingRequestsType GetRequests(string MessageId,string Username, string Password,string additionalProviderFilter,int service=0)
        {
            OutstandingRequestsV2_1.RequestOutstandingRequestsType _request = new OutstandingRequestsV2_1.RequestOutstandingRequestsType();
            OutstandingRequestsV2_1.Q1OutstandingRequestsProductType _product = new OutstandingRequestsV2_1.Q1OutstandingRequestsProductType();
            OutstandingRequestsV2_1.OutstandingRequestsV2_1ServiceClient _service = new OutstandingRequestsV2_1.OutstandingRequestsV2_1ServiceClient();
            _product.ShowOnlyNewResponses = new OutstandingRequestsV2_1.IndicatorType{ Value = true};
            _request.ID = new OutstandingRequestsV2_1.Q1IdentifierType { MessageID = new OutstandingRequestsV2_1.Q1TextType { Value = MessageId } };

            if (service > 0)
            {
                _product.SpecificService = service;
                _product.SpecificServiceSpecified = true;
            }
            else {
                _product.SpecificServiceSpecified = false;
            }
          
            _product.AdditionalProviderFilter = additionalProviderFilter;

            _request.Product = _product;
            


            _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(Username, Password));

            OutstandingRequestsV2_1.ResponseOutstandingRequestsType _reponse = _service.getOutstandingRequests(_request);
            return _reponse;

        }
    }
}
