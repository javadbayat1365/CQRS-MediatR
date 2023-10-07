using MediatR;
using MediatR_CQRS.Commands;
using MediatR_CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace MediatR_CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IMediator mediator)
        {
            _logger = logger;
            this._mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCustorm([FromBody]CreateCustomerCommand createCustomerCommand)
        {
            var customer =await _mediator.Send(createCustomerCommand);
            return Ok(customer);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var customer = _mediator.Send(new GetCustomerByIdQuery(id) { });
            return Ok(customer);
        }

    }
}
