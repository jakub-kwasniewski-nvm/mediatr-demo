namespace MediatR.Demo.Requests.SingleRequestHandler
{
    public class HelloRequest : IRequest<string>
    {
        public string Name { get; }

        public HelloRequest(string name)
        {
            Name = name;
        }
    }
}
