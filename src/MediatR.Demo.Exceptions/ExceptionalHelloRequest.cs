namespace MediatR.Demo.Exceptions
{
    public class ExceptionalHelloRequest : IRequest<string>
    {
        public string Name { get; }

        public ExceptionalHelloRequest(string name)
        {
            Name = name;
        }
    }
}
