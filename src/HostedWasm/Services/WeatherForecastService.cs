using System.Net.Http.Json;

using Common.Models;
using Common.Services;

namespace HostedWasm.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _http;

        public WeatherForecastService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<WeatherForecast[]> GetForecastAsync(string data)
        {
            return await this._http.GetFromJsonAsync<WeatherForecast[]>(data);
        }
    }
}