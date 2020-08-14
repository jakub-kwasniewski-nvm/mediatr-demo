namespace MediatR.Demo.Notifications.DoubleHello
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
