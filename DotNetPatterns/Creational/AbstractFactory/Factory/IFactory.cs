using DotNetPatterns.Creational.AbstractFactory.Animal;

namespace DotNetPatterns.Creational.AbstractFactory.Factory
{
    public interface IFactory
    {
        IAnimal GetAnimal();
    }
}
