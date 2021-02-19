using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LrApiManager.SOAPManager;
using LrApiManager.SOAPManager.Restriction;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.Restriction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eDRSUnitTest
{
    [TestClass]
    public class RestrictionTest
    {


        [TestMethod]
        public void ApplicationRequest()
        {
            RestrictionRequestManager restrictionServiceManager = new RestrictionRequestManager();


            //TITLES
            List<string> titles = new List<string>();
            titles.Add("GR518197");

            Dealingtitles dealingtitles = new Dealingtitles();
            dealingtitles.TitleNumber = titles;

            Dealing dealing = new Dealing
            {
                DealingTitles = dealingtitles
            };

            Titles titles1 = new Titles
            {
                Dealing = dealing
            };

            List<Titles> Titles = new List<Titles>();
            Titles.Add(titles1);


            //APPLICATIONS
            Otherapplication otherapplication = new Otherapplication
            {
                Priority = 1,
                Value = 0,
                FeeInPence = 500,
                Document = new Document
                {

                    CertifiedCopy = "Original"
                },
                Type = "RX1"

            };

            List<Otherapplication> otherapplications = new List<Otherapplication>();
            otherapplications.Add(otherapplication);

            Applications applications1 = new Applications
            {

                OtherApplication = otherapplications

            };

            List<Applications> applications = new List<Applications>();
            applications.Add(applications1);

            //SUPPORTING DOCUMENTS
            Supportingdocument Supportingdocument = new Supportingdocument
            {


                CertifiedCopy = "Original",
                DocumentId = 2,
                DocumentName = "Evidence"
            };

            List<Supportingdocument> supportingdocuments = new List<Supportingdocument>();
            supportingdocuments.Add(Supportingdocument);

            Supportingdocuments supportingdocuments1 = new Supportingdocuments
            {

                SupportingDocument = supportingdocuments

            };

            List<Supportingdocuments> Supportingdocuments = new List<Supportingdocuments>();
            Supportingdocuments.Add(supportingdocuments1);


            //LODGINGCONVENYANCER
            Lodgingconveyancer lodgingconveyancer = new Lodgingconveyancer
            {

                RepresentativeId = 1
            };

            List<Lodgingconveyancer> lodgingconveyancers = new List<Lodgingconveyancer>();
            lodgingconveyancers.Add(lodgingconveyancer);



            Representations representations = new Representations
            {

                LodgingConveyancer = lodgingconveyancers
            };

            List<Representations> representations1 = new List<Representations>();
            representations1.Add(representations);

            // PARTY
            Role role = new Role
            {
                RoleType = "ThirdParty",
                Priority = 1
            };

            List<Role> roles1 = new List<Role>();
            roles1.Add(role);

            Roles roles = new Roles
            {

                Role = roles1
            };

            //Parties
            Party party = new Party
            {

                IsApplicant = true,
                Company = new Company
                {
                    CompanyName = "Abbey National PLC"
                },
                Roles = roles
            };


            List<Party> parties = new List<Party>();
            parties.Add(party);

            Parties parties1 = new Parties
            {

                Party = parties
            };

            List<Parties> parties2 = new List<Parties>();
            parties2.Add(parties1);



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
                    Applications = applications,
                    SupportingDocuments = Supportingdocuments,
                    Representations = representations1,
                    Parties = parties2,
                    ApplicationAffects = "WHOLE"
                }

            };

            ApplicationResponse applicationResponse = restrictionServiceManager.RequestRestrictionApplication(restrictionApplicationRequest);
        }

        [TestMethod]
        public void AttachmentRequest()
        {

            AttachmentRequestManager restrictionServiceManager = new AttachmentRequestManager();

            var filearray = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };

            AttachmentRequest AttachmentRequest = new AttachmentRequest
            {
                AdditionalProviderFilter = "Solsdotcom",
                MessageId = "MessageId",
                ExternalReference = "CP/Parrett/Jenkins",
                ApplicationMessageId = "ApplicationMessageId",
                ApplicationService = "104",
                AttachmentId = 0,
                CertifiedCopy = "Original",
                Attachment = filearray

            };


            AttachmentResponse attachmentResponse = restrictionServiceManager.RequestAttachment(AttachmentRequest);

        }

        [TestMethod]
        public void PoolRequest()
        {
            RestrictionPollRequest restrictionPoolRequest = new RestrictionPollRequest();

            RestrictionPollResponse restrictionPoolResponse = restrictionPoolRequest.PoolRequest("test msg id");
        }

    }
}
