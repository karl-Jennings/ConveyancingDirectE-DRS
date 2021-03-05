using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using eDrsDB.Models;
using LrApiManager.SOAPManager;
using LrApiManager.XMLClases.Restriction;
using Party = LrApiManager.XMLClases.Restriction.Party;
using TitleNumber = LrApiManager.XMLClases.Restriction.TitleNumber;

namespace eDrsManagers.ApiConverters
{
    public interface IRestrictionConverter
    {
        RestrictionApplicationRequest ArrangeLrApi(DocumentReference docRef);
    }
    public class RestrictionConverter : IRestrictionConverter
    {

        public RestrictionConverter()
        {

        }

        public RestrictionApplicationRequest ArrangeLrApi(DocumentReference docRef)
        {
            List<TitleNumber> titleNumbers = new List<TitleNumber>();
            docRef.Titles.ToList().ForEach(x =>
            {
                var titleNumber = new TitleNumber();
                titleNumber.TitleString = x.TitleNumberCode;
                titleNumbers.Add(titleNumber);

            });


            Dealingtitles Dealingtitles = new Dealingtitles
            {
                TitleNumber = titleNumbers.ToArray()
            };

            Dealing dealing = new Dealing
            {

                DealingTitles = Dealingtitles
            };

            List<Dealing> Titles = new List<Dealing>();
            Titles.Add(dealing);


            //APPLICATIONS
            List<Otherapplication> otherapplications = new List<Otherapplication>();

            docRef.Applications.ToList().ForEach(x =>
            {
                var otherapplication = new Otherapplication
                {
                    Priority = x.Priority,
                    Value = Convert.ToInt32(x.Value),
                    FeeInPence = x.FeeInPence,
                    Document = new LrApiManager.XMLClases.Restriction.Document { CertifiedCopy = x.CertifiedCopy },
                    Type = x.Type
                };
                otherapplications.Add(otherapplication);

            });

            //SUPPORTING DOCUMENTS
            List<Supportingdocument> supportingdocuments = new List<Supportingdocument>();

            docRef.SupportingDocuments.ToList().ForEach(x =>
            {
                var supportingdocument = new Supportingdocument()
                {
                    CertifiedCopy = x.CertifiedCopy,
                    DocumentId = Convert.ToInt32(x.DocumentId),
                    DocumentName = x.DocumentName
                };
                supportingdocuments.Add(supportingdocument);

            });


            //LODGINGCONVENYANCER
            Lodgingconveyancer lodgingconveyancer = new Lodgingconveyancer
            {

                RepresentativeId = 1
            };

            List<Lodgingconveyancer> lodgingconveyancers = new List<Lodgingconveyancer>();
            lodgingconveyancers.Add(lodgingconveyancer);

            Representations representations = new Representations
            {

                LodgingConveyancer = lodgingconveyancer,


            };

            // PARTY
            Role role = new Role
            {
                RoleType = "ThirdParty",
                Priority = 1
            };

            List<Role> roles1 = new List<Role>();
            roles1.Add(role);

            //Parties
            Party party = new Party
            {

                IsApplicant = true,
                Company = new Company
                {
                    CompanyName = "Abbey National PLC"
                },
                Roles = roles1
            };


            List<Party> parties = new List<Party>();
            parties.Add(party);

            RestrictionApplicationRequest restrictionApplicationRequest = new RestrictionApplicationRequest
            {

                AdditionalProviderFilter = "Solsdotcom",
                MessageId = "scenario4",
                ExternalReference = "CP/Barclaycard/Murphy",

                Product = new Product
                {
                    Reference = "CP/Barclaycard/Murphy",
                    TotalFeeInPence = 5000,
                    Email = "carolparker@cozyconveynacers.com",
                    TelephoneNumber = 1780299299,
                    AP1WarningUnderstood = true,
                    ApplicationDate = "2012-02-08",
                    DisclosableOveridingInterests = false,
                    Titles = Titles,
                    Applications = otherapplications,
                    SupportingDocuments = supportingdocuments,
                    Representations = representations,
                    Parties = parties,
                    ApplicationAffects = "WHOLE"
                }

            };
            return restrictionApplicationRequest;
        }
    }
}
