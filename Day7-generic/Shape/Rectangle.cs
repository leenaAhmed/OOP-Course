using System;
class Rectangle : Shape
{
    public double Dim2 { get; set; }
    public Rectangle(double _Dim, double _Dim2) : base(_Dim)
    {
        Dim2 = _Dim2;
    }

    public override double getArea()
    {

        return Dim * Dim2;
    }

}