namespace lesson_10
{
    internal class Program
    {
        public delegate double CalcDelegate(double a, double b);
        public static double Plus(double x, double y) => x + y;
        public static double Subtract(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Divide(double x, double y) => (y!=0)?x/y:throw new Exception("Divide by zero! NOOOO!!!");
        static void Main(string[] args)
        {
            CalcDelegate calcDelegate = new CalcDelegate(Plus);
            double result = calcDelegate(2.5, 8.78);
            Console.WriteLine(result);
        }
    }
}
