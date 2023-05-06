using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Common.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace BackendApi
{
    public class ForecastHttpTrigger
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ForecastHttpTrigger> _logger;

        public ForecastHttpTrigger(ILogger<ForecastHttpTrigger> log)
        {
            _logger = log;
        }

        [FunctionName(nameof(ForecastHttpTrigger.GetForecastsAsync))]
        [OpenApiOperation(operationId: "GetForecasts", tags: new[] { "forecast" })]
        [OpenApiParameter(name: "start", In = ParameterLocation.Query, Required = false, Type = typeof(string), Description = "The date to start")]
        [OpenApiParameter(name: "range", In = ParameterLocation.Query, Required = false, Type = typeof(string), Description = "The date range to return")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(WeatherForecast[]), Description = "The OK response")]
        public async Task<IActionResult> GetForecastsAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "forecasts")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var startDate = DateTimeOffset.TryParse(req.Query["start"], out var resultStart) ? resultStart : DateTimeOffset.Now;
            var range = int.TryParse(req.Query["range"], out var resultRange) ? resultRange : 5;

            var forcasts = Enumerable.Range(1, range).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();

            return await Task.FromResult(new OkObjectResult(forcasts));
        }
    }
}