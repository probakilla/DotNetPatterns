namespace DotNetPatterns.Creational.Prototype
{
    public abstract class Screen
    {
        public int Size { get; set; }

        protected Screen(int size)
        {
            Size = size;
        }

        public abstract Screen Clone();
    }
}
