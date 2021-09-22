using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BusinessGatewayModels;
using BusinessGatewayRepositories.EDRSApplication;
using eDRS_Land_Registry.Models;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsManagers.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;

namespace eDrsManagers.Http
{
    public interface IHttpEdrsCall
    {
        RequestLog CallRegistrationApi(DocumentReferenceViewModel viewModel);
        OutstandingResponse CallOutstandingApi(OutstaningRequestViewModel viewModel);
        RequestLog CallAttachmentPollApi(AttachmentPollRequestViewModel viewModel);
        RequestLog CallApplicationPollRequestApi(ApplicationPollRequest viewModel);
        RequestLog CallEarlyCompletionApi(EarlyCompletionRequest viewModel);
        RequestLog CallCorrespondenceRequestApi(CorrospondanceRequestViewModel viewModel);
        List<RequestLog> CallAttachmentRequestApi(AttachmentViewModel viewModel);
    }
    public class HttpEdrsCall : IHttpEdrsCall
    {
        private LrCredential lrCredentials;
        private readonly AppDbContext _context;
        private string baseUrl = "https://localhost:44340/api/";
        public HttpEdrsCall(AppDbContext context)
        {
            _context = context;
            lrCredentials = _context.LrCredentials.FirstOrDefault();

        }

        public RequestLog CallRegistrationApi(DocumentReferenceViewModel viewModel)
        {

            try{
                var client = new RestClient(baseUrl + "RequestApplication");

                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.RequestFormat = DataFormat.Json;


                //var contents = JsonConvert.SerializeObject(viewModel);

                //byte[] byteArray = Encoding.UTF8.GetBytes(contents);           
                

                //Stream streamcontent = new MemoryStream(byteArray);

                //MemoryStream stream = new MemoryStream(byteArray);

                //IFormFile file = new FormFile(stream, 0, byteArray.Length, "edrs", "edrs");

                request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel), lrCredentials.Password, lrCredentials.Username });
               // request.AddObject(new { Value = file, lrCredentials.Password, lrCredentials.Username });

                IRestResponse response = client.Execute(request);
                RequestLog apiResponse = JsonConvert.DeserializeObject<RequestLog>(response.Content);

                return apiResponse;

            }
            catch (Exception ex) { throw ex; }
            
        }


        /// <summary>
        /// Call Outstaning Request service
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public OutstandingResponse CallOutstandingApi(OutstaningRequestViewModel viewModel)
        {
            var client = new RestClient(baseUrl + "Outstanding");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;
            viewModel.Username = lrCredentials.Username;
            viewModel.Password = lrCredentials.Password;

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel) });
            IRestResponse response = client.Execute(request);
            OutstandingResponse apiResponse = JsonConvert.DeserializeObject<OutstandingResponse>(response.Content);

            return apiResponse;
        }


        public RequestLog CallAttachmentPollApi(AttachmentPollRequestViewModel viewModel)
        {

            var client = new RestClient(baseUrl + "AttachementPoll");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            viewModel.Username = lrCredentials.Username;
            viewModel.Password = lrCredentials.Password;

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel) });
            IRestResponse response = client.Execute(request);
            RequestLog apiResponse = JsonConvert.DeserializeObject<RequestLog>(response.Content);

            return apiResponse;

        }

        /// <summary>
        /// Application Poll Request
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public RequestLog CallApplicationPollRequestApi(ApplicationPollRequest viewModel)
        {

            var client = new RestClient(baseUrl + "ApplicationPoll");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            viewModel.Username = lrCredentials.Username;
            viewModel.Password = lrCredentials.Password;

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel) });
            IRestResponse response = client.Execute(request);
            RequestLog apiResponse = JsonConvert.DeserializeObject<RequestLog>(response.Content);

            return apiResponse;

        }

        /// <summary>
        /// Early Completion  Request
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public RequestLog CallEarlyCompletionApi(EarlyCompletionRequest viewModel)
        {
            var client = new RestClient(baseUrl + "EarlyCompletion");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            viewModel.Username = lrCredentials.Username;
            viewModel.Password = lrCredentials.Password;

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel) });
            IRestResponse response = client.Execute(request);
            RequestLog apiResponse = JsonConvert.DeserializeObject<RequestLog>(response.Content);

            return apiResponse;

        }


        public RequestLog CallCorrespondenceRequestApi(CorrospondanceRequestViewModel viewModel)
        {
            var client = new RestClient(baseUrl + "corrospondance");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            viewModel.Username = lrCredentials.Username;
            viewModel.Password = lrCredentials.Password;

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel) });
            IRestResponse response = client.Execute(request);
            RequestLog apiResponse = JsonConvert.DeserializeObject<RequestLog>(response.Content);

            return apiResponse;
        }

        public List<RequestLog> CallAttachmentRequestApi(AttachmentViewModel viewModel)
        {
            var client = new RestClient(baseUrl + "AttachmentRequest");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            viewModel.Username = lrCredentials.Username;
            viewModel.Password = lrCredentials.Password;

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel) });
            IRestResponse response = client.Execute(request);
            List<RequestLog> apiResponse = JsonConvert.DeserializeObject<List<RequestLog>>(response.Content);

            return apiResponse;
        }

    }

}
