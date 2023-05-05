using Common.Models;

namespace Common.Services
{
    public interface IWeatherForecastService
    {
        //Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate);

        Task<WeatherForecast[]> GetForecastAsync(string data);
    }
}