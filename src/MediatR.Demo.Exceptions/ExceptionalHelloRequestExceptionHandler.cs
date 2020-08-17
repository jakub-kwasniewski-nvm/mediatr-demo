using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Demo.Exceptions
{
    public class ExceptionalHelloRequestExceptionHandler :
        IRequestExceptionHandler<ExceptionalHelloRequest, string>,
        IRequestExceptionHandler<ExceptionalHelloRequest, string, ArgumentException>
    {
        public Task Handle(
            ExceptionalHelloRequest request,
            Exception exception,
            RequestExceptionHandlerState<string> state,
            CancellationToken cancellationToken)
        {
            state.SetHandled($"Some exception was handled for name \"{request.Name}\": {exception.Message}");

            return Task.CompletedTask;
        }

        public Task Handle(
            ExceptionalHelloRequest request,
            ArgumentException exception,
            RequestExceptionHandlerState<string> state,
            CancellationToken cancellationToken)
        {
            state.SetHandled($"Argument exception was handled for name \"{request.Name}\": {exception.Message}");

            return Task.CompletedTask;
        }
    }
}
