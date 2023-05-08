using MediatR;

namespace MediatR_CQRS.Events.EcentHandlers
{
    public class CustomerCreatedLoggerHandler : INotificationHandler<CustomerCreatedEvent>
    {
        private readonly ILogger<CustomerCreatedLoggerHandler> _logger;

        public CustomerCreatedLoggerHandler(ILogger<CustomerCreatedLoggerHandler> logger)
        {
            this._logger = logger;
        }
        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"New customer has been created at {notification.RegistrationDate}:{notification.FName} {notification.LName}");
            return Task.CompletedTask;
        }
    }
}
