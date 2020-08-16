using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Behaviors.SpecificBehaviors
{
    public class SpecificBehaviorWrappedHelloRequestPipelineBehavior : IPipelineBehavior<SpecificBehaviorWrappedHelloRequest, string>
    {
        public async Task<string> Handle(
            SpecificBehaviorWrappedHelloRequest request,
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
