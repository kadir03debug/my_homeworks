using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
using core.Utilities.IOc;
using System.Text.RegularExpressions;
namespace core.Crosscuttingconcern.Caching.Microsoft
{
    public class Memorycachemanager : ICachemanager
    {
        IMemoryCache _memorycache;
        public Memorycachemanager()
        {
            _memorycache = Servicetool.ServiceProvider.GetService<IMemoryCache>();
        }

        public void Add(string key, object value, int duration)
        {
            _memorycache.Set(key, value, TimeSpan.FromMinutes(duration));
        }

        public T get<t>(stringkey )
        {
                return _memorycache.Get<t>(key);
        }

        public object get(string key)
        {
            return _memorycache.Get(key);
        }

        public bool Issadd(string key)
        {
           return _memorycache.TryGetValue(key, out);
        }

        public void remove(string key)
        {
            _memorycache.Remove(key);
        }

        public void removebypattern(string pattern)
        {
            var cacheEntriesCollectionDefinition = typeof(MemoryCache).GetProperty("EntriesCollection", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var cacheEntriesCollection = cacheEntriesCollectionDefinition.GetValue(_memoryCache) as dynamic;
            List<ICacheEntry> cacheCollectionValues = new List<ICacheEntry>();

            foreach (var cacheItem in cacheEntriesCollection)
            {
                ICacheEntry cacheItemValue = cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null);
                cacheCollectionValues.Add(cacheItemValue);
            }

            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = cacheCollectionValues.Where(d => regex.IsMatch(d.Key.ToString())).Select(d => d.Key).ToList();

            foreach (var key in keysToRemove)
            {
                _memoryCache.Remove(key);
            }





        }
    }
}
