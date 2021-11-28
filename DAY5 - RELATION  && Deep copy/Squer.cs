using System;

class Squer
{
    public int Side { get; set; }


    public Squer(int side)
    {
        this.Side = side;
    }
    public Squer() : this(1) { }
    //  copy constractor 
    public Squer(Squer s)
    {
        Side = s.Side;
    }

    public double GetAreaOfSquer()
    {
        Double Area = Side * Side;
        return Area;
    }
      
}