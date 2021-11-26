using System;

public class Square
{

    public double Side { get; set; }

    public Square(double _side)
    {
        Side = _side;
    }
    public Square()
    {
        Side = 1;
    }

    public double GetArea()
    {
        double area = Side * Side;
        return area;
    }
}
public class Circle
{
    public double Radius { get; set; }

    public Circle(double _radius)
    {
        Radius = _radius;
    }
    public Circle()
    {
        Radius = 1;
    }
    public double GetArea()
    {
        double area = Radius * Radius * Math.PI;
        return area;
    }
}
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double _side1, double _side2)
    {
        Width = _side1;
        Height = _side2;
    }
    public Rectangle(double _side1)
    {
        Width = _side1;
        Height = 1;
    }
    public Rectangle(float _side2)
    {
        Width = 1;
        Height = _side2;
    }
    public Rectangle()
    {
        Width = 1;
        Height = 1;
    }

    public double GetArea()
    {
        double area = Width * Height;
        return area;
    }
}