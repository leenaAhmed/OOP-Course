using System;

public class Program
{
    public static void Main()
    {
        //    squer 
        Squer[] squer = new Squer[3];
        for (int i = 1; i < squer.Length; i++)
        {
            Console.Write("squer Side [{0}]  : ", i);
            int side = int.Parse(Console.ReadLine());
            squer[i] = new Squer(side);
        }

        Rectangle[] rectangle = new Rectangle[3];
        for (int i = 1; i < rectangle.Length; i++)
        {
            Console.Write("rectangle width {0}: ", i);
            int width = int.Parse(Console.ReadLine());
            Console.Write("rectangle height {0}:  ", i);
            int height = int.Parse(Console.ReadLine());
            rectangle[i] = new Rectangle(width, height);
        }


        Circle[] circle = new Circle[3];
        for (int i = 1; i < circle.Length; i++)
        {
            Console.Write("Circle redious {0} : ", i);
            int redious = int.Parse(Console.ReadLine());

            circle[i] = new Circle(redious);
        }

        // Squer S1 = new Squer(5);
        // Circle c1 = new Circle(1);
        // Rectangle R1 = new Rectangle(4, 5);


        Picture Pic = new Picture("red", squer, rectangle, circle);

        Console.WriteLine(" the Total Area is : " + Pic.GetTotalArea());


    }

}
