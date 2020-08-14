using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Notifications.DoubleHello
{
    public class GreetingNotificationHandler : INotificationHandler<DoubleHelloNotification>
    {
        public Task Handle(DoubleHelloNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Hello {notification.Name}! {nameof(GreetingNotificationHandler)} greets you!");

            return Task.CompletedTask;
        }
    }
}
