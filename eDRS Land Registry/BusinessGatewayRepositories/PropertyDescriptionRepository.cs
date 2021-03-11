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
    public class PropertyDescriptionRepository
    {
        public PropertyDescription.ResponseSearchByPropertyDescriptionV2_0Type GetPropertyDescription(
            string MessageID,
            string AllocatedBy,string Description,
            string CustomerReference,string ExternalReference,string BuildingName,
            string BuildingNumber,string StreetName, string CityName, string PostcodeZone,string UserName, string Password)
        {
            try
            {
                #region DeclareTheObjects
                PropertyDescription.Q1SubjectPropertyType _subject_property = new PropertyDescription.Q1SubjectPropertyType();
                PropertyDescription.Q1AddressType _address = new PropertyDescription.Q1AddressType();
                PropertyDescription.RequestSearchByPropertyDescriptionV2_0Type _request = new PropertyDescription.RequestSearchByPropertyDescriptionV2_0Type();
                PropertyDescription.PropertyDescriptionEnquiryV2_0ServiceClient _service_client = new PropertyDescription.PropertyDescriptionEnquiryV2_0ServiceClient();
                PropertyDescription.Q1ProductType _product = new PropertyDescription.Q1ProductType();
                PropertyDescription.Q1CustomerReferenceType _customer_reference = new PropertyDescription.Q1CustomerReferenceType();
                PropertyDescription.Q1ExternalReferenceType _external_reference = new PropertyDescription.Q1ExternalReferenceType();
                PropertyDescription.Q1PostcodeZoneType _postcode = new PropertyDescription.Q1PostcodeZoneType();

                #endregion

                #region AssignTheAddress
                if (!String.IsNullOrEmpty(BuildingName))
                    _address.BuildingName = BuildingName;

                if (!String.IsNullOrEmpty(BuildingNumber))
                    _address.BuildingNumber = BuildingNumber;

                if (!String.IsNullOrEmpty(StreetName))
                    _address.StreetName = StreetName;

                if (!String.IsNullOrEmpty(CityName))
                    _address.CityName = CityName;

                if (!String.IsNullOrEmpty(PostcodeZone))
                    _address.PostcodeZone = PostcodeZone.ToUpper();
                
                #endregion

                #region AssignCustomerReference
                _customer_reference.Reference = CustomerReference ;
                _customer_reference.AllocatedBy = new PropertyDescription.TextType { Value = AllocatedBy };
                _customer_reference.Description = new PropertyDescription.TextType { Value = Description };
                #endregion

                #region AssignExternalReference
                _external_reference.Reference = ExternalReference;
                _external_reference.AllocatedBy = new PropertyDescription.TextType { Value = AllocatedBy };
                _external_reference.Description = new PropertyDescription.TextType { Value = Description };
                #endregion

                #region AddObjectsTogether
                _product.SubjectProperty = _subject_property;
                _product.CustomerReference = _customer_reference;
                _product.ExternalReference = _external_reference;
                _subject_property.Address = _address;
                _product.SubjectProperty = _subject_property;
                _request.ID = new PropertyDescription.Q1IdentifierType { MessageID = new PropertyDescription.Q1TextType { Value = MessageID } };
                _request.Product = _product;
                
                #endregion
                _service_client.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(UserName, Password));

                string _string_request = this.SerializeRequest(_request);
                PropertyDescription.ResponseSearchByPropertyDescriptionV2_0Type _response  = _service_client.searchProperties(_request);

                string _string_response = this.SerializeResponse(_response);
                return _response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private string SerializeRequest(object Object)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(PropertyDescription.RequestSearchByPropertyDescriptionV2_0Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }
        private string SerializeResponse(object Object)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(PropertyDescription.ResponseSearchByPropertyDescriptionV2_0Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }


    }
    
}
