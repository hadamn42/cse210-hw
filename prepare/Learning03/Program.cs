using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction friction = new Fraction();
        Console.WriteLine(friction.GetFractionString());
        Console.WriteLine(friction.GetDecimalValue());
        
        Fraction froctions = new Fraction(5);
        Console.WriteLine(froctions.GetFractionString());
        Console.WriteLine(froctions.GetDecimalValue());

        Fraction fruction = new Fraction(3, 4);
        Console.WriteLine(fruction.GetFractionString());
        Console.WriteLine(fruction.GetDecimalValue());

    }
}