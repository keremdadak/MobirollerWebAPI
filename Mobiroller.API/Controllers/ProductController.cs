using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Mobiroller.Core.Models;

namespace Mobiroller.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        private readonly IMemoryCache _memoryCache;

        public ProductController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
         
            List<Product> productList = new List<Product> { new Product { Id = 1, Name = "Mobil Uygulama 1 ", Description = "Test Mobil Uygulama 1", Price = 200 }, new Product { Id = 2, Name = "Mobil Uygulama 2 ", Description = "Test Mobil Uygulama 2", Price = 300 } };

            
                // Cache time and importance
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                    .SetPriority(CacheItemPriority.Normal);
      
                _memoryCache.Set(productList, cacheEntryOptions);
            
            return productList;
        }


    }
}
