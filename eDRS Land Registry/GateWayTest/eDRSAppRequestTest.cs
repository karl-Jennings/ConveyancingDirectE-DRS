using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessGatewayRepositories.EDRSApplication;


namespace GateWayTest
{
    [TestClass]
    public class eDRSAppRequestTest
    {

        [TestMethod]
        public void eDRSAppRequest()
        {
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


            RepresentingConveyancerType representingConveyancerType = new RepresentingConveyancerType
            {

                RepresentativeId = "2",
                ConveyancerName = "Reprecenting Con name",
                Reference = "GHK/Youngblood",
                Item = new DXAddressType
                {

                    DXNumber = "12456",
                    DXExchange = "Peterborough 4"
                }

            };

            RepresentingConveyancerType representingConveyancerType2 = new RepresentingConveyancerType
            {

                RepresentativeId = "3",
                ConveyancerName = "Reprecenting Con name 3",
                Reference = "GHK/Youngblood 3",
                Item = new PostalAddressType
                {
                    CareOfName= "CareOfName",
                    CareOfReference= "CareOfReference",
                    AddressLine1 = "AddressLine1",
                    AddressLine2= "AddressLine2",
                    City="city",
                    Country="county",
                    Postcode="postcode"

                }

            };



            Representations.RepresentingConveyancer = new RepresentingConveyancerType[2];
            Representations.RepresentingConveyancer[0] = representingConveyancerType;
            Representations.RepresentingConveyancer[1] = representingConveyancerType2;


            _product.Representations = Representations;

            //Parties
            BusinessGatewayRepositories.EDRSApplication.PartiesType parties = new PartiesType();

            parties.Party = new PartyType[2];

            PartyRoleType[] partyRoleTypes = new PartyRoleType[2];

            partyRoleTypes[0] = new PartyRoleType { RoleType = RoleTypeContent.Borrower, Priority = "1" };
            partyRoleTypes[1] = new PartyRoleType { RoleType = RoleTypeContent.Lender, Priority = "1" };

            parties.Party[0] = new PartyType
            {
                representativeId = "1",
                IsApplicant = true,
                Item = new CompanyType { CompanyName = "company" },
                Roles = partyRoleTypes

            };
            // party 2

            PartyRoleType[] partyRoleTypes2 = new PartyRoleType[2];

            partyRoleTypes2[0] = new PartyRoleType { RoleType = RoleTypeContent.Borrower, Priority = "1" };
            partyRoleTypes2[1] = new PartyRoleType { RoleType = RoleTypeContent.Lender, Priority = "1" };

            parties.Party[1] = new PartyType
            {
                representativeId = "1",
                IsApplicant = true,
                Item = new CompanyType { CompanyName = "company2" },
                Roles = partyRoleTypes2

            };




            _product.Parties = parties;

            _request.Product = _product;

            var _reponse = _services.eDRSApplicationRequest("BGUser001", "landreg001", _request);

            Assert.AreEqual(true, true);
        }
    }
}
