﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessGatewayServices;
using BusinessGatewayRepositories.EDRSApplication;
using BusinessGatewayModels;
using eDRS_Land_Registry.ApiConverters;
using eDRS_Land_Registry.Models;
using eDrsDB.Models;
using Newtonsoft.Json;

namespace eDRS_Land_Registry.Controllers
{
    public class OutstaningRequest
    {
        public string MessageId { get; set; }
        public int Service { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AdditionalProviderFilter { get; set; }
    }

    public class OutstandingResponse
    {
        public string UniqueReference { get; set; }
        public string Reference { get; set; }
        public bool Successful { get; set; }
        public string FailedReason { get; set; }
        public string ResponseType { get; set; }
        public string Error { get; set; }
        public List<OutstandingRequests> Requests { get; set; }
    }

    public class TempClass
    {
        public string Value { get; set; }
    }

    public class OutstandingController : ApiController
    {

        public OutstandingResponse Post([FromBody] TempClass tempClass)
        {
            OutstandingResponse responseOutstanding = new OutstandingResponse();

            try
            {
                OutstaningRequest request = JsonConvert.DeserializeObject<OutstaningRequest>(tempClass.Value);

                BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();

                var response = _services.OutstandingV2_1(request.MessageId, request.Service, request.Username, request.Password,request.AdditionalProviderFilter);

                responseOutstanding.Requests = response.Requests;
                responseOutstanding.Successful = true;
                return responseOutstanding;

            }
            catch (Exception ex)
            {
                responseOutstanding.Successful = false;
                return responseOutstanding;
            }

        }
    }
}
