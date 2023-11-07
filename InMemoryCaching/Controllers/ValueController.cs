using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public ValueController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("set/{name}")]
        public void Set(string name)
        {
            //_memoryCache.Set("name", name);
            _memoryCache.Set("name", name, options: new() { AbsoluteExpiration = DateTime.Now.AddSeconds(30), SlidingExpiration = TimeSpan.FromSeconds(10) });
        }

        [HttpGet("Get")]
        public string Get()
        {
            //return _memoryCache.Get<string>("name");
            if (_memoryCache.TryGetValue<string>("name", out string nameValue))
            {
                return nameValue;
            }
            else
            {
                return "yook";
            }
        }

        [HttpGet("remove/{name}")]
        public void remove(string name)
        {
            _memoryCache.Remove("name");
        }
    }
}
