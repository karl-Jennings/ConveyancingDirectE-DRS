using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LrApiManager.SOAPManager;
using LrApiManager.SOAPManager.DispositionaryFirstLease;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.DispositionaryFirstLease;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eDRSUnitTest
{
    [TestClass]
    public class DispositionaryFirstLeaseTest
    {

        [TestMethod]
        public void ApplicationRequest()
        {
            DispositionaryFirstLeaseApplicationManager dispositionaryFirstLeaseApplicationManager = new DispositionaryFirstLeaseApplicationManager();

            TitleNumber[] TitleNumbers = { new TitleNumber { TitleString = "123334"}, new TitleNumber { TitleString = "56789" } };


            LessorTitles lessorTitles = new LessorTitles
            {
                TitleNumber = TitleNumbers
            };

            NewLease newLease = new NewLease
            {
                DealingTitles = lessorTitles
            };            

            List<NewLease> Titles = new List<NewLease>();
            Titles.Add(newLease);


            //APPLICATIONS
            OtherapplicationObject otherapplication = new OtherapplicationObject
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

            List<OtherapplicationObject> otherapplications = new List<OtherapplicationObject>();
            otherapplications.Add(otherapplication);

            ChargeapplicationObject chargeapplicationObject = new ChargeapplicationObject {

                Priority = 1,
                Value = 0,
                FeeInPence = 500,
                Document = new Document
                {

                    CertifiedCopy = "Original"
                },
                ChargeDate = "ChargeDate",
                MDRef= "MDRef"

            };

            List<ChargeapplicationObject> chargeapplications = new List<ChargeapplicationObject>();
            chargeapplications.Add(chargeapplicationObject);

            ApplicationsObject applications = new ApplicationsObject
            {
                OtherApplication= otherapplications,
                ChargeApplication= chargeapplications
            };
            
            
            

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
            LodgingconveyancerObject lodgingconveyancer = new LodgingconveyancerObject
            {
                RepresentativeId = 1
            };



            RepresentingConveyancerObject RepresentingConveyancer = new RepresentingConveyancerObject
            {

                RepresentativeId = 2,
                ConveyancerName = "Parretts Conveyancers",
                Reference = "GHK / Youngblood ",

                DXAddress = new DXAddress
                {
                    DXNumber = "12456",
                    DXExchange = "Peterborough 4"

                }


            };
           

            RepresentationsObject representations = new RepresentationsObject
            {                

                LodgingConveyancer = lodgingconveyancer
               

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




            DispositionaryFirstLeaseApplicationRequest dispositionaryFirstLeaseApplicationRequest = new DispositionaryFirstLeaseApplicationRequest
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

            ApplicationResponse applicationResponse = dispositionaryFirstLeaseApplicationManager.RequestChangeOfNameApplication(changeOfNameApplicationRequest);
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
