using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        private DataContext _dataContext;
        private DbSet _dbSet;
        private PropertyInfo idPropertyInfo = typeof(T).GetProperties().First(p => p.Name.Equals("ID", StringComparison.OrdinalIgnoreCase));

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;

            _dbSet = _dataContext.Set(typeof(T));

        }

        public T Get(int id)
        {
            var t = TCache.Get(id);

            if (t == null)
            {
                t = (T)_dbSet.Find(id);
                TCache.Add(id, t);
            }
            return t;
        }

        public IEnumerable<T> List()
        {
            return _list();
        }

        public IEnumerable<T> ListFromDB()
        {
            return _list(true);
        }

        public T Save(T t)
        {
            t = (T)_dbSet.Add(t);
            _dataContext.SaveChanges();

            var id = GetId(t);
            if (TCache.Exist(id))
                TCache.Remove(id);

            TCache.Add(id, t);

            return t;
        }

        private IEnumerable<T> _list(bool listFromDB = false)
        {
            var ts = TCache.List();
            if (listFromDB || !ts.Any())
            {
                foreach(var t in ts)
                {
                    TCache.Remove(GetId(t));
                }

                ts = PrimeCache();
            }   

            return ts;
        }

        private IEnumerable<T> PrimeCache()
        {
            var ts = _dbSet.OfType<T>();

            foreach (var t in ts)
            {
                int id = GetId(t);
                TCache.Add(id, t);
            }
            return ts;
        }

        private int GetId(T t)
        {
            return (int)idPropertyInfo.GetValue(t);
        }

        public class TCache : Cache<T>
        {

        }
    }

    
}
