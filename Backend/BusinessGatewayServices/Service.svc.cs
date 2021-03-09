using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BusinessGatewayRepositories;
using BusinessGatewayModels;
using BusinessGatewayRepositories.EDRSApplication;

namespace BusinessGatewayServices
{
    public class Services : IServices
    {
        public bool PropertyDescription(string MessageId, string AllocatedBy, string Description, string CustomerReference,string ExternalReference,
            string BuildingName, string BuildingNumber, string StreetName, string CityName, string Postcode,string Username, string Password)
        {
            BusinessGatewayRepositories.PropertyDescriptionRepository _property_description = new BusinessGatewayRepositories.PropertyDescriptionRepository();
            try
            {
                ResponsePropertyDescription _response = new ResponsePropertyDescription(_property_description.GetPropertyDescription(MessageId, AllocatedBy, Description, CustomerReference, ExternalReference, BuildingName, BuildingNumber, StreetName, CityName, Postcode, Username, Password));
                return _response.Successful;
            }   

            catch (Exception ex)
            {
                return false;
            }
        }
        public ResponseOwnerVerification OwnerVerification(string Reference,string MessageId, string FirstName, string MiddleName, string LastName, string TitleNumber, string HouseName, string HouseNumber, string Postcode, string UserName, string Password)
        {
            BusinessGatewayRepositories.OwnerConfirmation _ownerConfirmation = new OwnerConfirmation();
            try
            {
                ResponseOwnerVerification _response = new ResponseOwnerVerification(_ownerConfirmation.GetOwnerConfirmation(Reference,MessageId, FirstName, MiddleName, LastName, TitleNumber, HouseName, HouseNumber, Postcode, UserName, Password));
                return _response;
            }
            catch (Exception ex)
            {
                return new ResponseOwnerVerification { Successful = false, Error = ex.Message };
            }


        }
        public ResponsePropertyDescription PropertyDescriptionMessage(string MessageId, string AllocatedBy, string Description, string CustomerReference, string ExternalReference,
            string BuildingName, string BuildingNumber, string StreetName, string CityName, string Postcode,string Username, string Password)
        {
            PropertyDescriptionRepository _property_description = new PropertyDescriptionRepository();
            try
            {
                ResponsePropertyDescription _response = new ResponsePropertyDescription(_property_description.GetPropertyDescription(MessageId, AllocatedBy, Description, CustomerReference, ExternalReference, BuildingName, BuildingNumber, StreetName, CityName, Postcode, Username, Password));
                return _response;
            }

            catch (Exception ex)
            {
                return new ResponsePropertyDescription { FailedReason = ex.Message, Successful = false };
            }
        }
        public ResponseBankruptcySearch BankruptcySearch(string MessageId, string AllocatedBy, string Description, string CustomerReference, string ExternalReference,
            string Contact, string Phone, decimal ExpectedAmount, BusinessGatewayModels.Search[] SearchDetails)
        {
            LandChargesBankruptcySearchRepository _bankruptcy = new LandChargesBankruptcySearchRepository();
            try
            {
                SearchDetails[] _Search = new SearchDetails[SearchDetails.Length];
                for (int i = 0; i < _Search.Length; i++)
                {
                    _Search[i] = new SearchDetails { FirstName = SearchDetails[i].Forename, Surname = SearchDetails[i].Surname, ComplexName = SearchDetails[i].ComplexName };
                }
                ResponseBankruptcySearch _response = new ResponseBankruptcySearch(_bankruptcy.GetLandChargesBankruptcySearch(MessageId, AllocatedBy, Description, CustomerReference, ExternalReference, Contact, Phone, ExpectedAmount, _Search));
                return _response;
            }

            catch (Exception ex)
            {
               return new ResponseBankruptcySearch { FailedReason = ex.Message, Successful = false };
            }
        }
        public ResponseOC1 OCE(string MessageId, string ExternalRef, string PropertyDescription, string CustomerRef, string TitleNumber, string ContactName, string Telephone, decimal ExpectedAmount, bool Register, bool TitlePlan)
        {
            OC1Repository _OCE = new OC1Repository();
            try
            {
                ResponseOC1 _response = new ResponseOC1(_OCE.GetOC1(MessageId, ExternalRef, PropertyDescription, CustomerRef, TitleNumber, ContactName, Telephone, ExpectedAmount, Register, TitlePlan));
                return _response;
            }

            catch (Exception ex)
            {
                return new ResponseOC1 { Error = ex.Message, Successful = false };
            }
        }

