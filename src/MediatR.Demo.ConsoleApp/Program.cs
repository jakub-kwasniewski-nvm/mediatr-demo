using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR.Demo.Behaviors.GenericRequestBehaviors;
using MediatR.Demo.Behaviors.SpecificBehaviors;
using MediatR.Demo.Notifications.InheritedNotificationHandlers;
using MediatR.Demo.Notifications.MultipleNotificationHandlers;
using MediatR.Demo.Processors.PostProcessors;
using MediatR.Demo.Processors.PreProcessors;
using MediatR.Demo.Requests.MultipleRequestHandlers;
using MediatR.Demo.Requests.SingleRequestHandler;
using Microsoft.Extensions.DependencyInjection;

namespace MediatR.Demo.ConsoleApp
{
    static class Program
    {
        public static async Task Main()
        {
            var userName = GetUserName();
            var mediator = GetMediator();

            // 1 - Requests
            await SendAndWait(() => mediator.Send(new HelloRequest(userName)));
            await SendAndWait(() => mediator.Send(new DoubleHelloRequest(userName)));
            // 2 - Notifications
            await PublishAndWait(() => mediator.Publish(new DoubleHelloNotification(userName)));
            await PublishAndWait(() => mediator.Publish(new BaseHelloNotification(userName)));
            await PublishAndWait(() => mediator.Publish(new DerivedHelloNotification(userName)));
            // 3 - Processors
            await SendAndWait(() => mediator.Send(new PreProcessedHelloRequest(userName)));
            await SendAndWait(() => mediator.Send(new PostProcessedHelloRequest(userName)).ContinueWith(response => response.Result.Message));
            // 4 - Behaviors
            await SendAndWait(() => mediator.Send(new SpecificBehaviorWrappedHelloRequest(userName)));
            // 5 - Exceptions maybe?
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

            services.AddScoped<IPipelineBehavior<SpecificBehaviorWrappedHelloRequest, string>, SpecificBehaviorWrappedHelloRequestPipelineBehavior>();
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>));

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
