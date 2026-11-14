
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a fraction using the default constructor
        Fraction f1 = new Fraction();

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Create a fraction using one number
        Fraction f2 = new Fraction(5);

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Create a fraction using two numbers
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Create another fraction
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test getters
        Console.WriteLine("\nTesting Getters:");
        Console.WriteLine($"Top: {f3.GetTop()}");
        Console.WriteLine($"Bottom: {f3.GetBottom()}");

        // Test setters
        f3.SetTop(2);
        f3.SetBottom(5);

        Console.WriteLine("\nAfter using Setters:");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}
