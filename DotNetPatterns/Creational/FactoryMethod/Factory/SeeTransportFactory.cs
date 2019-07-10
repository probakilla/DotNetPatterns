using DotNetPatterns.Creational.FactoryMethod.Transport;

namespace DotNetPatterns.Creational.FactoryMethod.Factory
{
    public class SeeTransportFactory : IFactory
    {
        public ITransport GetTransport() => new Boat();
    }
}
