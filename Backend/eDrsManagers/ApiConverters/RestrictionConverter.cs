﻿using System;
using System.Collections.Generic;
using System.Text;
using LrApiManager.SOAPManager;
using LrApiManager.SOAPManager.Restriction;
using LrApiManager.XMLClases.Restriction;

namespace eDrsManagers.ApiConverters
{
    public interface IRestrictionConverter
    {
        RestrictionApplicationRequest ArrangeLrApi();
    }
    public class RestrictionConverter : IRestrictionConverter
    {



        public RestrictionConverter()
        {

        }

        public RestrictionApplicationRequest ArrangeLrApi()
        {
            RestrictionRequestManager restrictionServiceManager = new RestrictionRequestManager();


            TitleNumber[] TitleNumbers = { new TitleNumber { TitleString = "123334" }, new TitleNumber { TitleString = "56789" } };


            Dealingtitles Dealingtitles = new Dealingtitles
            {
                TitleNumber = TitleNumbers
            };

            Dealing dealing = new Dealing
            {

                DealingTitles = Dealingtitles
            };

            List<Dealing> Titles = new List<Dealing>();
            Titles.Add(dealing);


            //APPLICATIONS
            Otherapplication otherapplication = new Otherapplication
            {
                Priority = 1,
                Value = 0,
                FeeInPence = 500,
                Document = new LrApiManager.XMLClases.Restriction.Document
                {

                    CertifiedCopy = "Original"
                },
                Type = "RX1"

            };

            List<Otherapplication> otherapplications = new List<Otherapplication>();
            otherapplications.Add(otherapplication);



            //SUPPORTING DOCUMENTS
            Supportingdocument Supportingdocument = new Supportingdocument
            {


                CertifiedCopy = "Original",
                DocumentId = 2,
                DocumentName = "Evidence"
            };

            List<Supportingdocument> supportingdocuments = new List<Supportingdocument>();
            supportingdocuments.Add(Supportingdocument);


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
