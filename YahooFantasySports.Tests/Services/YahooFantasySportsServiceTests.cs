using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YahooFantasySports.Tests.Services
{
    [TestClass]
    public class YahooFantasySportsServiceTests
    {
        [TestClass]
        public class BeginAuthenticate
        {
            [TestMethod]
            public void ReturnsAnAuthorizationUrl()
            {
                var svc = new YahooFantasySports.Services.YahooFantasySportsService();
                var result = svc.BeginAuthenticate();

                Assert.IsNotNull(result);
                Assert.IsTrue(result.Length > 0);
            }
        }
    }
}
