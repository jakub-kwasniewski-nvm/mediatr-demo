using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Notifications.MultipleNotificationHandlers
{
    public class WelcomeNotificationHandler : INotificationHandler<DoubleHelloNotification>
    {
        public Task Handle(DoubleHelloNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Hello {notification.Name}! {nameof(WelcomeNotificationHandler)} welcomes you!");

            return Task.CompletedTask;
        }
    }
}