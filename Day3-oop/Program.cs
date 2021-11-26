using System;

public class program
{
    public static void Main()
    {   
        //  square
        Console.Write("Write a side of Square ? ...");
        double side = double.Parse(Console.ReadLine());
        Square square1 = new Square(side);
        double square1Area = square1.GetArea();
        Console.WriteLine(square1Area);

        // circle 
        Console.Write("Write a radius of circle ?   ");
        double redious = double.Parse(Console.ReadLine());
        Circle radius = new Circle(side);
        double circleArea = square1.GetArea();
        Console.WriteLine("circle Area is : " + circleArea);

        //    Rectangle
        Console.Write("Write a width of Rectangle ?  ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Write a height of Rectangle ?   ");

        double height = double.Parse(Console.ReadLine());
        Rectangle Rectangle = new Rectangle(width, height);
        double RectangleeArea = square1.GetArea();
        Console.WriteLine("Rectangle Area is : " + circleArea);
    }
}