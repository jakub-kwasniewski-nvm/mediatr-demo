using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Behaviors.SpecificRequestBehaviors
{
    public class BehaviorWrappedHelloRequestHandler : IRequestHandler<BehaviorWrappedHelloRequest, string>
    {
        public Task<string> Handle(BehaviorWrappedHelloRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Hello {request.Name}! {nameof(BehaviorWrappedHelloRequestHandler)} greets you!");
        }
    }
}
