using Microsoft.AspNetCore.Components;

using ServerApp.Models;
using ServerApp.Services;

namespace ServerApp.Components
{
    public partial class FetchDataComponent : ComponentBase
    {
        [Inject]
        public IWeatherForecastService? ForecastService { get; set; }

        protected WeatherForecast[]? Forecasts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.Forecasts = await this.ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
        }
    }
}