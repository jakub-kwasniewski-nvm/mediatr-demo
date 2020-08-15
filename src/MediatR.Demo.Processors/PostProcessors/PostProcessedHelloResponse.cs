namespace MediatR.Demo.Processors.PostProcessors
{
    public class PostProcessedHelloResponse
    {
        public string Message { get; set; }

        public PostProcessedHelloResponse(string message)
        {
            Message = message;
        }

        public static implicit operator string(PostProcessedHelloResponse response) => response.Message;
    }
}