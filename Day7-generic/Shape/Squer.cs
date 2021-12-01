using System;
class Square : Shape
{

    public Square(double Dim) : base(Dim) { }

    public override double getArea()
    {

        return Dim * Dim;
    }

}