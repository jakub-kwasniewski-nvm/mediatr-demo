using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Requests.Hello
{
    public class HelloRequestHandler : IRequestHandler<HelloRequest, string>
    {
        public Task<string> Handle(HelloRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Hello {request.Name}!");
        }
    }
}
