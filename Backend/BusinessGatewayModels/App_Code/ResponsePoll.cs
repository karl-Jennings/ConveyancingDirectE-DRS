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
using BGConfigurations;

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
                        WriteAttachment(TitleNumber, item.GatewayResponse.Results.Attachment);
                        WriteXML(TitleNumber, item);
                    }
                }
                else
                {
                    if (item.GatewayResponse.Acknowledgement != null)
                    {
                        Successful = true;
                        WriteXML(TitleNumber, item);
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
            UpdateOS1(MessageId,this);
        }
        private void UpdateOS1(string Message,ResponsePoll OS1)
        {

            BusinessGatewayDB.BGEntities _Context = new BusinessGatewayDB.BGEntities();
            BusinessGatewayDB.OS1Request _OS1Request = new BusinessGatewayDB.OS1Request
            {
                TitleNumber = OS1.TitleNumber,
                MessageId = Message,
                ExpiryDate = ExpiryDate.ToShortDateString() == "01/01/0001" ? "" : ExpiryDate.ToShortDateString(),
                Message = MessageDetails,
                UserName = UserName,
                Error = OS1.Successful == true ? false : true,
                Attachment = OS1.Attachment
            };
            _Context.OS1Request.Add(_OS1Request);
            _Context.SaveChanges();
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
        private void WriteAttachment(string TitleNumber, BusinessGatewayRepositories.PollOS1.Q1AttachmentType Attachment)
        {
           // string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + TitleNumber + "." + Attachment.EmbeddedFileBinaryObject.format;
            string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + TitleNumber + "." + Attachment.EmbeddedFileBinaryObject.format;
            //We want to get the pdf from the value of the byte array and write it.
            BusinessGatewayRepositories.PollOS1.BinaryObjectType _binaryFile = Attachment.EmbeddedFileBinaryObject;

            byte[] buff;
            buff = _binaryFile.Value;
            try
            {
                FileStream fs = new FileStream(_FileLocation, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(buff);
                bw.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void WriteXML(string TitleNumber, BusinessGatewayRepositories.PollOS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type Response)
        {
            string _File = TitleNumber;
           // string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + _File + ".xml";
            string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + _File + ".xml";

            //If the file exists for some reason then we don't want to create it twice
            if (System.IO.File.Exists(_FileLocation) == false)
            {
                System.IO.FileStream f = System.IO.File.Create(_FileLocation);
                f.Close();
            }
            //We then want to serialise the response object and write it out to the xml file
            XmlSerializer serializer = new XmlSerializer(Response.GetType());
            TextWriter tw = new StreamWriter(_FileLocation);
            serializer.Serialize(tw, Response);
            tw.Close();
        }
    }
}
