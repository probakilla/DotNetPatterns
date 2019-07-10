using DotNetPatterns.Creational.Builder.Vehicule;
using DotNetPatterns.Creational.Builder.Vehicule.VehiculeParts;

namespace DotNetPatterns.Creational.Builder.VehiculeBuilder
{
    public class BikeBuilder : IBuilder
    {
        private IVehicule Vehicule;

        public BikeBuilder() { }

        public void AddBody() => Vehicule.Body = new Body("Bike body");

        public void AddEngine() => Vehicule.Engine = new Engine("Bike engine");

        public void AddWheel() => Vehicule.AddWheel(new Wheel("Bike wheel"));

        public IVehicule GetVehicule() { return Vehicule; }

        public void InitVehicule() => Vehicule = new Bike();
    }
}
