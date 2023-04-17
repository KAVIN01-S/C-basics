using System;

namespace RectangleApplication {
    //Rectangle class
   class Rectangle {
      //member variables
      //internal types or members are accessible only within files in the same assembly.
      internal double length;
      internal double width;
      //Method to return Area of Rectangle
      double GetArea() {
         return length * width;
      }
      
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }
   //end class Rectangle
    
   class Program{
      public static void Main(string[] args) 
      {
          //Creating object for Rectangle class
         Rectangle r = new Rectangle();
         Console.WriteLine("Enter the length:");
         r.length = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter the Width:");
         r.width = Convert.ToDouble(Console.ReadLine());
         //Display method to display the area of rectangle
         r.Display();
      }
   }
}
