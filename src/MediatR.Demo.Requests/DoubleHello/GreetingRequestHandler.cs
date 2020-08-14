using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Requests.DoubleHello
{
    public class GreetingRequestHandler : IRequestHandler<DoubleHelloRequest, string>
    {
        public Task<string> Handle(DoubleHelloRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Hello {request.Name}! {nameof(GreetingRequestHandler)} greets you!");
        }
    }
}
