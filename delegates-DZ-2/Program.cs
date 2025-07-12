using System;

class Program
{
    public delegate double Operation(double a, double b);

    static void Main()
    {
        Operation add = delegate (double a, double b) { return a + b; };
        Operation subtract = delegate (double a, double b) { return a - b; };
        Operation multiply = delegate (double a, double b) { return a * b; };
        Operation divide = delegate (double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("❌ Помилка: ділення на 0!");
                return double.NaN;
            }
            return a / b;
        };

        Console.WriteLine("🔢 Калькулятор (анонімні методи + перевірки)\n");

        double x = ReadDouble("Введіть перше число: ");
        double y = ReadDouble("Введіть друге число: ");

        Console.WriteLine($"\nРезультати:");
        Console.WriteLine($"➕ {x} + {y} = {add(x, y)}");
        Console.WriteLine($"➖ {x} - {y} = {subtract(x, y)}");
        Console.WriteLine($"✖ {x} * {y} = {multiply(x, y)}");
        Console.WriteLine($"➗ {x} / {y} = {divide(x, y)}");
    }

    static double ReadDouble(string prompt)
    {
        double result;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out result))
                break;
            Console.WriteLine("❗ Помилка: потрібно ввести число!");
        }
        return result;
    }
}