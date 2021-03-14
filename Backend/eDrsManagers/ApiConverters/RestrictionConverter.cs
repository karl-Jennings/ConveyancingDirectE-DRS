using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using BusinessGatewayModels;
using BusinessGatewayRepositories.EDRSApplication;
using BusinessGatewayServices;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsManagers.ViewModels;
using LrApiManager.SOAPManager;
using LrApiManager.XMLClases.Restriction;

namespace eDrsManagers.ApiConverters
{
    public interface IRestrictionConverter
    {
        RequestApplicationToChangeRegisterV1_0Type ArrangeLrApi(DocumentReference docRef);
    }
    public class RestrictionConverter : IRestrictionConverter
    {
        Services _services = new Services();
        Search[] _search_array = new Search[1];
        RequestApplicationToChangeRegisterV1_0Type _request = new RequestApplicationToChangeRegisterV1_0Type();
        ProductType _product = new ProductType();
        private readonly AppDbContext _context;


        public RestrictionConverter(AppDbContext context)
        {
            _context = context;
        }

        public RequestApplicationToChangeRegisterV1_0Type ArrangeLrApi(DocumentReference docRef)
        {

            _request.ExternalReference = docRef.ExternalReference;
            _request.MessageId = docRef.MessageID;

            _product.Reference = docRef.Reference;
            _product.TotalFeeInPence = docRef.TotalFeeInPence.ToString();
            _product.Email = docRef.Email;
            _product.TelephoneNumber = docRef.TelephoneNumber.ToString();
            _product.AP1WarningUnderstood = docRef.AP1WarningUnderstood;
            _product.ApplicationDate = docRef.ApplicationDate;
            _product.PostcodeOfProperty = docRef.PostcodeOfProperty;
            _product.DisclosableOveridingInterests = docRef.DisclosableOveridingInterests;



            #region TitleNumbers

            var titleList = new List<string>();

            docRef.Titles.ToList().ForEach(x =>
            {
                titleList.Add(x.TitleNumberCode);
            });

            var titlesType = new TitlesType()
            {
                TitleNumber = titleList.ToArray()
            };

            _product.Titles = titlesType;
            #endregion

            #region OtherApplication

            var applications = new List<ApplicationType>();

            docRef.Applications.ToList().ForEach(x =>
            {
                applications.Add(new OtherApplicationType()
                {
                    Document = new DocumentType { CertifiedCopy = (CertifiedTypeContent)Enum.Parse(typeof(CertifiedTypeContent), x.CertifiedCopy) },
                    Priority = x.Priority.ToString(),
                    Value = x.Value,
                    FeeInPence = x.FeeInPence.ToString()
                });
            });

            _product.Applications = applications.ToArray();

            #endregion

            #region Supporting Documents

            //supporting documnets
            SupportingDocumentsType supportingDocuments = new SupportingDocumentsType();
            var supportingDocumentTypes = new List<SupportingDocumentType>();

            docRef.SupportingDocuments.ToList().ForEach(x =>
            {
                supportingDocumentTypes.Add(new SupportingDocumentType()
                {
                    CertifiedCopy = (CertifiedTypeContent)Enum.Parse(typeof(CertifiedTypeContent), x.CertifiedCopy),
                    DocumentId = x.DocumentId,
                    DocumentName = (DocumentNameContent)Enum.Parse(typeof(DocumentNameContent), x.DocumentName),

                });
            });
            supportingDocuments.SupportingDocument = supportingDocumentTypes.ToArray();

            _product.SupportingDocuments = supportingDocuments;

            #endregion

            #region Representations

            //Representations

            RepresentationsType Representations = new RepresentationsType();

            Representations.LodgingConveyancer = new LodgingConveyancerType
            {
                RepresentativeId = docRef.Representations.ToList().Select(x => x.RepresentativeId).FirstOrDefault().ToString()
            };

            _product.Representations = Representations;

            #endregion

            #region Party

            //Parties
            PartiesType parties = new PartiesType();

            List<PartyType> partyTypes = new List<PartyType>();

            docRef.Parties.ToList().ForEach(x =>
            {
                var roles = x.Roles.Split(',');
                var partyType = new PartyType { IsApplicant = x.IsApplicant };

                List<PartyRoleType> partyRoleType = new List<PartyRoleType>();
                var count = 1;
                roles.ToList().ForEach(r =>
                {
                    partyRoleType.Add(new PartyRoleType
                    {
                        Priority = count++.ToString(),
                        RoleType = (RoleTypeContent)Enum.Parse(typeof(RoleTypeContent), r)
                    });
                });
                partyType.Roles = partyRoleType.ToArray();

                if (x.PartyType == "company")
                    partyType.Item = new CompanyType { CompanyName = x.CompanyOrForeName };
                else if (x.PartyType == "person")
                    partyType.Item = new PersonType { Forenames = x.CompanyOrForeName, Surname = x.Surname };


                partyTypes.Add(partyType);

            });
            parties.Party = partyTypes.ToArray();

            _product.Parties = parties;
            #endregion


            _request.Product = _product;
            var response = _services.eDRSApplicationRequest("tes12343", docRef.User?.Username, docRef.Password, _request);

            return _request;
        }

