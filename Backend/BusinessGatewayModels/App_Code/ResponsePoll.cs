using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Configuration;
using BusinessGatewayRepositories;
using BusinessGatewayModels;

namespace BusinessGatewayModels
{
    public class ResponsePoll
    {
        public string Error { get; set; }
        public string UniqueReference { get; set; }
        public decimal ActualPrice { get; set; }
        public bool Successful { get; set; }
        public string MessageDetails { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string TitleNumber { get; set; }
        public string UserName { get; set; }
        public bool Attachment { get; set; }
        public ResponsePoll() { }
        public ResponsePoll(string MessageId, string TitleNumber, string UserName, BusinessGatewayRepositories.PollOS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type item)
        {
            this.UserName = UserName;
            this.TitleNumber = TitleNumber;

            Attachment = false;
            if (item.GatewayResponse != null)
            {
                if (item.GatewayResponse.Results != null)
                {
                    MessageDetails = item.GatewayResponse.Results.MessageDetails != null ? item.GatewayResponse.Results.MessageDetails.Description.Value : "";
                    if (item.GatewayResponse.Results.Attachment != null)
                    {
                        Attachment = true;
                        Successful = true;
                    }
                }
                else
                {
                    if (item.GatewayResponse.Acknowledgement != null)
                    {
                        Successful = true;
                        MessageDetails = item.GatewayResponse.Acknowledgement.AcknowledgementDetails.MessageDescription.Value;
                        ExpiryDate = GetExpiryDate(MessageDetails);

                    }
                    else
                    {
                        Successful = false;
                        Error = item.GatewayResponse.Rejection != null ? item.GatewayResponse.Rejection.RejectionResponse.Reason.Value : "";
                        ExpiryDate = GetExpiryDate(Error);
                        MessageDetails = Error;
                    }
                }
            }
            else
            {
                Successful = false;
                Error = item.GatewayResponse.Rejection != null ? item.GatewayResponse.Rejection.RejectionResponse.Reason.Value : "";
                MessageDetails = Error;
            }

        }
        private DateTime GetExpiryDate(string MessageDetails)
        {

            int _indexOfExpiry = MessageDetails.IndexOf("expires on");
            int _stringLength = MessageDetails.Length - (_indexOfExpiry + 11);
            string _expiry = MessageDetails.Substring(_indexOfExpiry + 10, _stringLength).TrimStart().TrimEnd();
            DateTime _Date;
            if (_indexOfExpiry > 0)
            {
                DateTime.TryParse(_expiry, out _Date);
                return _Date;
            }
            else
            {
                return new DateTime();
            }

        }

    }
}
