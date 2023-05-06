using Common.Services;

using HostedWasm;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
{
    var http = new HttpClient
    {
        BaseAddress =
                //builder.HostEnvironment.IsDevelopment() ?
                //    new Uri("http://localhost:7071") :
                new Uri(builder.HostEnvironment.BaseAddress)
    };

    return http;
});
builder.Services.AddScoped<IWeatherForecastService, ApiWeatherForecastService>();

await builder.Build().RunAsync();