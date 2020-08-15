namespace MediatR.Demo.Processors.PostProcessors
{
    public class PostProcessedHelloRequest : IRequest<PostProcessedHelloResponse>
    {
        public string Name { get; }

        public PostProcessedHelloRequest(string name)
        {
            Name = name;
        }
    }
}
