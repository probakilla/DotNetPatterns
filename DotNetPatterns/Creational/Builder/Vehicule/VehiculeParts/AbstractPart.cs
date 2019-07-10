namespace DotNetPatterns.Creational.Builder.Vehicule.VehiculeParts
{
    public abstract class AbstractPart : IVehiculePart
    {
        public string Name { get; set; }

        protected AbstractPart (string name)
        {
            Name = name;
        }
    }
}
