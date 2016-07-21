using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace CMS.Data
{
    public abstract class Cache<TObject>
    {
        public static void Add(int key, TObject tObject)
        {
            MemoryCache.Default.Add(GetKey(key), tObject, DateTime.Now.AddMinutes(30));
        }

        public static TObject Get(int key)
        {
            return (TObject)MemoryCache.Default[GetKey(key)];
        }

        public static void Remove(int key)
        {
            MemoryCache.Default.Remove(GetKey(key));
        }

        public static bool Exist(int key)
        {
            return MemoryCache.Default[GetKey(key)] != null;
        }

        public static IEnumerable<TObject> List()
        {
            return MemoryCache.Default.Where(s => s.Key.StartsWith(typeof(TObject).ToString() + "-")).Select(s=>(TObject)s.Value);
        }

        private static string GetKey(int key)
        {
            return typeof(TObject).ToString() + "-" + key;
        }
    }
}
