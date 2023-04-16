using System;

namespace RectangleApplication {
    //Rectangle class
   class Rectangle {
      //member variables
      internal double length;
      internal double width;
      
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
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         Console.WriteLine("Enter the length:");
         r.length = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter the Width:");
         r.width = Convert.ToDouble(Console.ReadLine());
         r.Display();
      }
   }
}
