using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.DataModel
{
    public class SitePage
    {
        public int Id { get; set; }

        public int FolderId { get; set; }

        public string PageName { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public bool IsHomePage { get; set; }

        public bool IsDeleted { get; set; }
    }
}
