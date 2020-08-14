namespace MediatR.Demo.Requests.MultipleRequestHandlers
{
    public class DoubleHelloRequest : IRequest<string>
    {
        public string Name { get; }

        public DoubleHelloRequest(string name)
        {
            Name = name;
        }
    }
}
