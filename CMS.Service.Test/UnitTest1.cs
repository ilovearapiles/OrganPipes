using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.Data;
using CMS.DTO.Factory;
using CMS.DTO;

namespace CMS.Service.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SiteService siteService = new SiteService(new SiteRepository(new DataContext()), new SiteFactory());

            Site site = new Site
            {
                SiteName = "New Site",
                Created =  DateTime.Now
            };

            siteService.CreateSite(site);
        }
    }
}
