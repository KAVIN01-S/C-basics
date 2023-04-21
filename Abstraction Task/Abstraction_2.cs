using System;

namespace Abstraction_2
{
    
    abstract class Shape
    {

        public const float pi = 3.14F;
        //method calculatePerimeter is made as Abstract
        public abstract Double calculatePerimeter();
    }
    //abstract class Shape is inherited
    class Circle : Shape
    {
        float radius;
        public Circle(float radius)
        {
            //assigning value for the field
            this.radius = radius; 
        }
        //abstract method is implemented here
        public override Double calculatePerimeter()
        {
            return (Double)2*pi*radius;
        }
    }
    //abstract class Shape is inherited
    class Rectangle : Shape
    {
        float length, breadth;
        public Rectangle(float length, float breadth)
        {
            //assigning values for the field
            this.length = length;
            this.breadth = breadth;
        }

        //abstract method is implemented here
        public override Double calculatePerimeter()
        {
            return (Double) length*2 + breadth*2;
        }
    }
    //abstract class Shape is inherited
    class Square : Shape
    {
        float side;
        public Square(float side)
        {
            //assigning value for the field
            this.side = side;
        }

        //abstract method is implemented here
        public override Double calculatePerimeter()
        {
            return (Double)side*4;
        }
    }
    class MainClass
    {
        public static void main(string[] args)
        {

            Console.WriteLine("List of Shapes\n1.Circle\n2.Rectangle\n3.Square\nEnter your choice:");
            //input range 1 to 3
            int s_no = Convert.ToInt32(Console.ReadLine());
            if(s_no==1)
            {
                Console.WriteLine("Enter the radius of the Circle:");
                float radius = (float)Convert.ToDouble(Console.ReadLine());

                //Object instantiation for Circle class
                Circle circleObject = new Circle(radius);
                Console.WriteLine("The perimeter is {0}",Math.Round(circleObject.calculatePerimeter(),2));
            }
            else if(s_no==2)
            {
                Console.WriteLine("Enter the length of the Rectangle:");
                float length  = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the breadth of the Rectangle:");
                float breadth  = (float)Convert.ToDouble(Console.ReadLine());

                //Object instantiation for Rectangle class
                Rectangle rectangleObject = new Rectangle(length, breadth);
                Console.WriteLine("The perimeter is {0}",Math.Round(rectangleObject.calculatePerimeter(),2));
            }
            else if(s_no==3)
            {
                Console.WriteLine("Enter the side of the Square:");
                float side  = (float)Convert.ToDouble(Console.ReadLine());

                //Object instantiation for Square class
                Square squareObject = new Square(side);
                Console.WriteLine("The perimeter is {0}",Math.Round(squareObject.calculatePerimeter(),2));
            }
        }
    }
}