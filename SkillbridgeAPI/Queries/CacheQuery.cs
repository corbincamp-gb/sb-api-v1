using LazyCache;
using Microsoft.Extensions.Caching.Memory;
using SkillBridgeAPI.Caching;
using Taku.Core;
using Taku.Core.Models;

namespace SkillBridgeAPI.Queries
{
    public interface ICacheQuery : IQuery
    {
        bool Get<T>(string key, out T? result);
    }

    public class CacheQuery(IMemoryCache _cacheProvider) : ICacheQuery
    {
        public bool Get<T>(string key, out T? result)
        {
            if (_cacheProvider.TryGetValue(CacheKeys.ProgramOrgs, out T? res))
            {
                result = res;
                return true;
            }

            result = default;
            return false;

        }
    }
}
