using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LrApiManager.SOAPManager;
using LrApiManager.SOAPManager.TransferOfPart;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.PollResponse;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LrApiManager.XMLClases.Requestapplicationtochangeregisterv2_1;


namespace eDRSUnitTest
{
    [TestClass]
    public class CustomTest
    {

        [TestMethod]
        public void ApplicationRequest()
        {
            TestManager testManager = new TestManager();


            string[] TitlesNumbers = { "TITLENO1", "TITLENO2", "TITLENO3" };

            //TITLES       

            Titles Titles = new Titles
            {
                Dealing = new Dealing
                {

                    DealingTitles = new Dealingtitles
                    {
                        TitleNumber = TitlesNumbers
                    }
                }
            };

            //Applications



            Requestapplicationtochangeregisterv2_1 requestapplicationtochangeregisterv2_1 = new Requestapplicationtochangeregisterv2_1
            {

                AdditionalProviderFilter = "Solsdotcom",
                MessageId = "scenario4",
                ExternalReference = "CP/Barclaycard/Murphy",

                Product = new Product
                {
                    Reference = "Reference",
                    TotalFeeInPence = 1000,
                    Email = "Email",
                    TelephoneNumber = "Email",
                    AP1WarningUnderstood = true,
                    ApplicationDate = "ApplicationDate",
                    DisclosableOveridingInterests = true,
                    PostcodeOfProperty = "PostcodeOfProperty",
                    LocalAuthority = "LocalAuthority",
                    Titles= Titles,
       //  Applications =
       //  SupportingDocuments =
       // Representations =
       // Parties =
       //Additionalpartynotifications =
       //Notes ="Notes"
       // ApplicationAffects = ApplicationAffects
                }

            };

             testManager.TestManagerApplication(requestapplicationtochangeregisterv2_1);
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
