using System;

class Picture
{
    public Shape[] shape { get; set; }
    public Picture(Shape[] _shape)
    {
        shape = _shape;
    }
    public double GetTotalArea()
    {
        double sumArea = 0;

        for (int i = 0; i < shape.Length; i++)
        {
            sumArea += shape[i].getArea();
        }

        return sumArea;
    }

}