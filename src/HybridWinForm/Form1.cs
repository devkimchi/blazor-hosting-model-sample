using Common.Services;

using Microsoft.AspNetCore.Components.WebView;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace HybridWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();

            services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7071") });
            services.AddSingleton<IWeatherForecastService, ApiWeatherForecastService>();

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
            blazorWebView1.UrlLoading += (sender, urlLoadingEventArgs) =>
            {
                if (urlLoadingEventArgs.Url.Host != "0.0.0.0")
                {
                    urlLoadingEventArgs.UrlLoadingStrategy = UrlLoadingStrategy.OpenInWebView;
                }
            };
        }
    }
}