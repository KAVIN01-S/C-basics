using System;


namespace Abstraction
{
    abstract class AbstractClass
    {
        //Displays the statement
        public AbstractClass()
        {
            Console.WriteLine("This is constructor of abstract class");
        }
        //declaration of abstract method
        public abstract void a_method();
        public void b_method()
        {
            Console.WriteLine("This is a normal method of abstract class");
        }
    }
        
        class SubClass : AbstractClass
        {
            //implementation of abstract metho
            public override void a_method()
            {
                Console.WriteLine("This is abstract method");
            }
        }
    
    class MainClass
        {
            public static void main(string[] args)
            {
                //AbstractClass's Constructor is called
                SubClass obj_subClass = new SubClass();

                //calling the abstract method
                obj_subClass.a_method();

                //calling the non abstract method
                obj_subClass.b_method();
            }
        }
}