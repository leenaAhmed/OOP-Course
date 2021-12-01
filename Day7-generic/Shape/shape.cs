using System.ComponentModel;
using System;


abstract class Shape
{
    public double Dim { get; set; }

    public Shape(double dim )
    {
        Dim = dim;
    }
    public abstract  double getArea();
   
}