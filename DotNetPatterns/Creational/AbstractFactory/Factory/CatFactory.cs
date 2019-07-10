using DotNetPatterns.Creational.AbstractFactory.Animal;

namespace DotNetPatterns.Creational.AbstractFactory.Factory
{
    public class CatFactory : IFactory
    {
        public IAnimal GetAnimal() => new ConcreteAnimal("cat", "cat", "cat", "meow");
    }
}
