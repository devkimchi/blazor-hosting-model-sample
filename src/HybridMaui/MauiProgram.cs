using Common.Services;

using Microsoft.Extensions.Logging;

namespace HybridMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7071") });
            builder.Services.AddSingleton<IWeatherForecastService, ApiWeatherForecastService>();

            return builder.Build();
        }
    }
}