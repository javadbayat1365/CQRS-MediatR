using MediatR;

namespace MediatR_CQRS.Events.EventHandlers
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
