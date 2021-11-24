using System;

public class Program
{
    public static void Main()
    {
        // 1.write a program ask user for his gpa and show him (A,B,C,D,F)

        // Console.Write("What's your grad  ? : ");
        // double gpa = double.Parse(Console.ReadLine());

        // if (gpa >= 4) Console.Write("A");
        // else if (gpa >= 3) Console.Write("B");
        // else if (gpa >= 2) Console.Write("C");
        // else if (gpa >= 1) Console.Write("D");
        // else Console.Write("F");



        // 2- write a program ask user for number and print power of number , stop if he entered 0
        #region power
        // Console.Write("enter a number : ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // Console.Write("enter a Power :  ");
        // int power = Convert.ToInt32(Console.ReadLine());
        // do
        // {
        //     double y = Math.Pow(num, power);
        //     Console.WriteLine(y);
        //     Console.Write("enter a number : ");

        //     num = Convert.ToInt32(Console.ReadLine());

        // } while (num != 0);
        #endregion


        // 3- Write a program to display the n terms of even natural number and their sum
        #region even tanural naumber
        // Console.Write("enter a number : ");
        // int evenNumber = Convert.ToInt32(Console.ReadLine());
        // int sum = 0;

        // for (int i = 2; i <= evenNumber; i = i + 2)
        // {
        //     Console.WriteLine(i);
        //     sum += i;
        // }
        // Console.WriteLine("The sum of  no is : {0} ", sum);
        #endregion


        //4 - Write a program to read 10 numbers from keyboard and find their sum and average(bouns)
        #region Read 10 number 
        // int sum = 0;
        // for (int i = 1; i < 11; i++)
        // {
        //     Console.Write("number {0} :", i);
        //     int n = int.Parse(Console.ReadLine());
        //     sum += n;
        // }
        // double average = sum / 10.0;
        // Console.WriteLine(sum);

        // Console.WriteLine(average);
        #endregion


        // 5- Write a C program to print all alphabets from a to z. - using while loop(bouns) 
        #region alphabets 
        // char alphabet = 'a';

        // while (alphabet < 'z')
        // {
        //     Console.WriteLine(alphabet);
        //     alphabet++;
        // }
        #endregion
        #region testing
        int x = 0;
        int y = 5;

        //Console.WriteLine(x = y++);
        Console.WriteLine(x = ++y);

        #endregion

    }



}

