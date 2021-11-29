using System.ComponentModel;
using System;


class Shape
{
    public double Dim { get; set; }

    public Shape(double dim )
    {
        Dim = dim;
    }
    public virtual double getArea()
    {
        return 0;
    }
}