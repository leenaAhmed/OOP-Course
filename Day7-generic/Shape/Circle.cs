using System;

class Circle : Shape
{


    public Circle(double Dim) : base(Dim) { }

    public override double getArea()
    {

        return Dim * Dim * Math.PI;
    }


}