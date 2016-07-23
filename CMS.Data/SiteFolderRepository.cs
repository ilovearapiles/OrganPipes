using CMS.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class SiteFolderRepository : BaseRepository<SiteFolder>
    {
        private readonly DataContext _dataContext;

        public SiteFolderRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
