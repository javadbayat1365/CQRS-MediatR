using MediatR;
using MediatR_CQRS.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace MediatR_CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IMediator mediator)
        {
            _logger = logger;
            this._mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCustorm([FromBody]CreateCustomerCommand createCustomerCommand)
        {
            var customer =await _mediator.Send(createCustomerCommand);
            return Ok(customer);
        }
    }
}