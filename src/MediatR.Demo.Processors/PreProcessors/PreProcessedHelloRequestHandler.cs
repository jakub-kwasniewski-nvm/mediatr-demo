using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Processors.PreProcessors
{
    public class PreProcessedHelloRequestHandler : IRequestHandler<PreProcessedHelloRequest, string>
    {
        public Task<string> Handle(PreProcessedHelloRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Hello {request.Name}! {nameof(PreProcessedHelloRequestHandler)} greets you!");
        }
    }
}
