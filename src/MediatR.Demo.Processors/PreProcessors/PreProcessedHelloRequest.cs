namespace MediatR.Demo.Processors.PreProcessors
{
    public class PreProcessedHelloRequest : IRequest<string>
    {
        public string Name { get; set; }

        public PreProcessedHelloRequest(string name)
        {
            Name = name;
        }
    }
}
