using CMS.Data;
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
        public SiteService(SiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }

        public void CreateSite()
        {
            _siteRepository.Save(new Data.DataModel.Site { SiteName = "TEST", Created = DateTime.Now });
        }
    }
}
