using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LrApiManager.SOAPManager.Remortgage;
using LrApiManager.XMLClases.Remortgage;
using LrApiManager.XMLClases.PollResponse;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using LrApiManager.XMLClases;
using LrApiManager.SOAPManager;

namespace eDRSUnitTest
{
    [TestClass]
    public class RemortgageTest
    {


        [TestMethod]
        public void ApplicationRequest()
        {
            RemortgageApplicationManager remortgageApplicationManager = new RemortgageApplicationManager();

            TitleNumber[] TitleNumbers = { new TitleNumber { TitleString = "123334"}, new TitleNumber { TitleString = "56789" } };


            Dealingtitles Dealingtitles = new Dealingtitles
            {
                TitleNumber = TitleNumbers
            };                  
                    
            Dealing dealing = new Dealing {

                DealingTitles = Dealingtitles
            };            

            List<Dealing> Titles = new List<Dealing>();
            Titles.Add(dealing);


            //APPLICATIONS           

            ChargeapplicationObject chargeapplicationObject = new ChargeapplicationObject
            {

                Priority = 1,
                Value = 0,
                FeeInPence = 500,
                Document = new Document
                {

                    CertifiedCopy = "Original"
                },
                ChargeDate = "ChargeDate",
                MDRef = "MDRef"

            };

            List<ChargeapplicationObject> chargeapplications = new List<ChargeapplicationObject>();
            chargeapplications.Add(chargeapplicationObject);

            ApplicationsObject applications = new ApplicationsObject
            {
               ChargeApplication = chargeapplications
            };


            //SUPPORTING DOCUMENTS
            Supportingdocument Supportingdocument = new Supportingdocument
            {
                CertifiedCopy = "Original",
                DocumentId = 1,
                DocumentName = "Evidence"
            };

            Supportingdocument Supportingdocument2 = new Supportingdocument
            {


                CertifiedCopy = "Original",
                DocumentId = 2,
                DocumentName = "Identity Form"
            };

            List<Supportingdocument> supportingdocuments = new List<Supportingdocument>();
            supportingdocuments.Add(Supportingdocument);
            supportingdocuments.Add(Supportingdocument2);


            //LODGINGCONVENYANCER
            LodgingconveyancerObject lodgingconveyancer = new LodgingconveyancerObject
            {

                RepresentativeId = 1
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
            Party party1 = new Party
            {

                IsApplicant = true,
                Person = new Person
                {
                    Forenames = "William",
                    Surname = "Prynne"
                },
                Roles = roles1,
                AddressForService = new Addressforservice {

                    AddressForServiceOption="B1"
                }
            };

            Party party2 = new Party
            {

                IsApplicant = false,
                Person = new Person
                {
                    Forenames = "Tracey",
                    Surname = "Prynne"
                },
                Roles = roles1,
                AddressForService = new Addressforservice
                {

                    AddressForServiceOption = "B1"
                }
            };

            Party party3 = new Party
            {

                IsApplicant = false,
                Company = new Company
                {
                    CompanyName = "Furness Building Society",
                    CompanyRegistrationNumber = "2294747"
                },
                Roles = roles1
               
            };


            List<Party> parties = new List<Party>();
            parties.Add(party1);
            parties.Add(party2);
            parties.Add(party3);

            //Representations       



            IdentityevidenceObject RepresentingConveyancer = new IdentityevidenceObject
            {
                RepresentativeId = 2,            
            };


            RepresentationsObject representations = new RepresentationsObject
            {

                LodgingConveyancer = lodgingconveyancer,
                IdentityEvidence = RepresentingConveyancer

            };

            RemortgageApplicationRequest remortgageApplicationRequest = new RemortgageApplicationRequest
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
                    SupportingDocuments = supportingdocuments,
                    Representations = representations,
                    Parties = parties,
                    ApplicationAffects = "WHOLE"
                }

            };

            ApplicationResponse applicationResponse = remortgageApplicationManager.RequestRemortgageApplication(remortgageApplicationRequest);
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
            PollRequestManager restrictionPoolRequest = new PollRequestManager();

            PollResponse restrictionPoolResponse = restrictionPoolRequest.PoolRequest("test msg id");
        }

    }
}
