using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayModels
{
    [Serializable]
    public class ResponseBankruptcySearch
    {
        public string UniqueReference { get; set; }
        public string Reference { get; set; }
        public SearchResults SearchResults { get; set; }
        public bool Successful { get; set; }
        public string FailedReason { get; set; }
        public string ResponseType { get; set; }
        public decimal ActualPrice { get; set; }
        public ResponseBankruptcySearch() { }
        public ResponseBankruptcySearch(BusinessGatewayRepositories.LandChargesBankruptcy.ResponseLandChargesBankruptcySearchV2_0Type item)
        {

            if (item.GatewayResponse != null)
                {
                    switch (item.GatewayResponse.TypeCode.Value.ToString())
                    {
                        case "Item0":
                            this.ResponseType = "Other";
                        break;
                        case "Item10":
                            this.ResponseType = "Acknowledgement";
                        break;
                        case "Item20":
                            this.ResponseType = "Rejection";
                        break;
                        case "Item30":
                            this.ResponseType = "Result";
                        break;
                    }
                }
            
            var _results = item.GatewayResponse.Results != null ? item.GatewayResponse.Results : null;
            if (_results != null)
            {
                this.ActualPrice = _results.ActualPrice != null ? _results.ActualPrice.GrossPriceAmount.Value : 0;
                this.Reference = _results.ExternalReference != null ? _results.ExternalReference.Reference.Value : "";
                this.SearchResults = new BusinessGatewayModels.SearchResults(_results.ResultTypeCode.Value.ToString());
                if (_results.Attachment != null)
                {
                    this.SearchResults.CopyRightNotices = _results.Attachment.CopyrightNotices != null ? _results.Attachment.CopyrightNotices.Value : "";
                    if (_results.Attachment.EmbeddedFileBinaryObject != null)
                    {
                        this.SearchResults.Attachment = _results.Attachment.EmbeddedFileBinaryObject.Value;
                        this.SearchResults.FileName = _results.Attachment.EmbeddedFileBinaryObject.filename;
                        this.SearchResults.FileType = _results.Attachment.EmbeddedFileBinaryObject.format;
                        this.SearchResults.MimeCode = _results.Attachment.EmbeddedFileBinaryObject.mimeCode;
                    }
                }
                if (_results.HMLRReference != null)
                {
                    this.SearchResults.HMLRReference = _results.HMLRReference.Reference != null ? _results.HMLRReference.Reference.Value : "";
                }
                

                Successful = true;
            }
            else
            {
                
                Successful = false;
            }

        }

    }
}
