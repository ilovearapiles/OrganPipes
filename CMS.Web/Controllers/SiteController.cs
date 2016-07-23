using CMS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Web.Controllers
{
    public class SiteController : Controller
    {
        private readonly SiteService _siteService;
        public SiteController(SiteService siteService)
        {
            _siteService = siteService;
        }

        // GET: Site
        public ActionResult Index(int id)
        {
            var site = _siteService.GetSite(id);

            return View();
        }
    }
}