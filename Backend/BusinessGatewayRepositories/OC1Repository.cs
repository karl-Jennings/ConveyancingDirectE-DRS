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
    public class OC1Repository
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public OC1Repository() { }
        public OC1.ResponseTitleKnownOfficialCopyV2_0Type GetOC1(string MessageId, string ExternalRef, string PropertyDescription, string CustomerRef, string TitleNumber, string ContactName, string Telephone, decimal ExpectedAmount, bool Register, bool TitlePlan)
        {
            try
            {
                //Declare the variables
                OC1.Q1ProductType _product = new OC1.Q1ProductType();
                OC1.RequestTitleKnownOfficialCopyV2_1Type _request = new OC1.RequestTitleKnownOfficialCopyV2_1Type();
                OC1.Q1SubjectPropertyType _subjectProperty = new OC1.Q1SubjectPropertyType();
                OC1.Q1TitleKnownOfficialCopyType _titleKnown = new OC1.Q1TitleKnownOfficialCopyType();
                OC1.OC1TitleKnownV2_1ServiceClient _service = new OC1.OC1TitleKnownV2_1ServiceClient();
                _request.ID = new OC1.Q1IdentifierType { MessageID = new OC1.Q1TextType { Value = MessageId } };
                
                //Add the product details all together
                OC1.Q1ContactType[] _Contact = new OC1.Q1ContactType[1];
                _Contact[0] = new OC1.Q1ContactType { Name = new OC1.Q3TextType { Value = ContactName }, Communication = new OC1.Q1CommunicationType { Telephone = new OC1.Q3TextType { Value = Telephone } } };
                _product.Contact = _Contact;
                OC1.AmountType _amount = new OC1.AmountType { Value = ExpectedAmount };
                _product.ExpectedPrice = new OC1.Q1ExpectedPriceType { GrossPriceAmount = _amount, NetPriceAmount = _amount, VATAmount = new OC1.AmountType { Value = 0 } };
                //Add the external reference details
                _product.ExternalReference = new OC1.Q1ExternalReferenceType
                {
                    AllocatedBy = new OC1.Q3TextType { Value = ContactName },
                    Description = new OC1.Q3TextType { Value = "OC Request" },
                    Reference = ExternalRef
                };
                //Add the customer refernence details
                _product.CustomerReference = new OC1.Q1CustomerReferenceType
                {
                    AllocatedBy = new OC1.Q3TextType { Value = ContactName },
                    Description = new OC1.Q3TextType { Value = "OC Request" },
                    Reference = CustomerRef
                };
                //Add the subject property to the property
                _subjectProperty.TitleNumber = new OC1.Q2TextType { Value = TitleNumber };
                _product.SubjectProperty = _subjectProperty;
                //Add the title known details to the request
                _titleKnown.PropertyDescription = PropertyDescription;
                _titleKnown.OfficialCopyTypeCode = new OC1.OfficialCopyCodeType { Value = OC1.OfficialCopyCodeContentType.Item10 };
                if (Register == true && TitlePlan == false)
                {
                    _titleKnown.RequestedOfficialCopyCode = new OC1.RequestedOfficialCopyCodeType { Value = OC1.RequestedOfficialCopyCodeContentType.Item10 };
                }
                if (Register == true && TitlePlan == true)
                {
                    _titleKnown.RequestedOfficialCopyCode = new OC1.RequestedOfficialCopyCodeType { Value = OC1.RequestedOfficialCopyCodeContentType.Item30 };
                }
                _titleKnown.ContinueIfActualFeeExceedsExpectedFeeIndicator = new OC1.IndicatorType { Value = false };
                _titleKnown.NotifyIfPendingFirstRegistrationIndicator = new OC1.IndicatorType { Value = false };
                _titleKnown.NotifyIfPendingApplicationIndicator = new OC1.IndicatorType { Value = false };
                _titleKnown.SendBackDatedIndicator = new OC1.IndicatorType { Value = false };
                _titleKnown.ContinueIfActualFeeExceedsExpectedFeeIndicator = new OC1.IndicatorType { Value = false };
                _titleKnown.ContinueIfTitleIsClosedAndContinuedIndicator = new OC1.IndicatorType { Value = false };
                _product.TitleKnownOfficialCopy = _titleKnown;
                _request.Product = _product;
                _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior("BGUser001", "landreg001"));
                string _requestXml = SerializeRequest(_request);
                OC1.ResponseTitleKnownOfficialCopyV2_0Type _response = _service.performTitleKnownSearch(_request);
                //string _responseXml = SerializeResponse(_response);
                return _response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private string SerializeRequest(object Object)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(OC1.RequestTitleKnownOfficialCopyV2_1Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }
        private string SerializeResponse(object Object)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(OC1.ResponseTitleKnownOfficialCopyV2_0Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }
    }
    
}
