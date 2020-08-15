using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Demo.Processors.PreProcessors
{
    public class PreProcessedHelloRequestPreProcessor : IRequestPreProcessor<PreProcessedHelloRequest>
    {
        public Task Process(PreProcessedHelloRequest request, CancellationToken cancellationToken)
        {
            request.Name = request.Name.ToUpper();

            return Task.CompletedTask;
        }
    }
}
