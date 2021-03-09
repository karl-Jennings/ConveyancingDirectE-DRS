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
    public class LandChargesBankruptcySearchRepository
    {

        public LandChargesBankruptcy.ResponseLandChargesBankruptcySearchV2_0Type GetLandChargesBankruptcySearch(
            string MessageID,
            string AllocatedBy, string Description,
            string CustomerReference, string ExternalReference,string Contact, string Phone, decimal ExpectedAmount, SearchDetails[] PrivateIndividual)
        {
            #region DeclareTheObjects
            LandChargesBankruptcy.RequestLandChargesBankruptcySearchV2_0Type _request = new LandChargesBankruptcy.RequestLandChargesBankruptcySearchV2_0Type();
            LandChargesBankruptcy.BankruptcySearchV2_0ServiceClient _service_client = new LandChargesBankruptcy.BankruptcySearchV2_0ServiceClient();
            LandChargesBankruptcy.Q1ProductType _product = new LandChargesBankruptcy.Q1ProductType();
            LandChargesBankruptcy.Q1CustomerReferenceType _customer_reference = new LandChargesBankruptcy.Q1CustomerReferenceType();
            LandChargesBankruptcy.Q1ExternalReferenceType _external_reference = new LandChargesBankruptcy.Q1ExternalReferenceType();
            LandChargesBankruptcy.Q1ExpectedPriceType _expected_price = new LandChargesBankruptcy.Q1ExpectedPriceType();
            LandChargesBankruptcy.Q1LandChargesBankruptcySearchType _search = new LandChargesBankruptcy.Q1LandChargesBankruptcySearchType();
            LandChargesBankruptcy.Q1ContactType _contact = new LandChargesBankruptcy.Q1ContactType();
            LandChargesBankruptcy.Q1CommunicationType _communication = new LandChargesBankruptcy.Q1CommunicationType();
            LandChargesBankruptcy.Q1BankruptcySearchPrivateIndividualPartyType _private_individual = new LandChargesBankruptcy.Q1BankruptcySearchPrivateIndividualPartyType();
            LandChargesBankruptcy.Q1BankruptcySearchPrivateIndividualType _private_individual_group = new LandChargesBankruptcy.Q1BankruptcySearchPrivateIndividualType();
            LandChargesBankruptcy.Q1BankruptcySearchComplexNamePartyType _complex = new LandChargesBankruptcy.Q1BankruptcySearchComplexNamePartyType();
            LandChargesBankruptcy.Q1BankruptcySearchComplexNameType _complex_group = new LandChargesBankruptcy.Q1BankruptcySearchComplexNameType();
           
            #endregion

            #region ContactDetails
            _communication.Telephone = new LandChargesBankruptcy.Q3TextType { Value = Phone };
            _contact.Communication = _communication;
            _contact.Name = new LandChargesBankruptcy.Q3TextType { Value = Contact };
            _product.Contact = _contact;
            #endregion

            #region ReferenceDetails
            _customer_reference.AllocatedBy = new LandChargesBankruptcy.Q3TextType { Value = Contact };
            _customer_reference.Description = new LandChargesBankruptcy.Q3TextType { Value = "Bankruptcy search" };
            _external_reference.AllocatedBy = new LandChargesBankruptcy.Q3TextType { Value = Contact };
            _external_reference.Description = new LandChargesBankruptcy.Q3TextType { Value = "Bankruptcy search" };
            _customer_reference.Reference = CustomerReference;
            _external_reference.Reference = ExternalReference;
            _product.CustomerReference = _customer_reference;
            _product.ExternalReference = _external_reference;
            _request.ID = new LandChargesBankruptcy.Q1IdentifierType { MessageID = new LandChargesBankruptcy.Q1TextType { Value = MessageID } };
            
            #endregion

            #region PriceDetails
            decimal _gross, _vat;
            //Do the amount calculations so we only need the net amount
            _vat = ExpectedAmount * (decimal)0.21;
            _gross = _vat + ExpectedAmount;
            _product.ExpectedPrice = new LandChargesBankruptcy.Q1ExpectedPriceType 
            { 
                NetPriceAmount = new LandChargesBankruptcy.AmountType 
                { 
                    Value = ExpectedAmount, 
                    currencyID = "GBP" 
                } ,
                GrossPriceAmount = new LandChargesBankruptcy.AmountType
                {
                    Value = _gross, 
                    currencyID = "GBP" 
                },
                VATAmount = new LandChargesBankruptcy.AmountType
                {
                    Value = _vat,
                    currencyID = "GBP"
                }
            };
            #endregion

            #region SearchDetails
            LandChargesBankruptcy.Q1BankruptcySearchPrivateIndividualPartyType[] _private_search = PrivateIndividual.Where(p => p.ComplexName == "").Count() == 0 ? null : new LandChargesBankruptcy.Q1BankruptcySearchPrivateIndividualPartyType[PrivateIndividual.Where(p => p.ComplexName == "").Count()];
            LandChargesBankruptcy.Q1BankruptcySearchComplexNamePartyType[] _complex_name = PrivateIndividual.Where(p => p.ComplexName != "").Count() == 0 ? null : new LandChargesBankruptcy.Q1BankruptcySearchComplexNamePartyType[PrivateIndividual.Where(p => p.ComplexName != "").Count()];
            int i = 0;

            foreach(var indi in PrivateIndividual.Where(p => p.ComplexName == ""))
            {
                _private_search[i] = new LandChargesBankruptcy.Q1BankruptcySearchPrivateIndividualPartyType
                {
                    ForenamesName = new LandChargesBankruptcy.Q1ForenamesTextType
                    {
                        Value = indi.FirstName
                    },
                    SurnameName = new LandChargesBankruptcy.Q1SurnameTextType
                    {
                        Value = indi.Surname
                    }
                };
                i++;
            }
            i = 0;
            foreach (var indi in PrivateIndividual.Where(p => p.ComplexName != ""))
            {
                _complex_name[i] = new LandChargesBankruptcy.Q1BankruptcySearchComplexNamePartyType
                {
                    ComplexName = new LandChargesBankruptcy.ComplexNameTextType
                    {
                        Value = indi.ComplexName
                    }
                };
                i++;
            }
            _search.ContinueIfActualFeeExceedsExpectedFeeIndicator = new LandChargesBankruptcy.IndicatorType { Value = true };
            #endregion
            try
            {
                _private_individual_group.BankruptcySearchParty = _private_search;
                _private_individual_group.BankruptcySearchTypeCode = "10";

                _complex_group.BankruptcySearchParty = _complex_name;
                _complex_group.BankruptcySearchTypeCode = "30";

                if (_private_search != null)
                    _search.Item = _private_individual_group;
                if (_complex_name != null)
                    _search.Item = _complex_group;
                
                _product.LandChargesBankruptcySearch = _search;
                _request.Product = _product;
                _service_client.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior("BGUser001", "landreg001"));

                string _string_request = this.SerializeRequest(_request);
                LandChargesBankruptcy.ResponseLandChargesBankruptcySearchV2_0Type _response = _service_client.bankruptcySearch(_request);
                
                string _string_response = this.SerializeResponse(_response);
                return _response;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        private string SerializeRequest(object Object)
        {
            try
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(LandChargesBankruptcy.RequestLandChargesBankruptcySearchV2_0Type));
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
            XmlSerializer xsSubmit = new XmlSerializer(typeof(LandChargesBankruptcy.ResponseLandChargesBankruptcySearchV2_0Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }


    }
    public class SearchDetails
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ComplexName { get; set; }
    }
}
