using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessGatewayRepositories;

namespace BusinessGatewayModels
{
    public class ResponseOC1
    {
        public string Error { get; set; }
        public string UniqueReference { get; set; }
        public decimal ActualPrice { get; set; }
        public bool Successful { get; set; }
        public ResponseOC1() { }
        public ResponseOC1(BusinessGatewayRepositories.OC1.ResponseTitleKnownOfficialCopyV2_0Type item)
        {

            if(item.GatewayResponse.Results != null)
            {
                Successful = true;
                ActualPrice = item.GatewayResponse.Results.ActualPrice.GrossPriceAmount.Value;

            }
            

        }

    }
}
