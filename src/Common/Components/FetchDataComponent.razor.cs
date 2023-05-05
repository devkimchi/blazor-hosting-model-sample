using Microsoft.AspNetCore.Components;

using Common.Models;
using Common.Services;

namespace Common.Components
{
    public partial class FetchDataComponent : ComponentBase
    {
        [Inject]
        public IWeatherForecastService? ForecastService { get; set; }

        [Parameter]
        public string? Data { get; set; }

        protected WeatherForecast[]? Forecasts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.Forecasts = await this.ForecastService.GetForecastAsync(this.Data);
        }
    }
}