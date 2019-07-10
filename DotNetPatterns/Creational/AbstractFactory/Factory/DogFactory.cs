using DotNetPatterns.Creational.AbstractFactory.Animal;

namespace DotNetPatterns.Creational.AbstractFactory.Factory
{
    public class DogFactory : IFactory
    {
        public IAnimal GetAnimal() => new ConcreteAnimal("dog", "dog", "dog", "woof");
    }
}
