using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Text.Unicode;

namespace DistributedCachingRedis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly IDistributedCache _distributedCache;

        public ValueController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        [HttpGet("set")]
        public async Task<IActionResult> set(string name)
        {
            await _distributedCache.SetStringAsync("name", name, options: new()
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(30),
                SlidingExpiration = TimeSpan.FromSeconds(5)
            });
            //string result = await _distributedCache.GetStringAsync(name);
            return Ok();
        }

        [HttpGet("get")]
        public async Task<IActionResult> get()
        {
            string result = await _distributedCache.GetStringAsync("name");
            //byte[] arrayResult = await _distributedCache.GetAsync("name");
            //string stringResult = Encoding.UTF8.GetString(arrayResult);
            return Ok(result);
        }
    }
}
