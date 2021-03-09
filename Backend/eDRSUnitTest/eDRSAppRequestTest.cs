using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LrApiManager.SOAPManager;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.PollResponse;
using LrApiManager.XMLClases.Restriction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eDRSUnitTest
{
    [TestClass]
    public class eDRSAppRequestTest
    {


        [TestMethod]
        public void eDRSAppRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

            var _reponse = _services.eDRSApplicationRequest("tes1234", "BGUser001", "landreg001");

            Assert.AreEqual(true, true);
        }

    }
}
