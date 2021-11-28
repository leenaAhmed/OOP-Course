using System;

class Rectangle
{
    public int Width { get; set; }
     public int Height { get; set; }
   

     public Rectangle(int Width , int Height){
         this.Width = Width;
         this.Height = Height;
     } 
    //  copy constractor 
      public Rectangle(Rectangle s){
         Width = s.Width;
         Height = s.Height;
      } 

      public double GetAreaOfRectangle(){
          Double Area = Width * Height ;
          return Area ;
      }
}