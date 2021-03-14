using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


using System.Text;
using System.Net.Http.Headers;
using LrApiManager.Common;
using BusinessGatewayRepositories.EDRSApplication;

namespace eDRSUnitTest
{
    [TestClass]
    public class BusinessGatewayTest
    {
        [TestMethod]
        public static async Task ApplicationRequestTestMethod()
        {
            // In the class
            HttpClient client = new HttpClient();



            // Put the following code where you want to initialize the class
            // It can be the static constructor or a one-time initializer
            client.BaseAddress = new Uri("http://localhost:44340/api/RequestApplication");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            RequestApplicationViewModel requestApplicationViewModel = new RequestApplicationViewModel();


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

            requestApplicationViewModel.Request = _request;
            requestApplicationViewModel.Username = "BGUser001";
            requestApplicationViewModel.Password = "landreg001";


            var response = await client.PostAsJsonAsync("Request", requestApplicationViewModel);
        }
    }
}
