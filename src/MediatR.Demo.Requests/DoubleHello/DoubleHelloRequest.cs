namespace MediatR.Demo.Requests.DoubleHello
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
