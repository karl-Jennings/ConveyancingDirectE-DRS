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
        OutstandingResponse CallOutstandingApi(OutstaningRequestViewModel viewModel);
        RequestLog CallAttachmentPollApi(AttachmentPollRequestViewModel viewModel);
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


        /// <summary>
        /// Call Outstaning Request service
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public OutstandingResponse CallOutstandingApi(OutstaningRequestViewModel viewModel)
        {
            var client = new RestClient("https://localhost:44340/api/Outstanding");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel) });
            IRestResponse response = client.Execute(request);
            OutstandingResponse apiResponse = JsonConvert.DeserializeObject<OutstandingResponse>(response.Content);

            return apiResponse;
        }


        public RequestLog CallAttachmentPollApi(AttachmentPollRequestViewModel viewModel)
        {

            var client = new RestClient("https://localhost:44340/api/AttachementPoll");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            Console.WriteLine(JsonConvert.SerializeObject(new { Value = JsonConvert.SerializeObject(viewModel) }));

            request.AddObject(new { Value = JsonConvert.SerializeObject(viewModel), viewModel.Password, Username = "BGUser001" });
            IRestResponse response = client.Execute(request);
            RequestLog apiResponse = JsonConvert.DeserializeObject<RequestLog>(response.Content);

            return apiResponse;

        }
    }

}
