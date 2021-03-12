using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Threading.Tasks;
using eDrsManagers.ViewModels;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace eDrsManagers.Http
{
    public interface IHttpEdrsCall
    {
        string CallRegistrationApi(RequestApplicationViewModel viewModel);
    }
    public class HttpEdrsCall : IHttpEdrsCall
    {
        public HttpEdrsCall()
        {

        }

        public string CallRegistrationApi(RequestApplicationViewModel viewModel)
        {
            var client = new RestClient("https://localhost:44340/api/RequestApplication/ApplicationRequest");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(viewModel);
            IRestResponse response = client.Execute(request);

            return response.Content;

        }

    }
}
