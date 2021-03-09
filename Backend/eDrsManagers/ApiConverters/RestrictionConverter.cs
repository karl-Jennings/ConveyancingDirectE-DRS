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
            var representation = docRef.Representations.FirstOrDefault();

            List<Lodgingconveyancer> lodgingconveyancers = new List<Lodgingconveyancer>();


            Lodgingconveyancer lodgingconveyancer = new Lodgingconveyancer
            {
                RepresentativeId = Convert.ToInt32(representation.RepresentationId)
            };
            lodgingconveyancers.Add(lodgingconveyancer);


            Representations representations = new Representations
            {
                LodgingConveyancer = lodgingconveyancer,

            };


            // PARTY

            List<Party> parties = new List<Party>();


            var tempParty = docRef.Parties.ToList();
            tempParty.ForEach(x =>
            {
                List<Role> roles = new List<Role>();

                foreach (var item in x.Roles.Split(','))
                {
                    Role role = new Role
                    {
                        RoleType = item,
                        Priority = 1
                    };
                    roles.Add(role);
                }

                //Parties
                Party party = new Party
                {

                    IsApplicant = x.IsApplicant,
                    Company = new Company
                    {
                        CompanyName = x.CompanyOrForeName
                    },
                    Roles = roles
                };
                parties.Add(party);

            });


            RestrictionApplicationRequest restrictionApplicationRequest = new RestrictionApplicationRequest
            {

                AdditionalProviderFilter = docRef.AdditionalProviderFilter,
                MessageId = docRef.MessageID,
                ExternalReference = docRef.ExternalReference,

                Product = new Product
                {
                    Reference = docRef.Reference,
                    TotalFeeInPence = docRef.TotalFeeInPence,
                    Email = docRef.Email,
                    TelephoneNumber = Convert.ToInt32(docRef.TelephoneNumber),
                    AP1WarningUnderstood = docRef.AP1WarningUnderstood,
                    ApplicationDate = docRef.ApplicationDate,
                    DisclosableOveridingInterests = docRef.DisclosableOveridingInterests,
                    Titles = Titles,
                    Applications = otherapplications,
                    SupportingDocuments = supportingdocuments,
                    Representations = representations,
                    Parties = parties,
                    ApplicationAffects = docRef.ApplicationAffects
                }

            };
            return restrictionApplicationRequest;
        }
    }
}
