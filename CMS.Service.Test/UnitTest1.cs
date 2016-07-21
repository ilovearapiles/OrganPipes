using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.Data;

namespace CMS.Service.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SiteService siteService = new SiteService(new SiteRepository(new DataContext()));

            siteService.CreateSite();
        }

        [TestMethod]
        public void TestMethod2()
        {
            SiteService siteService = new SiteService(new SiteRepository(new DataContext()));

            siteService.CreateSite();
        }
    }
}
