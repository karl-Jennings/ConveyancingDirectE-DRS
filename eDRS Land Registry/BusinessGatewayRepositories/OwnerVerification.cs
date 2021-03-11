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

    public class OwnerConfirmation
    {
        public OwnerConfirmation(){}
        public OwnerVerification.ResponseOnlineOwnershipVerificationType GetOwnerConfirmation(string Reference,string MessageId,string FirstName,string MiddleName,string LastName,string TitleNumber,string HouseName, string HouseNumber,string Postcode,string UserName,string Password)
        {
            try
            {
                OwnerVerification.RequestOnlineOwnershipVerificationType _request = new OwnerVerification.RequestOnlineOwnershipVerificationType();
                OwnerVerification.ResponseOnlineOwnershipVerificationType _response = new OwnerVerification.ResponseOnlineOwnershipVerificationType();
                OwnerVerification.SubjectPropertyType _subjectProperty = new OwnerVerification.SubjectPropertyType();
                OwnerVerification.OnlineOwnershipVerificationV1_0ServiceClient _service = new OwnerVerification.OnlineOwnershipVerificationV1_0ServiceClient();
                _request.MessageId = MessageId;
                _request.FirstForename = FirstName;
                _request.MiddleName = MiddleName;
                _request.Surname = LastName;
                _request.Reference = Reference;
                
                #region Indicators
                _request.Indicators = new OwnerVerification.IndicatorType[3];

                _request.Indicators[0] = new OwnerVerification.IndicatorType { IndicatorValue = true, IndicatorType1 = "ContinueIfOutOfHours" };
                _request.Indicators[1] = new OwnerVerification.IndicatorType { IndicatorValue = false, IndicatorType1 = "SkipPartialMatching" };
                _request.Indicators[2] = new OwnerVerification.IndicatorType { IndicatorValue = false, IndicatorType1 = "SkipHistoricalMatching" };
                
                #endregion

                OwnerVerification.PropertyAddressType1 _propertyAddress = new OwnerVerification.PropertyAddressType1();
                //either use the property title number or the address to pass to the subject property
                if (!string.IsNullOrEmpty(TitleNumber))
                {
                    _subjectProperty.Item = TitleNumber;
                }
                else
                {
                    if (!String.IsNullOrEmpty(HouseName))
                        _propertyAddress.BuildingName = HouseName;

                    if (!String.IsNullOrEmpty(HouseNumber))
                        _propertyAddress.BuildingNumber = HouseNumber;

                    if (!String.IsNullOrEmpty(Postcode))
                        _propertyAddress.PostcodeZone = Postcode;

                    _subjectProperty.Item = _propertyAddress;
                }

                _request.SubjectProperty = _subjectProperty;
                _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(UserName, Password));


                string _requestString = SerializeRequest(_request);
                _response = _service.verifyOwnership(_request);

                return _response;
            }
            catch (Exception ex)
            {
                return new OwnerVerification.ResponseOnlineOwnershipVerificationType { Result = null };
            }
        }
        private string SerializeRequest(object Object)
        {
            try
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(OwnerVerification.RequestOnlineOwnershipVerificationType));
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
            XmlSerializer xsSubmit = new XmlSerializer(typeof(OwnerVerification.ResponseOnlineOwnershipVerificationType));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }

    }
}
