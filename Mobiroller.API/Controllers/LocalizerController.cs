using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;


namespace Mobiroller.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizerController : ControllerBase
    {
        private readonly IStringLocalizer<LocalizerController> _stringLocalizer;

        public LocalizerController(IStringLocalizer<LocalizerController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var message = _stringLocalizer.GetAllStrings();
            return Ok(message);
        }
    }
}
