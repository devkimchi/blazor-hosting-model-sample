using System;
using System.Net.Http;
using System.Threading.Tasks;

using Common.Models;

using Newtonsoft.Json;

namespace Common.Services
{
    public class ApiWeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _http;

        public ApiWeatherForecastService(HttpClient http)
        {
            this._http = http ?? throw new ArgumentNullException(nameof(http));
        }

        public async Task<WeatherForecast[]> GetForecastAsync(string start = null, string range = null)
        {
            var requestUrl = $"/api/forecasts?start={start}&range={range}";
            var result = await this._http.GetStringAsync(requestUrl);
            var forecasts = JsonConvert.DeserializeObject<WeatherForecast[]>(result);

            return forecasts;
        }
    }
}