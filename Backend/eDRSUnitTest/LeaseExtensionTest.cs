﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LrApiManager.SOAPManager;
using LrApiManager.SOAPManager.Restriction;
using LrApiManager.SOAPManager.LeaseExtension;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.LeaseExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eDRSUnitTest
{
    [TestClass]
    public class LeaseExtensionTest
    {


        [TestMethod]
        public void ApplicationRequest()
        {
            LeaseExtensionRequestManager LeaseExtensionRequestManager = new LeaseExtensionRequestManager();

            TitleNumber[] TitleNumbers = { new TitleNumber { TitleString = "TitleNumbers1" }, new TitleNumber { TitleString = "TitleNumbers2" } };

            LesseeTitle[] LesseeTitles = { new LesseeTitle { TitleString = "LesseeTitle1" }, new LesseeTitle { TitleString = "LesseeTitle2" } };


            Leaseextension LeaseExtension = new Leaseextension
            {
                LessorTitles = TitleNumbers,
                LesseeTitle = LesseeTitles

            };

            List<Leaseextension> leaseextensions = new List<Leaseextension>();
            leaseextensions.Add(LeaseExtension);


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

            Representations representations = new Representations
            {

                LodgingConveyancer = lodgingconveyancer,
                Certified = new Certified
                {
                    RepresentativeId = 2
                }
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





            LeaseExtensionApplicationRequest restrictionApplicationRequest = new LeaseExtensionApplicationRequest
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
                    Titles = leaseextensions,
                    Applications = otherapplications,
                    SupportingDocuments = supportingdocuments,
                    Representations = representations,
                    Parties = parties,
                    ApplicationAffects = "WHOLE"
                }

            };

            ApplicationResponse applicationResponse = LeaseExtensionRequestManager.RequestLeaseExtensionApplication(restrictionApplicationRequest);
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
            LeaseExtensionPollRequest LeaseExtensionPollRequest = new LeaseExtensionPollRequest();

            LeaseExtensionPollResponse restrictionPoolResponse = LeaseExtensionPollRequest.PoolRequest("test msg id");
        }

    }
}