        //public RESResponse RES(string MessageId,string AllocatedBy, string CustomerRef, string ExternalRef, string TitleNumber, decimal GrossPrice,
        //    bool ContinueIfExceeds,bool IncludePlan, bool NotifyIfPendingFirstRegistration, bool SendBackDated, bool NotifyIfPendingApplication,bool ContinueIfTitleClosed,string UserName,string Password)
        //{
        //    RegisterExtract _RES = new RegisterExtract();
        //    try
        //    {
        //        RESResponse _response = new RESResponse(TitleNumber,_RES.GetRegisterExtract(MessageId, AllocatedBy, CustomerRef, ExternalRef, TitleNumber, GrossPrice,
        //                ContinueIfExceeds, IncludePlan, NotifyIfPendingFirstRegistration, SendBackDated, NotifyIfPendingApplication, ContinueIfTitleClosed, UserName, Password), UserName);
        //        return _response;
        //    }

        //    catch (Exception ex)
        //    {
        //        throw;
        //    }

        //}
       
        //public ResponseOS1 OS1(string MessageId, string AllocatedBy, string Description, string CustomerReference, string Reference, string TitleNumber, string TelephoneNumber, decimal ExpectedAmount, string PriorityCode, DateTime SearchDate,string Proprietor,string Applicant, string Username, string Password)
        //{
        //    OS1Repository _os1 = new OS1Repository();
        //    try
        //    {
        //        ResponseOS1 _response = new ResponseOS1(MessageId,TitleNumber, Username, _os1.GetOS1(MessageId, Reference, Description, CustomerReference, TitleNumber, AllocatedBy, TelephoneNumber, ExpectedAmount, PriorityCode, Proprietor, Applicant, SearchDate, Username, Password));
        //        return _response;
        //    }
        //    catch (Exception ex)
        //    {
        //        return new ResponseOS1 { Error = ex.Message, Successful = false };
        //    }
        //}
        public ResponsePoll OS1Poll(string MessageId, string TitleNumber,string Username, string Password)
        {
            PollOS1Repository _os1 = new PollOS1Repository();
            try
            {
                ResponsePoll _response = new ResponsePoll(MessageId, TitleNumber, Username, _os1.GetOS1(MessageId, Username, Password));
                return _response;
            }
            catch (Exception ex)
            {
                return new ResponsePoll { Error = ex.Message, Successful = false };
            }
        }
        public ResponseOutstanding Outstanding(string MessageId, string Username, string Password)
        {
            OutstandingRespository _outstanding = new OutstandingRespository();
            try
            {
                ResponseOutstanding _response = new ResponseOutstanding(_outstanding.GetRequests(MessageId, Username,Password));
                return _response;
            }
            catch (Exception ex)
            {
                return new ResponseOutstanding { Error = ex.Message, Successful = false };
            }
        }

