using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayModels
{
    public class Search
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string ComplexName { get; set; }
    }
    public class SearchResults
    {
        public string CopyRightNotices { get; set; }
        public string ResponseType { get; set; }
        public byte[] Attachment { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string MimeCode { get; set; }
        public string HMLRReference { get; set; }
        public SearchResults(){}
        public SearchResults(string ResponseCode)
        {
            switch (ResponseCode)
            {
                case "Item10":
                    this.ResponseType = "Full electronic result";
                    break;
                case "Item20":
                    this.ResponseType = "Partial electronic result (some results by post)";
                    break;
                case "Item30":
                    this.ResponseType = "All results sent by post";
                    break;
                case "Item40":
                    this.ResponseType = "Cancellation";
                    break;
            }

        }
    }
}
