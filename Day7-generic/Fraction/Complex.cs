using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAy4
{
    class Complex
    {
        public int Real { set; get;  }
        public int Imagine { get; set; }
        public int[] arr;
        //public double Asd { get; set; }
        public static int Counter { get; set; }
        static Complex()
        { Counter = 5; }
        public Complex(int real,double asd):this(real,1){
            //Real = 3;
            //Asd = asd;
        }   //chain constructor 
        public Complex():this(1,1){}
       
        
        public Complex(int real, int Imagine,int[] _arr)//:this(reaasdasdl, 2.5)
        {
            this.Real = real;
            this.Imagine = Imagine;
            Counter++;
            //arr = _arr;    //shallow copy

            arr = new int[3];       //deep copy
            for (int i = 0; i < _arr.Length; i++)
            {
                arr[i] = _arr[i];
            }

        }

        public Complex (Complex c)   // copy constructor 
        {

            this.Real = c.Real;
            this.Imagine = c.Imagine;
            this.arr = new int[3];       //deep copy
            for (int i = 0; i < c.arr.Length; i++)
            {
                arr[i] = c.arr[i];
            }
        }
        public Complex(int real, int Imagine)//:this(reaasdasdl, 2.5)
        {
            this.Real = real;
            this.Imagine = Imagine;
            Counter++;
            arr = new int[3];

        }
        public void Print ()
        {
            Console.WriteLine(this.Real + "+" + this.Imagine + "i");  // num1 + '/' + num2
            //PrintCounter();
        }
        public static void PrintCounter()
        { 
            Console.WriteLine(Counter);
            
        }

        // operator overloading 
          public static Complex operator +(Complex c1,Complex c2) // - * / 
        {
            Complex Result = new Complex();
            Result.Real = c1.Real + c2.Real;
            Result.Imagine = c1.Imagine + c2.Imagine;
            return Result;
        }
        public static Complex operator ++(Complex c) //  -- 
        {
            Complex res = new Complex(c.Real+1, c.Imagine+1);
            
            return res;
        }

        public static bool operator > (Complex c1,Complex c2) // >= <= == != 
        {
            return c1.Real > c2.Real && c1.Imagine > c2.Imagine;
        }
        public static bool operator <(Complex c1, Complex c2)
        {
            return c1.Real < c2.Real && c1.Imagine < c2.Imagine;
        }

        public Complex copy ()
        {
            int[] Temp = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Temp[i] = arr[i];
            }

            return new Complex(this.Real, this.Imagine,Temp);
        }

        ~ Complex ()
        {
            Counter--;
        }




    }
}
