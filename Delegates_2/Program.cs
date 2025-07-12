namespace Delegates_2
{
    public class Program
    {
        public delegate double MathDelegate(double x, double y);
        static void Main(string[] args)
        {
            MathDelegate mathDelegate=(x,y)=>x+y;
            var result = mathDelegate(5, 10);
            Console.WriteLine(result);

            mathDelegate = (x, y) => x - y;
            result = mathDelegate(5, 10);
            Console.WriteLine(result);

            mathDelegate = (x, y) => x - y;
            result = mathDelegate(5, 10);
            Console.WriteLine(result);

            mathDelegate = delegate (double x, double y)
            {
                if (y != 0)
                {
                    return x / y;
                }
                else
                {
                    throw new Exception("ZERO");
                }

            };

            result = mathDelegate(5, 10);
            Console.WriteLine(result);
        }
    }
}
