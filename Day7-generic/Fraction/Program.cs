using System;


class program
{
    public static void Main()
    {


        Fraction<double> fraction1 = new Fraction<double>(1, 2);
        Fraction<int> fraction2 = new Fraction<int>(2, 3);
        Fraction<double> fraction3 = new Fraction<double>(1.5, 2.3);
        Fraction<double> fraction4 = new Fraction<double>();

        fraction4 = fraction1 + fraction3;
        if (fraction1 > fraction3)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        Console.WriteLine(fraction4);
        fraction1.Print();
        fraction2.Print();
        fraction3.Print();
    }
}