        //public RequestApplicationViewModel GetReqApp(DocumentReference docRef)
        //{
        //    var reqAppViewModel = new RequestApplicationViewModel();
        //    reqAppViewModel.Username = "BGUser001";
        //    reqAppViewModel.Password = "landreg001";

        //    BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
        //    BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

        //    BusinessGatewayRepositories.EDRSApplication.RequestApplicationToChangeRegisterV1_0Type _request = new BusinessGatewayRepositories.EDRSApplication.RequestApplicationToChangeRegisterV1_0Type();
        //    BusinessGatewayRepositories.EDRSApplication.ProductType _product = new BusinessGatewayRepositories.EDRSApplication.ProductType();

        //    _request.ExternalReference = "EXTERREF";
        //    _request.MessageId = "scenario1";
        //    _product.Reference = "Reference";
        //    _product.TotalFeeInPence = 50000.ToString();
        //    _product.Email = "test@dhd.com";
        //    _product.TelephoneNumber = "7979778787";
        //    _product.AP1WarningUnderstood = true;
        //    _product.ApplicationDate = DateTime.Now;
        //    _product.PostcodeOfProperty = "POSTCODE";
        //    _product.DisclosableOveridingInterests = true;


        //    #region TitleNumbers

        //    string[] _titlesArray = { "GR518195" };
        //    BusinessGatewayRepositories.EDRSApplication.TitlesType[] _titles = new BusinessGatewayRepositories.EDRSApplication.TitlesType[1];
        //    _titles[0] = new BusinessGatewayRepositories.EDRSApplication.TitlesType { TitleNumber = _titlesArray };

        //    //   BusinessGatewayRepositories.EDRSApplication.

        //    _product.Titles = _titles[0];
        //    #endregion

        //    BusinessGatewayRepositories.EDRSApplication.OtherApplicationType[] applications = new BusinessGatewayRepositories.EDRSApplication.OtherApplicationType[1];

        //    applications[0] = new BusinessGatewayRepositories.EDRSApplication.OtherApplicationType
        //    {

        //        Document = new BusinessGatewayRepositories.EDRSApplication.DocumentType { CertifiedCopy = CertifiedTypeContent.Certified },
        //        Priority = 1.ToString(),
        //        Value = 1000.ToString(),
        //        FeeInPence = 1000.ToString()

        //    };
        //    _product.Applications = applications;

        //    //supporting documnets
        //    BusinessGatewayRepositories.EDRSApplication.SupportingDocumentsType supportingDocuments = new SupportingDocumentsType();

        //    supportingDocuments.SupportingDocument = new SupportingDocumentType[1];
        //    supportingDocuments.SupportingDocument[0] = new SupportingDocumentType
        //    {
        //        CertifiedCopy = CertifiedTypeContent.Certified,
        //        DocumentId = "2",
        //        DocumentName = DocumentNameContent.Evidence
        //    };

        //    _product.SupportingDocuments = supportingDocuments;

        //    //Representations

        //    BusinessGatewayRepositories.EDRSApplication.RepresentationsType Representations = new RepresentationsType();

        //    Representations.LodgingConveyancer = new LodgingConveyancerType
        //    {
        //        RepresentativeId = "1",

        //    };

        //    _product.Representations = Representations;

        //    //Parties
        //    BusinessGatewayRepositories.EDRSApplication.PartiesType parties = new PartiesType();

        //    parties.Party = new PartyType[1];
        //    PartyRoleType[] partyRoleTypes = new PartyRoleType[1];
        //    partyRoleTypes[0] = new PartyRoleType { RoleType = RoleTypeContent.Lender, Priority = "1" };

        //    parties.Party[0] = new PartyType
        //    {
        //        representativeId = "1",
        //        IsApplicant = true,
        //        Item = new CompanyType { CompanyName = "company" },
        //        Roles = partyRoleTypes

        //    };

        //    _product.Parties = parties;

        //    _request.Product = _product;
        //    reqAppViewModel.Request = _request;
        //    return reqAppViewModel;
        //}



    }
}
