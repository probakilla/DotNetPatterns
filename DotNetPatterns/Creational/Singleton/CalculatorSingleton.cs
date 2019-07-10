namespace DotNetPatterns.Creational.Singleton
{
    public class CalculatorSingleton
    {
        private static CalculatorSingleton instance = null;
        public static CalculatorSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalculatorSingleton();
                }
                return instance;
            }
        }
        public int Display { get; private set; }

        public void Addition (int a, int b)
        {
            Display = a + b;
        }

        public void Substraction (int a, int b)
        {
            Display = a - b;
        }

        public void Multiplication (int a, int b)
        {
            Display = a * b;
        }

        public void Division (int a, int b)
        {
            Display = a / b;
        }
    }
}
