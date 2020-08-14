namespace MediatR.Demo.Notifications.InheritedNotificationHandlers
{
    public class BaseHelloNotification : INotification
    {
        public string Name { get; }

        public BaseHelloNotification(string name)
        {
            Name = name;
        }
    }
}
