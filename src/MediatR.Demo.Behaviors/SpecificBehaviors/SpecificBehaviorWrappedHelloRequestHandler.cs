using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Behaviors.SpecificBehaviors
{
    public class SpecificBehaviorWrappedHelloRequestHandler : IRequestHandler<SpecificBehaviorWrappedHelloRequest, string>
    {
        public Task<string> Handle(SpecificBehaviorWrappedHelloRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Hello {request.Name}! {nameof(SpecificBehaviorWrappedHelloRequestHandler)} greets you!");
        }
    }
}
