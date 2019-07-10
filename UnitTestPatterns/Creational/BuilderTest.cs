using DotNetPatterns.Creational.Builder.Vehicule;
using DotNetPatterns.Creational.Builder.VehiculeBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace UnitTestPatterns.Creational
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void TestCarBuilder()
        {
            IBuilder builder = new CarBuilder();
            builder.InitVehicule();
            builder.AddBody();
            builder.AddEngine();
            for (int i = 0; i < Car.MAX_WHEELS; ++i)
            {
                builder.AddWheel();
            }
            IVehicule car = builder.GetVehicule();
            string carDescription = car.GetVehiculeDescription();
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Car vehicule").AppendLine()
                .Append("Wheels: 4 car wheel.s").AppendLine()
                .Append("Engine: Car engine").AppendLine()
                .Append("Body: Car body").AppendLine();
            Assert.AreEqual(strBuilder.ToString(), carDescription);
        }

        [TestMethod]
        public void TestBikeBuilder()
        {
            IBuilder builder = new BikeBuilder();
            builder.InitVehicule();
            builder.AddBody();
            builder.AddEngine();
            for (int i = 0; i < Bike.MAX_WHEELS; ++i)
            {
                builder.AddWheel();
            }
            IVehicule bike = builder.GetVehicule();
            string bikeDescription = bike.GetVehiculeDescription();
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Bike vehicule").AppendLine()
                .Append("Wheels: 2 bike wheel.s").AppendLine()
                .Append("Engine: Bike engine").AppendLine()
                .Append("Body: Bike body").AppendLine();
            Assert.AreEqual(strBuilder.ToString(), bikeDescription);
        }
    }
}
