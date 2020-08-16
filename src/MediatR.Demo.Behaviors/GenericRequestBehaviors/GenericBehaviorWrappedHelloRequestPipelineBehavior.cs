using System.Diagnostics;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Behaviors.GenericRequestBehaviors
{
    public class GenericPipelineBehavior<TRequest, TResponse>
        : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            Debug.WriteLine($"{typeof(TRequest).Name}: {JsonSerializer.Serialize(request)}");
            var response = await next();
            Debug.WriteLine($"{typeof(TResponse).Name}: {JsonSerializer.Serialize(response)}");

            return response;

        }
    }
}
