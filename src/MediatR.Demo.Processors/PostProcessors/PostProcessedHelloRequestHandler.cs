using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Processors.PostProcessors
{
    public class PostProcessedHelloRequestHandler : IRequestHandler<PostProcessedHelloRequest, PostProcessedHelloResponse>
    {
        public Task<PostProcessedHelloResponse> Handle(PostProcessedHelloRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new PostProcessedHelloResponse($"Hello {request.Name}! {nameof(PostProcessedHelloRequestHandler)} greets you!"));
        }
    }
}
