using System;
using System.Web.UI;

using Common.Models;
using Common.Services;

namespace WebForm.Controls
{
    public partial class FetchDataControl : System.Web.UI.UserControl
    {
        public IWeatherForecastService Service { get; set; }

        public string Start { get; set; }

        public string Range { get; set; }

        protected WeatherForecast[] Forecasts { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.RegisterAsyncTask(new PageAsyncTask(async _ =>
            {
                this.Forecasts = await this.Service.GetForecastAsync(this.Start, this.Range);
            }));
        }
    }
}