namespace MediatR.Demo.Processors.PostProcessors
{
    public class PostProcessedHelloResponse
    {
        public string Message { get; set; }

        public PostProcessedHelloResponse(string message)
        {
            Message = message;
        }
    }
}