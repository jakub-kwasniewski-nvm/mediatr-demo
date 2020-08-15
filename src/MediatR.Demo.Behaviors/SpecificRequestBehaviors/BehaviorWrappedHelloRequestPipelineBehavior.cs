using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Behaviors.SpecificRequestBehaviors
{
    public class BehaviorWrappedHelloRequestPipelineBehavior : IPipelineBehavior<BehaviorWrappedHelloRequest, string>
    {
        public async Task<string> Handle(
            BehaviorWrappedHelloRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<string> next)
        {
            request.Name = request.Name
                .Reverse()
                .Aggregate(string.Empty, (accumulator, character) => $"{accumulator}{character}");

            var response = await next();

            return response.ToUpper();
        }
    }
}
