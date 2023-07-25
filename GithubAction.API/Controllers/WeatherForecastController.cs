using Microsoft.AspNetCore.Mvc;

namespace GithubAction.API.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        public int GetEvenDigit() {
            int[] nums = new int[5] { 2, 345, 2, 6, 7896 };
            int totalEvenNumbers = 0;
            for(int i =0;i< nums.Length; i++)
            {
                var n = nums[i].ToString();
               if(n.Length%2==0) totalEvenNumbers++;
            }
            return totalEvenNumbers;
        }
    }
}