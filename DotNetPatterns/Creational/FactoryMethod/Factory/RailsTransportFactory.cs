using DotNetPatterns.Creational.FactoryMethod.Transport;

namespace DotNetPatterns.Creational.FactoryMethod.Factory
{
    public class RailsTransportFactory : IFactory
    {
        public ITransport GetTransport() => new Train();
    }
}
