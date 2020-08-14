using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Notifications.InheritedNotificationHandlers
{
    public class BaseHelloNotificationHandler : INotificationHandler<BaseHelloNotification>
    {
        public Task Handle(BaseHelloNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Hello {notification.Name}! {nameof(BaseHelloNotification)} greets you!");

            return Task.CompletedTask;
        }
    }
}
