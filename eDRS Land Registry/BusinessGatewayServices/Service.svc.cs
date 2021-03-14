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
using BusinessGatewayRepositories.AttachmentServiceRequest;

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
        public DayListResponse DayList(string MessageId,string AllocatedBy,string Description,string CustomerReference,string Reference,string TitleNumber,string Username, string Password)
        {
            DayListEntry _dayList = new DayListEntry();
            try
            {
                DayListResponse _response = new DayListResponse(TitleNumber,_dayList.GetDayListEntry(MessageId, AllocatedBy, Description, CustomerReference, Reference, TitleNumber, Username, Password));
                return _response;
            }
            catch (Exception ex)
            {
                return new DayListResponse { Error = ex.Message, Successful = false };
            }
        }
        public ResponseOS1 OS1(string MessageId, string AllocatedBy, string Description, string CustomerReference, string Reference, string TitleNumber, string TelephoneNumber, decimal ExpectedAmount, string PriorityCode, DateTime SearchDate,string Proprietor,string Applicant, string Username, string Password)
        {
            OS1Repository _os1 = new OS1Repository();
            try
            {
                ResponseOS1 _response = new ResponseOS1(MessageId,TitleNumber, Username, _os1.GetOS1(MessageId, Reference, Description, CustomerReference, TitleNumber, AllocatedBy, TelephoneNumber, ExpectedAmount, PriorityCode, Proprietor, Applicant, SearchDate, Username, Password));
                return _response;
            }
            catch (Exception ex)
            {
                return new ResponseOS1 { Error = ex.Message, Successful = false };
            }
        }
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
        public ResponseOutstanding Outstanding(string MessageId, int service,string Username, string Password)
        {
            OutstandingRespository _outstanding = new OutstandingRespository();
            try
            {
                ResponseOutstanding _response = new ResponseOutstanding(_outstanding.GetRequests(MessageId, service, Username,Password));
               
                _response.Successful = true;
                return _response;
            }
            catch (Exception ex)
            {
                return new ResponseOutstanding { Error = ex.Message, Successful = false };
            }
        }

        public ResponseEDRSAppRequest eDRSApplicationRequest( string Username, string Password, RequestApplicationToChangeRegisterV1_0Type _request)
        {
            EDRSRepository _erdsrepository = new EDRSRepository();
            ResponseEDRSAppRequest responseEDRSAppRequest = new ResponseEDRSAppRequest();
            try
            {          
                BusinessGatewayRepositories.EDRSApplication.ResponseApplicationToChangeRegisterV1_0Type _response= _erdsrepository.edrsAllpicationRequest(_request, Username, Password);

                responseEDRSAppRequest.Successful = true;
                responseEDRSAppRequest.GatewayResponse = _response;

                return responseEDRSAppRequest;
            }
            catch (Exception ex)
            {
                responseEDRSAppRequest.Successful = false;
                responseEDRSAppRequest.Error = ex;
                return responseEDRSAppRequest;
            }
        }


        public ResponseAttachmentRequest AttachmentRequest(string Username, string Password, AttachmentV2_0Type _request)
        {
            AttachmentRequestRepository _attachmentRequestRepository = new AttachmentRequestRepository();
            ResponseAttachmentRequest responseEDRSAppRequest = new ResponseAttachmentRequest();
            try
            {              

                AttachmentResponseV2_0Type _response = _attachmentRequestRepository.AttachmentRequest(_request, Username, Password);

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


        public ResponseAttachmentPollRequest AttachmentPollRequest(string Username, string Password,string MessageId, BusinessGatewayRepositories.AttachmentPollRequest.PollRequestType _request)
        {
            AttachmentRequestRepository _attachmentRequestRepository = new AttachmentRequestRepository();
            ResponseAttachmentPollRequest responseEDRSAppRequest = new ResponseAttachmentPollRequest();
            try
            {

                BusinessGatewayRepositories.AttachmentPollRequest.AttachmentResponseV2_0Type _response = _attachmentRequestRepository.AttachmentPollRequest(_request, MessageId, Username, Password);

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


        public ResponseCorrespondenceRequest CorrespondenceRequest(string Username, string Password, string MessageID)
        {
            CorrespondenceRepository _correspondenceRepository = new CorrespondenceRepository();
            ResponseCorrespondenceRequest responseEDRSAppRequest = new ResponseCorrespondenceRequest();
          
            try
            {
                BusinessGatewayRepositories.Correspondence.CorrespondenceV1_0Type _response = _correspondenceRepository.CorrespondenceRequest(MessageID, Username, Password);

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

        public EarlyCompletionResponse EarlyCompletionRequest(string Username, string Password, string MessageID)
        {
            EarlyCompletionRepository _earlyCompletionRepository = new EarlyCompletionRepository();
            EarlyCompletionResponse responseEDRSAppRequest = new EarlyCompletionResponse();

            try
            {
                BusinessGatewayRepositories.EarlyCompletion.ResponseEarlyCompletionV2_0Type _response = _earlyCompletionRepository.EarlyCompletionRequest(MessageID, Username, Password);

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


        public ResponsePollRequest PollRequest(string Username, string Password, string MessageID)
        {
            PollRequestRespository _pollRequestRespository = new PollRequestRespository();
            ResponsePollRequest responsePollRequest = new ResponsePollRequest();

            try
            {
                BusinessGatewayRepositories.PollService.ResponseApplicationToChangeRegisterV2_0Type _response = _pollRequestRespository.GetRequests(MessageID, Username, Password);

                responsePollRequest.Successful = true;
                responsePollRequest.GatewayResponse = _response;

                return responsePollRequest;
            }
            catch (Exception ex)
            {
                responsePollRequest.Successful = false;
                responsePollRequest.Error = ex.Message;
                return responsePollRequest;
            }
        }
    }

}
