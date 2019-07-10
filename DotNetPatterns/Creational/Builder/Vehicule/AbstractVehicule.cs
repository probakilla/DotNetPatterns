using DotNetPatterns.Creational.Builder.Vehicule.VehiculeParts;
using System.Collections.Generic;
using System.Text;

namespace DotNetPatterns.Creational.Builder.Vehicule
{
    public abstract class AbstractVehicule : IVehicule
    {
        protected int MaxWheels = 0;
        public List<Wheel> Wheels { get; }
        public Engine Engine { get; set; }
        public Body Body { get; set; }

        protected AbstractVehicule()
        {
            Wheels = new List<Wheel>();
        }

        public void AddWheel(Wheel wheel)
        {
            if (Wheels.Count < MaxWheels)
            {
                Wheels.Add(wheel);
            }
            else
            {
                throw new System.InvalidOperationException(string.Format("Already has {0} wheels", MaxWheels));
            }
        }

        public virtual string GetVehiculeDescription()
        {
            string engineStr = CheckEngineName();
            string bodyStr = CheckBodyName();
            return BuildCommonPartDescription(engineStr, bodyStr);
        }

        private string CheckEngineName()
        {
            return Engine == null ? "No engine" : Engine.Name;
        }

        private string CheckBodyName()
        {
            return Body == null ? "No body" : Body.Name;
        }

        private string BuildCommonPartDescription(string engineName, string bodyName)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Engine: ").Append(engineName).AppendLine();
            strBuilder.Append("Body: ").Append(bodyName).AppendLine();
            return strBuilder.ToString();
        }
    }
}
