using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Demo.Processors.PostProcessors
{
    public class PostProcessedHelloRequestPostProcessor : IRequestPostProcessor<PostProcessedHelloRequest, PostProcessedHelloResponse>
    {
        public Task Process(PostProcessedHelloRequest request, PostProcessedHelloResponse response, CancellationToken cancellationToken)
        {
            response.Message = response.Message.ToUpper();

            return Task.CompletedTask;
        }
    }
}
