using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependenciaTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
        }

        [HttpGet("FromConstrutor")]
        public IActionResult GetFromConstrutor()
        {
            return Ok();
        }

    }
}