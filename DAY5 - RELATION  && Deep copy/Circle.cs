using System;

class Circle
{

    public double Redious { get; set; }


    public Circle(double redious)
    {
        Redious = redious;
    }

    public Circle(Circle c)
    {
        Redious = c.Redious;
    }

    public double GetAreaOFCircle()
    {
        return Redious * Redious * Math.PI;
    }
}