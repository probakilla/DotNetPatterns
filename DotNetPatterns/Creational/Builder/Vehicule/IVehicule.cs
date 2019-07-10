using DotNetPatterns.Creational.Builder.Vehicule.VehiculeParts;
using System.Collections.Generic;

namespace DotNetPatterns.Creational.Builder.Vehicule
{
    public interface IVehicule
    {
        List<Wheel> Wheels { get; }
        Engine Engine { get; set; }
        Body Body { get; set; }

        void AddWheel(Wheel wheel);
        string GetVehiculeDescription();
    }
}
