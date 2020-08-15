namespace MediatR.Demo.Behaviors.SpecificRequestBehaviors
{
    public class BehaviorWrappedHelloRequest : IRequest<string>
    {
        public string Name { get; set; }

        public BehaviorWrappedHelloRequest(string name)
        {
            Name = name;
        }
    }
}
