using CMS.Data;
using CMS.DTO;
using CMS.DTO.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Service
{
    public class SiteService
    {
        SiteRepository _siteRepository;
        SiteFactory _siteFactory;

        public SiteService(SiteRepository siteRepository, SiteFactory siteFactory)
        {
            _siteRepository = siteRepository;
            _siteFactory = siteFactory;
        }

        public Site GetSite(int siteId)
        {
            //ToDo check auth
            var site = _siteRepository.Get(siteId);

            return _siteFactory.Map(site);
        }

        public Site CreateSite(Site site)
        {
            //ToDo: Validation
            if (!CanAccessSite())
                return null;

            var existingSite = GetSite(site.Id);

            if (existingSite != null) //Site exist already
            {
                return existingSite;
            }

            //Add a new site
            var siteData = _siteFactory.Map(site);
            siteData = _siteRepository.Save(siteData);
            //Add new site Root Folder for it



            return _siteFactory.Map(siteData);
        }

        private bool CanAccessSite()
        {
            //ToDo;
            return true;
        }
    }
}
