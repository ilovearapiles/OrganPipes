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

        public Site CreateSite(Site site)
        {
            var siteData = _siteFactory.Map(site);

            //ToDo: Validation
            siteData = _siteRepository.Save(siteData);

            return _siteFactory.Map(siteData);
        }
    }
}
