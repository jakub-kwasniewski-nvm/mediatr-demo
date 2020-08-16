namespace MediatR.Demo.Behaviors.SpecificBehaviors
{
    public class SpecificBehaviorWrappedHelloRequest : IRequest<string>
    {
        public string Name { get; set; }

        public SpecificBehaviorWrappedHelloRequest(string name)
        {
            Name = name;
        }
    }
}
