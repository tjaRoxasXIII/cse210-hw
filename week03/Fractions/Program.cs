using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"{fraction1}");
        Console.WriteLine($"{fraction2}");
        Console.WriteLine($"{fraction3}");

        Console.WriteLine("Writing sample outputs:");
        Console.WriteLine(new Fraction().GetFractionString());
        Console.WriteLine(new Fraction().GetDecimalValue());
        Console.WriteLine(new Fraction(5).GetFractionString());
        Console.WriteLine(new Fraction(5).GetDecimalValue());
        Console.WriteLine(new Fraction(3,4).GetFractionString());
        Console.WriteLine(new Fraction(3,4).GetDecimalValue());
        Console.WriteLine(new Fraction(1,3).GetFractionString());
        Console.WriteLine(new Fraction(1,3).GetDecimalValue());

    }
}