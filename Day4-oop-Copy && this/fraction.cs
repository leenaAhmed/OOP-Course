using System;


class Fraction
{
    // Initialize  fraction probarity
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public static int Counter { get; set; }
    //  Initialize  fraction constructor 



    public Fraction(int numerator, int denominator)
    {
        this.Numerator = numerator;
        this.Denominator = denominator;

        Counter++;

    }

    // constractor  fraction chain
    public Fraction(int denominator) : this(denominator, 1) { }
    public Fraction() : this(1, 1) { }

    public void Print()
    {
        Console.WriteLine(" fraction is : " + this.Numerator + "/" + this.Denominator);
    }

    // overloading  fraction operation 
    public static Fraction operator +(Fraction frac1, Fraction frac2)
    {

        if (frac1.Denominator == frac2.Denominator)
        {
            Fraction result = new Fraction();
            result.Numerator = (frac1.Numerator + frac2.Numerator);
            result.Denominator = frac1.Denominator;
            return result;
        }

        // 1/2 + 3/4 = (1*4) + (3*2) / (2*4) = 10/8 

        Fraction Result = new Fraction();
        Result.Numerator = (frac1.Numerator * frac2.Denominator) + (frac2.Numerator * frac1.Denominator);
        Result.Denominator = frac1.Denominator * frac2.Denominator;

        return Result;

    }
    public static Fraction operator ++(Fraction frac1)
    {
        return new Fraction(frac1.Numerator + frac1.Denominator, frac1.Denominator);
    }
    public static bool operator >(Fraction frac1, Fraction frac2)
    {
        int NewFrac1 = frac1.Numerator * frac2.Denominator;
        int NewFrac2 = frac1.Denominator * frac2.Numerator;
        return NewFrac1 > NewFrac2;
    }
    public static bool operator <(Fraction frac1, Fraction frac2)
    {
        int NewFrac1 = frac1.Numerator * frac2.Denominator;
        int NewFrac2 = frac1.Denominator * frac2.Numerator;
        return NewFrac1 < NewFrac2;
    }


}