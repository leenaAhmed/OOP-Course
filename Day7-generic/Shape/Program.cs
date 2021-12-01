using System;

public class Program
{
    public static void Main()
    {
        Shape[] shape = new Shape[4];

        //    squer  
        Console.Write("squer dim  :   ");
        double dimSquer = double.Parse(Console.ReadLine());
        shape[0] = new Square(dimSquer);

        Console.WriteLine("Area Of Squer =   " + shape[0].getArea());
        // rectangle 

        Console.Write("rectangle width  :  ");
        double WidthRectangle = double.Parse(Console.ReadLine());
        Console.Write("rectangle hight   : ");
        double HightRectangle = double.Parse(Console.ReadLine());

        shape[1] = new Rectangle(WidthRectangle, HightRectangle);

        Console.WriteLine("Area Of Rectangle = " + shape[1].getArea());

        //   circle 
        Console.Write("circle dim  :  ");
        double circle = double.Parse(Console.ReadLine());
        shape[2] = new Circle(circle);
        Console.WriteLine("Area Of Circle =  " + shape[2].getArea());

        // Tringle  

        Console.Write("Triangle hight   :  ");
        double hightTringle = double.Parse(Console.ReadLine());
        Console.Write("Triangle base   : ");
        double BaseTringle = double.Parse(Console.ReadLine());

        shape[3] = new Triangle(hightTringle, BaseTringle);

        Console.WriteLine("Area Of Triangle = " + shape[3].getArea());


        Picture Pic = new Picture(shape);

        Console.WriteLine("the total Area  = " + Pic.GetTotalArea());


    }

}
