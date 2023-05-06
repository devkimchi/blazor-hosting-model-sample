using System;
using System.Linq;
using System.Threading.Tasks;

using Common.Models;

namespace Common.Services
{
    public class LocalWeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly Random random = new Random();

        public async Task<WeatherForecast[]> GetForecastAsync(string start = null, string range = null)
        {
            var startDate = DateTimeOffset.TryParse(start, out var resultStart) ? resultStart : DateTimeOffset.Now;
            var span = int.TryParse(range, out var resultRange) ? resultRange : 5;

            var forecasts = Enumerable.Range(1, span).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = random.Next(-20, 55),
                Summary = Summaries[random.Next(Summaries.Length)]
            }).ToArray();

            return await Task.FromResult(forecasts);
        }
    }
}