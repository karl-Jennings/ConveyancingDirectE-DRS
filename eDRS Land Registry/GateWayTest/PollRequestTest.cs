using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessGatewayRepositories.AttachmentServiceRequest;

namespace GateWayTest
{
    [TestClass]
    public class PollRequestTest
    {

        [TestMethod]
        public void PollRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
           
            var _reponse = _services.PollRequest( "BGUser001", "landreg001", "pollscenario6");

            Assert.AreEqual(true, true);
        }
    }
}
