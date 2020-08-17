using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Demo.Exceptions
{
    public class ExceptionalHelloRequestHandler : IRequestHandler<ExceptionalHelloRequest, string>
    {
        public Task<string> Handle(ExceptionalHelloRequest request, CancellationToken cancellationToken)
        {
            throw new ArgumentException($"Name \"{request.Name}\" is not allowed, pick a different name");
        }
    }
}
