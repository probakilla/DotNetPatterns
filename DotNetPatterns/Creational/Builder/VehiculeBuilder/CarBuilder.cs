using DotNetPatterns.Creational.Builder.Vehicule;
using DotNetPatterns.Creational.Builder.Vehicule.VehiculeParts;

namespace DotNetPatterns.Creational.Builder.VehiculeBuilder
{
    public class CarBuilder : IBuilder
    {
        private IVehicule Vehicule;

        public CarBuilder() { }

        public void AddBody() => Vehicule.Body = new Body("Car body");

        public void AddEngine() => Vehicule.Engine = new Engine("Car engine");

        public void AddWheel() => Vehicule.AddWheel(new Wheel("Car wheel"));

        public IVehicule GetVehicule() { return Vehicule; }

        public void InitVehicule() => Vehicule = new Car();
    }
}

