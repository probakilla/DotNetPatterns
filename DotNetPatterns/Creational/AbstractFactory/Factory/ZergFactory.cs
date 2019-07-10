using DotNetPatterns.Creational.AbstractFactory.Animal;

namespace DotNetPatterns.Creational.AbstractFactory.Factory
{
    public class ZergFactory : IFactory
    {
        public IAnimal GetAnimal() => new ConcreteAnimal("zerg", "zerg", "zerg", "gruik");
    }
}
