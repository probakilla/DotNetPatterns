using System.Text;

namespace DotNetPatterns.Creational.Builder.Vehicule
{
    public class Bike : AbstractVehicule
    {
        public readonly static int MAX_WHEELS = 2;

        public Bike() : base()
        {
            MaxWheels = MAX_WHEELS;
        }

        public override string GetVehiculeDescription()
        {
            string wheelsName = CheckWheelsName();
            return string.Concat(BuildCarString(wheelsName), base.GetVehiculeDescription());
        }

        private string CheckWheelsName()
        {
            return Wheels == null ?
                "No wheels" :
                string.Format("Wheels: {0} bike wheel.s", Wheels.Count);
        }

        private string BuildCarString(string wheelsName)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Bike vehicule").AppendLine();
            strBuilder.Append(wheelsName).AppendLine();
            return strBuilder.ToString();
        }
    }
}
