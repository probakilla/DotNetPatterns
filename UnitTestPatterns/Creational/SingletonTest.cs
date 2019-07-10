using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetPatterns.Creational.Singleton;

namespace UnitTestPatterns.Creational
{
    [TestClass]
    public class SingletonTest
    {
        private CalculatorSingleton fixture;

        [TestInitialize]
        public void SetUp()
        {
            fixture = CalculatorSingleton.Instance;
        }

        [TestCleanup]
        public void TearDown()
        {
            fixture = null;
        }

        [TestMethod]
        public void TestAddition()
        {
            fixture.Addition(1, 2);
            int result = fixture.Display;
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            fixture.Substraction(2, 1);
            int result = fixture.Display;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            fixture.Multiplication(2, 2);
            int result = fixture.Display;
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            fixture.Division(2, 1);
            int result = fixture.Display;
            Assert.AreEqual(2, result);
        }

        public void TestInstance()
        {
            fixture.Addition(4, 4);
            CalculatorSingleton calculator = CalculatorSingleton.Instance;
            Assert.AreEqual(8, calculator.Display);
        }
    }
}
