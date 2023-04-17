using System;

public class Drawing
{
    //Method Area is declared as virtual to override in derived classes
    public virtual double Area()
   {
         return 0;
   }
}

//Circle class to return Area of Circle
public class Circle : Drawing
{
    public double Radius { get; set; }
    public Circle()
    {
        Radius = 5;
    }
    public override double Area()
    {
        return (3.14) * Math.Pow(Radius, 2);
    }
}
//Square class to return Area of Square 
public class Square : Drawing
{
    public double Length { get; set; }
    public Square()
    {
        Length = 6;
    }
    public override double Area()
    {
        return Math.Pow(Length, 2);
    }
}
//Rectangle class to return Area of Rectangle
public class Rectangle : Drawing
{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle()
    {
        Height = 5.3;
        Width = 3.4;
    }
    public override double Area()
    {
        return Height * Width;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating object for circle class
        Drawing circle = new Circle();
        Console.WriteLine("Area of Circle     : " + circle.Area());

        //creating object for Square class
        Drawing square = new Square();
        Console.WriteLine("Area of Square     : " + square.Area());

        //creating object for Rectangle class
        Drawing rectangle = new Rectangle();
        Console.WriteLine("Area of Rectangle  : " + rectangle.Area());
    }
}
