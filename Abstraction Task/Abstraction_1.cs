using System;

namespace Abstraction
{
    abstract class Parent
    {
        public void message(){}
    }
    
    //abstract class is inherited
    class subClass1 : Parent
    {
        //new keyword is used to hide the base class's message method
        public new void message()
        {
            Console.WriteLine("This is first subclass");
        }
    }

    //abstract class is inherited
    class subClass2 : Parent
    {
        //new keyword is used to hide the base class's message method
        public new void message()
        {
            Console.WriteLine("This is second subclass");
        }
    }

    class Abstraction_1
    {
        public static void main(string[] args)
        {
            //Object created for subClass1
            subClass1 obj_1  = new subClass1();
            obj_1.message();

            //Object created for subClass2
            subClass2 obj_2  = new subClass2();
            obj_2.message();
        }
    }
}