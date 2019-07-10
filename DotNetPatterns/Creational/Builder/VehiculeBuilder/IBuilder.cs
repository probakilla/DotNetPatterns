using DotNetPatterns.Creational.Builder.Vehicule;

namespace DotNetPatterns.Creational.Builder.VehiculeBuilder
{
    public interface IBuilder
    {
        void InitVehicule();
        void AddBody();
        void AddWheel();
        void AddEngine();
        IVehicule GetVehicule();
    }
}
