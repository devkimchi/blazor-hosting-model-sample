using System;
using System.Net.Http;
using System.Windows;

using Common.Services;

using Microsoft.AspNetCore.Components.WebView;
using Microsoft.Extensions.DependencyInjection;

namespace HybridWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWpfBlazorWebView();

            services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7071") });
            services.AddSingleton<IWeatherForecastService, ApiWeatherForecastService>();

            Resources.Add("services", services.BuildServiceProvider());
        }

        private void Handle_UrlLoading(object sender, UrlLoadingEventArgs urlLoadingEventArgs)
        {
            if (urlLoadingEventArgs.Url.Host != "0.0.0.0")
            {
                urlLoadingEventArgs.UrlLoadingStrategy = UrlLoadingStrategy.OpenInWebView;
            }
        }
    }
}