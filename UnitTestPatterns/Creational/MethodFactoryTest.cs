using DotNetPatterns.Creational.FactoryMethod.Factory;
using DotNetPatterns.Creational.FactoryMethod.Transport;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPatterns.Creational
{
    [TestClass]
    public class MethodFactoryTest
    {
        private IFactory Factory;

        [TestCleanup]
        public void TearDown()
        {
            Factory = null;
        }

        [TestMethod]
        public void BoatFactoryTest()
        {
            InstantiateFactory("seas");
            ITransport boat = Factory.GetTransport();
            string travel = boat.Travel();
            Assert.AreEqual("Traveling by seas", travel);
        }

        [TestMethod]
        public void PlaneFactoryTest()
        {
            InstantiateFactory("air");
            ITransport plane = Factory.GetTransport();
            string travel = plane.Travel();
            Assert.AreEqual("Traveling by air", travel);
        }

        [TestMethod]
        public void TrainFactoryTest()
        {
            InstantiateFactory("rails");
            ITransport train = Factory.GetTransport();
            string travel = train.Travel();
            Assert.AreEqual("Traveling on rails", travel);
        }

        private void InstantiateFactory(string travelType)
        {
            if (travelType == "air")
            {
                Factory = new AirTransportFactory();
            }
            else if (travelType == "seas")
            {
                Factory = new SeeTransportFactory();
            }
            else if (travelType == "rails")
            {
                Factory = new RailsTransportFactory();
            }
            else
            {
                throw new System.InvalidOperationException("No factory for this");
            }
        }
    }
}
