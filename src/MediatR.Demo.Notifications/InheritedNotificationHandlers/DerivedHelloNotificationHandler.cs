using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Notifications.InheritedNotificationHandlers
{
    public class DerivedHelloNotificationHandler : INotificationHandler<DerivedHelloNotification>
    {
        public Task Handle(DerivedHelloNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Hello {notification.Name}! {nameof(DerivedHelloNotification)} greets you!");

            return Task.CompletedTask;
        }
    }
}
