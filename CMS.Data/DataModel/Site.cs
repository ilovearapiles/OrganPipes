using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.DataModel
{
    public class Site
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string SiteName { get; set; }

        public string SiteUrl { get; set; }

        public DateTime Created { get; set; }

        public bool IsDeleted { get; set; }
    }
}
