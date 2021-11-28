using System;

class Picture
{

    public string Color { get; set; }

    public Squer[] Squer1 { get; set; }
    public Rectangle[] Rectangle1 { get; set; }
    public Circle[] Circle1 { get; set; }



    // composition 
    // public Squer sq1
    // {
    //     get
    //     {
    //         return
    //            new Squer(sq1.Side);
    //     }
    //     set
    //     {
    //         w1 = new Squer(value.Side);
    //     }
    // }

    public Picture(string _color, Squer[] S, Rectangle[] R, Circle[] C)
    {
          //refrance 
        Color = _color;
        Squer1 = S;
        Rectangle1 = R;
        Circle1 = C;
    }


    public double GetTotalArea()
    {
        double areaSquer1 = 0;
        double areaCircle1 = 0;
        double areaRectangle2 = 0;
        for (int i = 1; i < Squer1.Length; i++)
        {
            areaSquer1 += Squer1[i].GetAreaOfSquer();
        }
        for (int i = 1; i < Rectangle1.Length; i++)
        {
            areaRectangle2 += Rectangle1[i].GetAreaOfRectangle();
        }
        for (int i = 1; i < Circle1.Length; i++)
        {
            areaCircle1 += Circle1[i].GetAreaOFCircle();
        }
        double area = areaCircle1 + areaSquer1 + areaRectangle2;

        // double area = Squer1.GetAreaOfSquer() + Rectangle1.GetAreaOfRectangle() + Circle1.GetAreaOFCircle() ;
        return area;
    }


}