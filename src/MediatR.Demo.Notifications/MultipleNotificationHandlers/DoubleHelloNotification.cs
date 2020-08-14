namespace MediatR.Demo.Notifications.MultipleNotificationHandlers
{
    public class DoubleHelloNotification : INotification
    {
        public string Name { get; }

        public DoubleHelloNotification(string name)
        {
            Name = name;
        }
    }
}
