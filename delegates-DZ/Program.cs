

using System;

class Program
{
    public delegate double MathOperation(double a, double b);

    public static double Calculate(double x, double y, MathOperation operation)
    {
        return operation(x, y);
    }

    static List<int> Filter(List<int> numbers, Func<int, bool> condition)
    {
        return numbers.Where(condition).ToList();
    }

    static void Main()
    {
        //Завдання 1: Користувацькі делегати

        MathOperation add = (a, b) => a + b;
        MathOperation subtract = (a, b) => a - b;
        MathOperation multiply = (a, b) => a * b;
        MathOperation divide = (a, b) =>
        {
            if (b == 0) throw new DivideByZeroException("Ділення на нуль!");
            return a / b;
        };

        double x = 10;
        double y = 5;

        Console.WriteLine($"Додавання: {x} + {y} = {Calculate(x, y, add)}");
        Console.WriteLine($"Віднімання: {x} - {y} = {Calculate(x, y, subtract)}");
        Console.WriteLine($"Множення: {x} * {y} = {Calculate(x, y, multiply)}");
        Console.WriteLine($"Ділення: {x} / {y} = {Calculate(x, y, divide)}");

        //Завдання 2: Вбудовані делегати(Func, Action, Predicate)
        Console.WriteLine("===================================");
        List<int> numbers = new List<int> { 2, 5, 9, 12, 15, 22, 8, 11, 33, 4 };

        // Умова: парні числа
        Func<int, bool> isEven = x => x % 2 == 0;

        // Умова: більше ніж 10
        Func<int, bool> greaterThanTen = x => x > 10;

        // Умова: ділиться на 3
        Func<int, bool> divisibleByThree = x => x % 3 == 0;

        // Виведення результатів
        Console.WriteLine("Парні числа: " + string.Join(", ", Filter(numbers, isEven)));
        Console.WriteLine("Числа > 10: " + string.Join(", ", Filter(numbers, greaterThanTen)));
        Console.WriteLine("Числа, кратні 3: " + string.Join(", ", Filter(numbers, divisibleByThree)));
    }



}
