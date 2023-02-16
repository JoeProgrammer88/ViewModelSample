using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelSample.Models;

namespace ViewModelSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            WeatherForecast dailyForecast = GetWeatherData();
            // Pass WeatherForecast object to view
            return View(dailyForecast);
        }

        private WeatherForecast GetWeatherData()
        {
            return new WeatherForecast()
            {
                AverageTemperature = WeatherForecast.ConvertCelsiusToFahrenheit(3),
                Date = DateOnly.FromDateTime(DateTime.Today),
                HighTemperature = WeatherForecast.ConvertCelsiusToFahrenheit(9),
                LowTemperature = WeatherForecast.ConvertCelsiusToFahrenheit(2),
                Humidity = .71,
                Location = "Lakewood, WA",
                PrecipitationChance = .05,
                WindSpeed = WeatherForecast.MetersPerSecondToMilesPerHour(2.5)
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}