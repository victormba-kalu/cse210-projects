using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);


        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Fraction 3: " + fraction3.GetFractionString());

        Fraction fraction4 = new Fraction(1);
        Fraction fraction5 = new Fraction(5);
        Console.WriteLine("Fraction 4: " + fraction4.GetFractionString());
        Console.WriteLine("Fraction 4: " + fraction4.GetDecimalValue());

        Console.WriteLine("Fraction 5: " + fraction5.GetFractionString());
        Console.WriteLine("Fraction 5: " + fraction5.GetDecimalValue());

        fraction4.SetFraction(3, 4);
        fraction5.SetFraction(1, 3);

        

        Console.WriteLine("Fraction 4: " + fraction4.GetFractionString());
        Console.WriteLine("Fraction 4: " + fraction4.GetDecimalValue());

        Console.WriteLine("Fraction 5: " + fraction5.GetFractionString());
        Console.WriteLine("Fraction 5: " + fraction5.GetDecimalValue());

        

    }

}