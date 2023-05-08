using MediatR;

namespace MediatR_CQRS.Events.EcentHandlers
{
    public class CustomerCreateEmailSenderHandler : INotificationHandler<CustomerCreatedEvent>
    {
        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            //ImessagerSender.SendEmail($"Welcome {notification.FName} {notification.LName}");
            return Task.CompletedTask;
        }
    }
}
