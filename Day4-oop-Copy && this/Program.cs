using System;


class program
{
    public static void Main()
    {


        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(3, 5);
        Fraction fraction3 = new Fraction();

        fraction3 = fraction1 + fraction2;

        fraction2 = fraction1++;  


        if (fraction1 > fraction3)
        {
            Console.WriteLine("yes");
        }
        else {
             Console.WriteLine("no");
        }
        Console.WriteLine(   fraction1);
        fraction1.Print();
        fraction2.Print();
        fraction3.Print();
    }
}