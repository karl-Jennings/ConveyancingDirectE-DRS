using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace BusinessGatewayRepositories
{
    public class DayListEntry
    {
        public DayListEntry() { }
        public DayListEnquiry.ResponseDaylistEnquiryV2_0Type GetDayListEntry(string MessageId,string AllocatedBy,string Description,string CustomerReference,string Reference,string TitleNumber,string UserName,string Password)
        {
            try
            {
                DayListEnquiry.RequestDaylistEnquiryV2_0Type _request = new DayListEnquiry.RequestDaylistEnquiryV2_0Type();
                DayListEnquiry.ResponseDaylistEnquiryV2_0Type _response = new DayListEnquiry.ResponseDaylistEnquiryV2_0Type();
                DayListEnquiry.Q1ProductType _product = new DayListEnquiry.Q1ProductType();
                DayListEnquiry.Q1SubjectPropertyType _property = new DayListEnquiry.Q1SubjectPropertyType{ TitleNumber = new DayListEnquiry.Q2TextType{ Value = TitleNumber} };
                DayListEnquiry.DaylistEnquiryV2_0ServiceClient _service = new DayListEnquiry.DaylistEnquiryV2_0ServiceClient();
                _product.ContinueIfTitleIsClosedAndContinuedIndicator = new DayListEnquiry.IndicatorType { Value = true };
                _product.SubjectProperty = _property;
                _product.ExternalReference = new DayListEnquiry.Q1ExternalReferenceType
                {  
                    AllocatedBy = new DayListEnquiry.Q3TextType{ Value = AllocatedBy},
                    Description = new DayListEnquiry.Q3TextType{ Value = Description}, 
                    Reference = Reference
                };
                _request.Product = _product;
                _request.ID = new DayListEnquiry.Q1IdentifierType { MessageID = new DayListEnquiry.Q1TextType { Value = MessageId } };
                _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(UserName, Password));
                _response = _service.daylistEnquiry(_request);

                return _response;
            }
            catch (Exception ex)
            {
                return new DayListEnquiry.ResponseDaylistEnquiryV2_0Type 
                { 
                    GatewayResponse = new DayListEnquiry.Q1GatewayResponseType 
                    { 
                        Results = null, Rejection = new DayListEnquiry.Q1RejectionType
                        { 
                            RejectionResponse =  new DayListEnquiry.Q1RejectionResponseType
                            { 
                                Reason = new DayListEnquiry.TextType
                                { 
                                    Value = ex.Message
                                }
                            }
                        }
                    } 
                };
            }
        }
        private string SerializeRequest(object Object)
        {
            try
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(DayListEnquiry.RequestDaylistEnquiryV2_0Type));
                StringWriter sww = new StringWriter();
                XmlWriter writer = XmlWriter.Create(sww);
                xsSubmit.Serialize(writer, Object);
                return sww.ToString(); //
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        private string SerializeResponse(object Object)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(DayListEnquiry.ResponseDaylistEnquiryV2_0Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }




    }
}
