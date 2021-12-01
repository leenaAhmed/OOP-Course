using System;


class Fraction<T> 
{

    public T Numerator { get; set; }
    public T Denominator { get; set; }


    public Fraction(T numerator, T denominator)
    {
        this.Numerator = numerator;
        this.Denominator = denominator;

    }
    public Fraction()
    {
    }

    public void Print()
    {
        Console.WriteLine(" fraction is : " + this.Numerator + "/" + this.Denominator);
    }


    public static Fraction<T> operator +(Fraction<T> frac1, Fraction<T> frac2)
    {

        // 1/2 + 3/4 = (1*4) + (3*2) / (2*4) = 10/8 

        dynamic NewFrac1 = frac1;
        dynamic NewFrac2 = frac2;

        return new Fraction<T>((NewFrac1.Numerator * NewFrac2.Denominator) + (NewFrac2.Numerator * frac1.Denominator), NewFrac1.Denominator * NewFrac2.Denominator);

    }

    public static Fraction<T> operator ++(Fraction<T> frac1)
    {
        dynamic NewFrac1 = frac1;

        return new Fraction<T>(NewFrac1.Numerator + NewFrac1.Denominator, NewFrac1.Denominator);
    }

    public static bool operator >(Fraction<T> frac1, Fraction<T> frac2)
    {
        dynamic NewFrac1 = frac1;
        dynamic NewFrac2 = frac2;
        return NewFrac1.Numerator * NewFrac2.Denominator > NewFrac1.Denominator * NewFrac2.Numerator;
    }
    public static bool operator <(Fraction<T> frac1, Fraction<T> frac2)
    {
        dynamic NewFrac1 = frac1;
        dynamic NewFrac2 = frac2;
        return NewFrac1.Numerator * NewFrac2.Denominator < NewFrac1.Denominator * NewFrac2.Numerator;
    }



}