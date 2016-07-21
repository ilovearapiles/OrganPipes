using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.DataModel
{
    public class Company
    {
        public int Id { get; set; }

        public string DefaultUserId { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public bool IsDeleted { get; set; }
    }
}
