using ServerApp.Models;

namespace ServerApp.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate);
    }
}