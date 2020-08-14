using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Requests.MultipleRequestHandlers
{
    public class WelcomeRequestHandler : IRequestHandler<DoubleHelloRequest, string>
    {
        public Task<string> Handle(DoubleHelloRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Hello {request.Name}! {nameof(WelcomeRequestHandler)} welcomes you!");
        }
    }
}
