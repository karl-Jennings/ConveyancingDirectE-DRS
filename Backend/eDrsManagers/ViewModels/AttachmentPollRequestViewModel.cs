using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrsManagers.ViewModels
{
    public class AttachmentPollRequestViewModel
    {
        public string MessageId { get; set; }        
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ResponseAttachmentPollRequest
    {
        public ResponseAttachmentPollRequest() { }
        public string Error { get; set; }
        public string UniqueReference { get; set; }
        public decimal ActualPrice { get; set; }
        public bool Successful { get; set; }
        public string MessageDetails { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string UserName { get; set; }
        public bool Attachment { get; set; }
        public BusinessGatewayRepositories.AttachmentPollRequest.AttachmentResponseV2_0Type GatewayResponse { get; set; }

    }
}
