using CMS.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class SiteRepository : IRepository<Site>
    {
        private readonly DataContext _dataContext;

        public SiteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Site Get(int id)
        {
            var site = SiteCache.Get(id);

            if (site == null)
            {
                site = _dataContext.Sites.SingleOrDefault(s => s.Id == id);
                SiteCache.Add(site.Id, site);
            }

            return site;
        }

        public IEnumerable<Site> List()
        {
            return _list();
        }

        public IEnumerable<Site> ListFromDB()
        {
            return _list(true);
        }

        public void Save(Site site)
        {
            site = _dataContext.Sites.Add(site);
            _dataContext.SaveChanges();

            if (SiteCache.Exist(site.Id))
                SiteCache.Remove(site.Id);

            SiteCache.Add(site.Id, site);
        }

        private IEnumerable<Site> _list(bool listFromDB = false)
        {
            var sites = SiteCache.List();

            if (!sites.Any())
            {
                sites = _dataContext.Sites;

                foreach (var site in sites)
                {
                    SiteCache.Add(site.Id, site);
                }
            }

            return sites;
        }
    }

    public class SiteCache : Cache<Site> {}
}
