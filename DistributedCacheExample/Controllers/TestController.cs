using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;

namespace DistributedCacheExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly IDistributedCache _cache;

        public TestController(IDistributedCache cache)
        {
            _cache = cache;
        }
        public async Task<string> Index()
        {
            await _cache.SetStringAsync("TestKey", "TestValue123");
            return _cache.GetString("TestKey");            
        }
    }
}
