using MediatR;

namespace MediatR_CQRS.Events.CustomerGetByIdEventHadler
{
    public class CustomerGetByIdLoggerHandler : INotificationHandler<CustomerGetByIdEvent>
    {
        private readonly ILogger<CustomerGetByIdLoggerHandler> _logger;

        public CustomerGetByIdLoggerHandler(ILogger<CustomerGetByIdLoggerHandler> logger)
        {
            this._logger = logger;
        }
        public Task Handle(CustomerGetByIdEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"The user {notification.Fname} {notification.LName} get by Id");
            return Task.CompletedTask;
        }
    }
}
