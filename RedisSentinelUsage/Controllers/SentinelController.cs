using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisSentinelUsage.Services;
using StackExchange.Redis;

namespace RedisSentinelUsage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentinelController : ControllerBase
    {
        [HttpGet("[action]/{key}/{value}")]
        public async Task<IActionResult> SetValue(string key, string value)
        {
            var redis = await RedisService.RedisMasterDatabse();
            await redis.StringSetAsync(key, value);
            return Ok();
        }

        [HttpGet("[action]/{key}")]
        public async Task<IActionResult> GetValue(string key)
        {
            var redis = await RedisService.RedisMasterDatabse();
            string data = await redis.StringGetAsync(key);
            return Ok(data);
        }
    }
}
