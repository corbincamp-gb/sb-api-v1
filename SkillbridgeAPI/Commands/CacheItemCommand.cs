using LazyCache;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;
using SkillBridgeAPI.Caching;
using System.Buffers;
using Taku.Core;
using Taku.Core.Models;

namespace SkillBridgeAPI.Commands
{
    public interface ICacheItemCommand : IRenderingCommand
    {
        void Execute(string key, object data, bool minutes, int expires, int slidingExp, long size);
    }

    public class CacheItemCommand(IMemoryCache _cacheProvider) : ICacheItemCommand
    {
        public void Execute(string key, object data, bool minutes, int expires, int slidingExp, long size)
        {
            var cacheEntry = new MemoryCacheEntryOptions()
            {
                AbsoluteExpiration = minutes ? DateTime.Now.AddMinutes(expires) : DateTime.Now.AddSeconds(expires),
                SlidingExpiration = minutes ? TimeSpan.FromMinutes(slidingExp) : TimeSpan.FromSeconds(slidingExp),
                Size = size
            };
            _cacheProvider.Set(key, data, cacheEntry);
        }
    }
}
