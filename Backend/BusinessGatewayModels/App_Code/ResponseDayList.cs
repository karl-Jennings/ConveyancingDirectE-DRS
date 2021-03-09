using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Configuration;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace BusinessGatewayModels
{
    public class DayListResponse
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public List<Entry> Entries { get; set; }
        public string MessageDetails { get; set; }
        public DateTime PriorityDate { get; set; }
        public DayListResponse() { }
        public DayListResponse(string TitleNumber,BusinessGatewayRepositories.DayListEnquiry.ResponseDaylistEnquiryV2_0Type item)
        {
            try
            {
                if (item.GatewayResponse != null)
                {
                    if (item.GatewayResponse.Results != null)
                    {
                        MessageDetails = item.GatewayResponse.Results.MessageDetails != null ? item.GatewayResponse.Results.MessageDetails.Description.Value : "";
                        Entries = item.GatewayResponse.Results.DaylistEnquiry != null ? item.GatewayResponse.Results.DaylistEnquiry.Select(s => new Entry(s)).ToList() : null;
                        Successful = true;
                        WriteXML(TitleNumber, item);
                        this.WriteEntries(TitleNumber,Entries);
                    }
                    else
                    {
                        Successful = false;
                        Error = item.GatewayResponse.Rejection != null ? item.GatewayResponse.Rejection.RejectionResponse.Reason.Value : "";
                    }
                }
                else
                {
                    Successful = false;
                    Error = item.GatewayResponse.Rejection != null ? item.GatewayResponse.Rejection.RejectionResponse.Reason.Value : "";
                }
                
            }
            catch (Exception ex)
            {
                this.Successful = false;
                this.Error = ex.Message;
            }

        }
        private void WriteEntries(string Titlenumber, List<Entry> Entries)
        {
            //BusinessGatewayDB.BGEntities _Context = new BusinessGatewayDB.BGEntities();
            //foreach (var entry in Entries)
            //{

            //    var _entry = _Context.DayListResults.Where(t => t.TitleNumber == Titlenumber).FirstOrDefault();
            //    //if (_entry == null)
            //    //{
            //        BusinessGatewayDB.DayListResult _dayList = new BusinessGatewayDB.DayListResult
            //        {
            //            Applicant = entry.Applicant != null ? entry.Applicant : "",
            //            LodgedBy = entry.LodgedBy != null ? entry.LodgedBy : "",
            //            PriorityDate = entry.PriorityDate.ToShortDateString() != null ? entry.PriorityDate.ToShortDateString() : "",
            //            SearchInterestType = entry.SearchInterestType != null ? entry.SearchInterestType : "",
            //            Type = entry.Type != null ? entry.Type : "",
            //            TitleNumber = Titlenumber
            //        };
            //        _Context.DayListResults.Add(_dayList);
            //        _Context.SaveChanges();
            //    //}
            //}
            
        }
        public void WriteXML(string TitleNumber, BusinessGatewayRepositories.DayListEnquiry.ResponseDaylistEnquiryV2_0Type Response)
        {
            string _File = TitleNumber;
            string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + _File + ".xml";
           // string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + _File + ".xml";
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
    public class Entry
    {
        public string Applicant { get; set; }
        public string Type { get; set; }
        public DateTime PriorityDate { get; set; }
        public string LodgedBy { get; set; }
        public string SearchInterestType { get; set; }
        public Entry(BusinessGatewayRepositories.DayListEnquiry.Q1DaylistEnquiryType item)
        {

            Applicant = item.Applicant != null ? item.Applicant.Value : "";
            Type = item.ApplicationType != null ? ApplicationType(item.ApplicationType) : "";
            PriorityDate = item.PriorityDate.Value;
            LodgedBy = item.LodgedBy != null ? item.LodgedBy : "";
            SearchInterestType = item.SearchInterest != null ? SearchInterest(item.SearchInterest) : "";

        }
        private string ApplicationType(BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType item)
        {
            string _Type = "";
            switch (item)
            {
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item0:
                    _Type = "Search of Whole (With Priority)";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item10:
                    _Type = "Search of Part (With Priority)";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item20:
                    _Type = "Deposit";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item30:
                    _Type = "Dealing";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item40:
                    _Type = "Transfer of Part (Old Title)";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item50:
                    _Type = "Dispositionary First Lease (Old Title)";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item60:
                    _Type = "Transfer of Part";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item70:
                    _Type = "Dispositionary First Lease";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item80:
                    _Type = "First Registration";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item90:
                    _Type = "Outline Application";
                    break;
                case BusinessGatewayRepositories.DayListEnquiry.ApplicationTypeContentType.Item100:
                    _Type = "Application";
                    break;
            }
            return _Type;

        }
        private string SearchInterest(BusinessGatewayRepositories.DayListEnquiry.SearchInterestType item)
        {
             string _Type = "";
             switch (item)
             {
                 case BusinessGatewayRepositories.DayListEnquiry.SearchInterestType.C:
                     _Type = "In respect of an intended charge";
                     break;
                 case BusinessGatewayRepositories.DayListEnquiry.SearchInterestType.L:
                     _Type = "In respect of an intended lease";
                     break;
                 case BusinessGatewayRepositories.DayListEnquiry.SearchInterestType.P:
                     _Type = "In respect of an intended purchase";
                     break;
             }
             return _Type;
        }
        
    }
}
