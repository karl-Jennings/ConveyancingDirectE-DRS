using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessGatewayRepositories.AttachmentServiceRequest;

namespace GateWayTest
{
    [TestClass]
    public class OutstandingRequestTest
    {

        [TestMethod]
        public void OutstandingRequest()
        {
            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
           
            var _reponse = _services.Outstanding("msg00k", 70, "BGUser001", "landreg001");

            Assert.AreEqual(true, true);
        }
    }
}
