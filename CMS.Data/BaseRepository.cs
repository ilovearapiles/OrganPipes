using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class BaseRepository<T> 
    {
        private DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        private T _get(int Id)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<T> _list()
        {
            throw new NotImplementedException();
        }

        private bool _save(T t)
        {
            throw new NotImplementedException();
        }
    }
}
