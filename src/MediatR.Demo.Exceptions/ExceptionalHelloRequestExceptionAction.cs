using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Demo.Exceptions
{
    public class ExceptionalHelloRequestExceptionAction :
        IRequestExceptionAction<ExceptionalHelloRequest>,
        IRequestExceptionAction<ExceptionalHelloRequest, ArgumentException>
    {
        public Task Execute(
            ExceptionalHelloRequest request,
            Exception exception,
            CancellationToken cancellationToken)
        {
            Console.WriteLine($"Some exception action executed for name \"{request.Name}\": {exception.Message}");

            return Task.CompletedTask;
        }

        public Task Execute(
            ExceptionalHelloRequest request,
            ArgumentException exception,
            CancellationToken cancellationToken)
        {
            Console.WriteLine($"Argument exception action executed for name \"{request.Name}\": {exception.Message}");

            return Task.CompletedTask;
        }
    }
}
