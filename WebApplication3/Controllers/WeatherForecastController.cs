using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private IConfiguration _Configuration;
        private IAUthod _aUthod;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration
            , IAUthod aUthod)
        {
            _logger = logger;
            this._Configuration = configuration;
            _aUthod = aUthod;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            // return _Configuration["names"];
            string result = _aUthod.Show();
            return result;
        }
    }
}