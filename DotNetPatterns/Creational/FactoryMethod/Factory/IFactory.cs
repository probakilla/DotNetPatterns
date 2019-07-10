using DotNetPatterns.Creational.FactoryMethod.Transport;

namespace DotNetPatterns.Creational.FactoryMethod.Factory
{
    public interface IFactory
    {
        ITransport GetTransport();
    }
}
