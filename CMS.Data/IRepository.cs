using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> List();

        IEnumerable<T> ListFromDB();
        T Save(T t);
    }
}
