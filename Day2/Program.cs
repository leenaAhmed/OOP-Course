using System;

public class Program
{
    public static int AddNum(int n1, int n2, int n3)
    {
        int total = (n1 + n2 + n3);
        return total;
    }
    public static int FindFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return FindFibonacci(n - 1) + FindFibonacci(n - 2);
        }
    }
    public static int RemainderDivided(int num1, int num2, out int reminder)
    {

        // while (num2 != 0)
        // {
        //     if (num1 < num2) continue;
        // }
        reminder = num1 % num2;
        return num1 / num2;
    }
    public static void Students(int[,] data)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write("Elemnts[{0} , {1}] =  " ,  i , j);
                data[i, j] = Convert.ToInt32((Console.ReadLine()));
            }
        }
        int grade = 0;
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                grade += data[i, j];
            }
            if (grade > 50)
            {
                Console.WriteLine(" the student is sucess :  " + i + 1);
                Console.WriteLine(" the avarage  " + grade / data.GetLength(1));
            }
            else
            {
                Console.WriteLine(" the student is fail :( " + i + 1);
                Console.WriteLine(" the avarage  is :  " + grade / data.GetLength(1));
            }
            grade = 0;
        }
    }
    public static void Main()
    {
        //1. write a program to sum 3 digits (use function) 
        #region sum 3 digits
        // int num1, num2, num3, sum;
        // Console.Write("Number 1: ");
        // num1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Number 2: ");
        // num2 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Number 3: ");
        // num3 = Convert.ToInt32(Console.ReadLine());
        // sum = AddNum(num1, num2, num3);
        // Console.WriteLine("The Sum of three numbers is " + sum);
        #endregion
        // 2. write a Program for Fibonacci numbers (use recursion) 
        #region fibonacci
        Console.WriteLine("number");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(FindFibonacci(i));
        }


        #endregion
        // 3  write function get divide and reminder of 2 numbers. 
        #region divide
        // int reminder;
        // Console.WriteLine(RemainderDivided(7, 2, out reminder));
        // Console.WriteLine("reminde {0}", reminder);
        #endregion
        // 4.4- Write a program to get number of students grades and print sum of student grade if student grades > 50 print success
        #region Students 2 Daymantion arry
        int[,] data = new int[2, 3];
        Students(data);
        #endregion


    }
}