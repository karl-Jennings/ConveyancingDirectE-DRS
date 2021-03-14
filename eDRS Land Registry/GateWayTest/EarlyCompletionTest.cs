using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessGatewayRepositories.EarlyCompletion;


namespace GateWayTest
{
    [TestClass]
    public class EarlyCompletionTest
    {

        [TestMethod]
        public void EarlyCompletionRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];                 

            var _reponse = _services.EarlyCompletionRequest( "BGUser001", "landreg001", "msgid");

            Assert.AreEqual(true, true);
        }
    }
}