        public ResponseEDRSAppRequest eDRSApplicationRequest(string MessageId, string Username, string Password)
        {
            EDRSRepository _erdsrepository = new EDRSRepository();
            ResponseEDRSAppRequest responseEDRSAppRequest = new ResponseEDRSAppRequest();
            try
            {

                BusinessGatewayRepositories.EDRSApplication.RequestApplicationToChangeRegisterV1_0Type _request = new BusinessGatewayRepositories.EDRSApplication.RequestApplicationToChangeRegisterV1_0Type();
                BusinessGatewayRepositories.EDRSApplication.ProductType _product = new BusinessGatewayRepositories.EDRSApplication.ProductType();
               
                _request.ExternalReference = "EXTERREF";
                _request.MessageId = MessageId;
                _product.Reference = "Reference";
                _product.TotalFeeInPence = 50000.ToString();
                _product.Email = "test@dhd.com";
                _product.TelephoneNumber = "7979778787";
                _product.AP1WarningUnderstood = true;
                _product.ApplicationDate = DateTime.Now;
                _product.PostcodeOfProperty = "POSTCODE";
                _product.DisclosableOveridingInterests = true;


                #region TitleNumbers

                string[] _titlesArray = { "GR518195" };
                BusinessGatewayRepositories.EDRSApplication.TitlesType[] _titles = new BusinessGatewayRepositories.EDRSApplication.TitlesType[1];
                _titles[0] = new BusinessGatewayRepositories.EDRSApplication.TitlesType { TitleNumber = _titlesArray};

                _product.Titles = _titles[0];
                #endregion

                BusinessGatewayRepositories.EDRSApplication.OtherApplicationType[] applications = new BusinessGatewayRepositories.EDRSApplication.OtherApplicationType[1];

                applications[0] = new BusinessGatewayRepositories.EDRSApplication.OtherApplicationType
                {

                    Document = new BusinessGatewayRepositories.EDRSApplication.DocumentType { CertifiedCopy = CertifiedTypeContent.Certified },
                    Priority = 1.ToString(),
                    Value = 1000.ToString(),
                    FeeInPence = 1000.ToString()

                };
                _product.Applications = applications;

                //supporting documnets
                BusinessGatewayRepositories.EDRSApplication.SupportingDocumentsType supportingDocuments = new SupportingDocumentsType();

                supportingDocuments.SupportingDocument = new SupportingDocumentType[1];
                supportingDocuments.SupportingDocument[0] = new SupportingDocumentType
                {
                    CertifiedCopy = CertifiedTypeContent.Certified,
                    DocumentId = "2",
                    DocumentName = DocumentNameContent.Evidence
                };

                _product.SupportingDocuments = supportingDocuments;

                //Representations

                BusinessGatewayRepositories.EDRSApplication.RepresentationsType Representations = new RepresentationsType();

                Representations.LodgingConveyancer = new LodgingConveyancerType
                {
                    RepresentativeId = "1"
                };

                _product.Representations = Representations;

                //Parties
                BusinessGatewayRepositories.EDRSApplication.PartiesType parties = new PartiesType();

                parties.Party = new PartyType[1];
                PartyRoleType[] partyRoleTypes = new PartyRoleType[1];
                partyRoleTypes[0] = new PartyRoleType { RoleType = RoleTypeContent.Lender, Priority = "1" };

                parties.Party[0] = new PartyType
                {

                    representativeId = "1",
                    IsApplicant = true,
                    Item = new CompanyType { CompanyName = "company" },
                    Roles = partyRoleTypes


                };

                _product.Parties = parties;


                BusinessGatewayRepositories.EDRSApplication.AddressType _AddressType = new BusinessGatewayRepositories.EDRSApplication.AddressType();

                _request.Product = _product;

                //


                BusinessGatewayRepositories.EDRSApplication.ResponseApplicationToChangeRegisterV1_0Type _response= _erdsrepository.edrsAllpicationRequest(_request, Username, Password);

                responseEDRSAppRequest.Successful = true;
                responseEDRSAppRequest.GatewayResponse = _response;

                return responseEDRSAppRequest;
            }
            catch (Exception ex)
            {
                responseEDRSAppRequest.Successful = false;
                responseEDRSAppRequest.Error = ex.Message;
                return responseEDRSAppRequest;
            }
        }
    }

}
