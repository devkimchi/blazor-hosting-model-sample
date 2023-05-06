using System.Threading.Tasks;

using Common.Models;

namespace Common.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(string start = null, string range = null);
    }
}