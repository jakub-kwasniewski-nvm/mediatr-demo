namespace MediatR.Demo.Notifications.InheritedNotificationHandlers
{
    public class DerivedHelloNotification : BaseHelloNotification
    {
        public DerivedHelloNotification(string name) : base(name.ToUpper())
        {
        }
    }
}
