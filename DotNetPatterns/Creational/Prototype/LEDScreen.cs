namespace DotNetPatterns.Creational.Prototype
{
    public class LedScreen : Screen
    {
        public LedScreen(int size) : base(size) { }

        public override Screen Clone()
        {
            return (Screen)MemberwiseClone();
        }
    }
}
