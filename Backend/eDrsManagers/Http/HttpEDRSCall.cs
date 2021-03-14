using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Threading.Tasks;
using BusinessGatewayModels;
using BusinessGatewayRepositories.EDRSApplication;
using eDrsDB.Models;
using eDrsManagers.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;

namespace eDrsManagers.Http
{
    public interface IHttpEdrsCall
    {
        RequestLog CallRegistrationApi(DocumentReferenceViewModel viewModel);
    }
    public class HttpEdrsCall : IHttpEdrsCall
    {
        public HttpEdrsCall()
        {

        }

        public RequestLog CallRegistrationApi(DocumentReferenceViewModel viewModel)
        {
          

            var client = new RestClient("https://localhost:44340/api/RequestApplication");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            Console.WriteLine(JsonConvert.SerializeObject(new { value = JsonConvert.SerializeObject(viewModel) }));

            JsonDeserializer deserial = new JsonDeserializer();

            request.AddObject(new { value = JsonConvert.SerializeObject(viewModel), viewModel.Password, Username = "BGUser001" });
            IRestResponse response = client.Execute(request);
            RequestLog apiResponse = deserial.Deserialize<RequestLog>(response);

            return apiResponse;

        }

        public RequestApplicationViewModel GetReqApp()
        {
            var reqAppViewModel = new RequestApplicationViewModel();
            reqAppViewModel.Username = "BGUser001";
            reqAppViewModel.Password = "landreg001";

            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

            BusinessGatewayRepositories.EDRSApplication.RequestApplicationToChangeRegisterV1_0Type _request = new BusinessGatewayRepositories.EDRSApplication.RequestApplicationToChangeRegisterV1_0Type();
            BusinessGatewayRepositories.EDRSApplication.ProductType _product = new BusinessGatewayRepositories.EDRSApplication.ProductType();

            _request.ExternalReference = "EXTERREF";
            _request.MessageId = "scenario1";
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
            _titles[0] = new BusinessGatewayRepositories.EDRSApplication.TitlesType { TitleNumber = _titlesArray };

            //   BusinessGatewayRepositories.EDRSApplication.

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
                RepresentativeId = "1",

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

            _request.Product = _product;
            reqAppViewModel.Request = _request;
            return reqAppViewModel;
        }


        /// <summary>
        /// Call Outstaning Request service
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public OutstaningResponseViewModel CallOutstandingApi(OutstaningRequestViewModel viewModel)
        {


            var client = new RestClient("https://localhost:44340/api/Outstanding");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            Console.WriteLine(JsonConvert.SerializeObject(new { value = JsonConvert.SerializeObject(viewModel) }));

            JsonDeserializer deserial = new JsonDeserializer();

            request.AddObject(new { value = JsonConvert.SerializeObject(viewModel), viewModel.Password, Username = "BGUser001" });
            IRestResponse response = client.Execute(request);
            OutstaningResponseViewModel apiResponse = deserial.Deserialize<OutstaningResponseViewModel>(response);

            return apiResponse;

        }


        /// <summary>
        /// Attachmnet Poll Request
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public ResponseAttachmentPollRequest CallAttachementPollApi(AttachmentPollRequestViewModel viewModel)
        {


            var client = new RestClient("https://localhost:44340/api/AttachementPoll");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            Console.WriteLine(JsonConvert.SerializeObject(new { value = JsonConvert.SerializeObject(viewModel) }));

            JsonDeserializer deserial = new JsonDeserializer();

            request.AddObject(new { value = JsonConvert.SerializeObject(viewModel), viewModel.Password, Username = "BGUser001" });
            IRestResponse response = client.Execute(request);
            ResponseAttachmentPollRequest apiResponse = deserial.Deserialize<ResponseAttachmentPollRequest>(response);

            return apiResponse;

        }

        /// <summary>
        /// Early Completion Request
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public EarlyCompletionResponse CallEarlyCompletionApi(EarlyCompletionRequest viewModel)
        {


            var client = new RestClient("https://localhost:44340/api/EarlyCompletion");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            Console.WriteLine(JsonConvert.SerializeObject(new { value = JsonConvert.SerializeObject(viewModel) }));

            JsonDeserializer deserial = new JsonDeserializer();

            request.AddObject(new { value = JsonConvert.SerializeObject(viewModel), viewModel.Password, Username = "BGUser001" });
            IRestResponse response = client.Execute(request);
            EarlyCompletionResponse apiResponse = deserial.Deserialize<EarlyCompletionResponse>(response);

            return apiResponse;

        }

        /// <summary>
        /// Application Poll Request
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public EarlyCompletionResponse CallApplicationPollRequestApi(EarlyCompletionRequest viewModel)
        {


            var client = new RestClient("https://localhost:44340/api/ApplicationPoll");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            Console.WriteLine(JsonConvert.SerializeObject(new { value = JsonConvert.SerializeObject(viewModel) }));

            JsonDeserializer deserial = new JsonDeserializer();

            request.AddObject(new { value = JsonConvert.SerializeObject(viewModel), viewModel.Password, Username = "BGUser001" });
            IRestResponse response = client.Execute(request);
            EarlyCompletionResponse apiResponse = deserial.Deserialize<EarlyCompletionResponse>(response);

            return apiResponse;

        }

    }

}
