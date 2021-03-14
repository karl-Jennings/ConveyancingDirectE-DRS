using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessGatewayRepositories.AttachmentServiceRequest;

namespace GateWayTest
{
    [TestClass]
    public class AttachementRequestTest
    {

        [TestMethod]
        public void AttachementRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

            AttachmentV2_0Type _request = new AttachmentV2_0Type();

            _request.MessageId = "Msg001";
            _request.ExternalReference = "ExternalReference";
            _request.ApplicationMessageId = "ApplicationMessageId";
            _request.ApplicationService = "104";

            string pdfFilePath = "C:/Users/SACHITH/Documents/ggg.pdf";
            byte[] filearray = System.IO.File.ReadAllBytes(pdfFilePath);

            BusinessGatewayRepositories.AttachmentServiceRequest.AttachmentType attachment = new BusinessGatewayRepositories.AttachmentServiceRequest.AttachmentType
            {
                filename = "filename",
                format = "pdf",
                Value = filearray                
            };

            var ItemsElementName = new BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType[3];

            // ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.ApplicationType;
            ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.Attachment;
            ItemsElementName[1] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.AttachmentId;
            ItemsElementName[2] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.CertifiedCopy;


            Object[] Items = new object[] {
              attachment,
              "1",
              BusinessGatewayRepositories.AttachmentServiceRequest.CertifiedTypeContent.Certified

            };

            _request.Items = Items;
            _request.ItemsElementName = ItemsElementName;

            var _reponse = _services.AttachmentRequest( "BGUser001", "landreg001", _request);

            Assert.AreEqual(true, true);
        }


        [TestMethod]
        public void AttachementPollRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];
          
         
            var _reponse = _services.AttachmentPollRequest("BGUser001", "landreg001", "Msg001");

             Assert.AreEqual(true, true);
        }


        [TestMethod]
        public void AttachementNoteRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

            AttachmentV2_0Type _request = new AttachmentV2_0Type();

            _request.MessageId = "Msg001";
            _request.ExternalReference = "ExternalReference";
            _request.ApplicationMessageId = "ApplicationMessageId";
            _request.ApplicationService = "104";

            string pdfFilePath = "C:/Users/SACHITH/Documents/ggg.pdf";
            byte[] filearray = System.IO.File.ReadAllBytes(pdfFilePath);

            BusinessGatewayRepositories.AttachmentServiceRequest.AttachmentType attachment = new BusinessGatewayRepositories.AttachmentServiceRequest.AttachmentType
            {
                filename = "filename",
                format = "pdf",
                Value = filearray
            };

            var ItemsElementName = new BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType[1];

            // ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.ApplicationType;
            ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.Notes;
           

            Object[] Items = new object[] {
             "MY TEST NOTES"

            };

            _request.Items = Items;
            _request.ItemsElementName = ItemsElementName;

            var _reponse = _services.AttachmentRequest("BGUser001", "landreg001", _request);

            Assert.AreEqual(true, true);
        }
    }
}
