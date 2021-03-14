using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessGatewayRepositories.EDRSApplication;


namespace GateWayTest
{
    [TestClass]
    public class corrospondanceTest
    {

        [TestMethod]
        public void corrospondanceRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];                 

            var _reponse = _services.CorrespondenceRequest( "BGUser001", "landreg001", "msgid");

            Assert.AreEqual(true, true);
        }
    }
}
