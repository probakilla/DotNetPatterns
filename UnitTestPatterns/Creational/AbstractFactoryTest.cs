using DotNetPatterns.Creational.AbstractFactory.Animal;
using DotNetPatterns.Creational.AbstractFactory.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace UnitTestPatterns.Creational
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void CatFactoryTest()
        {
            IFactory catFactory = new CatFactory();
            IAnimal cat = catFactory.GetAnimal();
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Head of: cat").AppendLine()
                .Append("Body of: cat").AppendLine()
                .Append("Members of: cat").AppendLine()
                .Append("And says: meow").AppendLine();
            Assert.AreEqual(strBuilder.ToString(), cat.GetDescription());
        }

        [TestMethod]
        public void DogFactoryTest()
        {
            IFactory dogFactory = new DogFactory();
            IAnimal dog = dogFactory.GetAnimal();
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Head of: dog").AppendLine()
                .Append("Body of: dog").AppendLine()
                .Append("Members of: dog").AppendLine()
                .Append("And says: woof").AppendLine();
            Assert.AreEqual(strBuilder.ToString(), dog.GetDescription());
        }

        [TestMethod]
        public void ZergFactoryTest()
        {
            IFactory zergFactory = new ZergFactory();
            IAnimal zerg = zergFactory.GetAnimal();
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Head of: zerg").AppendLine()
                .Append("Body of: zerg").AppendLine()
                .Append("Members of: zerg").AppendLine()
                .Append("And says: gruik").AppendLine();
            Assert.AreEqual(strBuilder.ToString(), zerg.GetDescription());
        }
    }
}
