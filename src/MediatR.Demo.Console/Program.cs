using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR.Demo.Notifications.DoubleHello;
using MediatR.Demo.Notifications.Inheritance;
using MediatR.Demo.Requests.DoubleHello;
using MediatR.Demo.Requests.Hello;
using Microsoft.Extensions.DependencyInjection;

namespace MediatR.Demo.ConsoleApp
{
    static class Program
    {
        public static async Task Main()
        {
            var userName = GetUserName();
            var mediator = GetMediator();

            await SendAndWait(() => mediator.Send(new HelloRequest(userName)));
            await SendAndWait(() => mediator.Send(new DoubleHelloRequest(userName)));
            await PublishAndWait(() => mediator.Publish(new DoubleHelloNotification(userName)));
            await PublishAndWait(() => mediator.Publish(new BaseHelloNotification(userName)));
            await PublishAndWait(() => mediator.Publish(new DerivedHelloNotification(userName)));
        }

        private static string GetUserName()
        {
            Console.WriteLine("What's your name?");
            return Console.ReadLine();
        }

        private static IMediator GetMediator()
        {
            var services = new ServiceCollection();

            services.AddMediatR(
                Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(Assembly.Load).ToArray());

            return services.BuildServiceProvider().GetRequiredService<IMediator>();
        }

        private static async Task SendAndWait(Func<Task<string>> sendFunc)
        {
            var result = await sendFunc();

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static async Task PublishAndWait(Func<Task> publishFunc)
        {
            await publishFunc();
            
            Console.ReadLine();
        }
    }
}
