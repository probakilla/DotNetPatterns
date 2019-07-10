using DotNetPatterns.Creational.FactoryMethod.Transport;

namespace DotNetPatterns.Creational.FactoryMethod.Factory
{
    public class AirTransportFactory : IFactory
    {
        public ITransport GetTransport() => new Plane();
    }
}
