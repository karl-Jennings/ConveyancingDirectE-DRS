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
    }
}
