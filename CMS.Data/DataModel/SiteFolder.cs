using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.DataModel
{
    public class SiteFolder
    {
        public int Id { get; set; }

        public int? ParentFolderId { get; set; }

        public int SiteId { get; set; }

        public string FolderName { get; set; }

        public string FolderDirectory { get; set; }

        public bool IsRootFolder { get; set; }
    }
}
