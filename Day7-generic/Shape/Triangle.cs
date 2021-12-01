using System;
class Triangle : Shape
{
    public double baseoftriangle { get; set; }
    public Triangle(double Dim, double baseT) : base(Dim)
    {
        baseoftriangle = baseT;
    }

    public override double getArea()
    {

        return (Dim * baseoftriangle) / 2;
    }

}