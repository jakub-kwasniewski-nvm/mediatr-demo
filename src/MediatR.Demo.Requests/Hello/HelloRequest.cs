namespace MediatR.Demo.Requests.Hello
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
