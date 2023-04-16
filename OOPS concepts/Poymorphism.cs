using System; 

//Polymorphism

namespace Emp{
   class Person_1 
    {  
        public virtual void Display()
        { 
            Console.WriteLine("Hi I'm person_1");
        }
    }
    //Person2 is inherited from Person_1
    class Person_2 : Person_1  
   { 
        public override void Display()
        { 
            Console.WriteLine("Hi I'm person_2");
        }
   }
   //Person3 is inherited from Person_2
   class Person_3: Person_1
   {
        public override void Display()
        { 
            Console.WriteLine("Hi I'm person_3");
        }
   }
   class Program
   {  
       public static void Main(string[] args)  
        {  
            //Object for Person_1 class
            Person_1 p1 = new Person_1();

            //Object for Person_2 class
            Person_1 p2 = new Person_2();

            //Object for Person_3 class
            Person_1 p3 = new Person_3();

            p1.Display();
            p2.Display();
            p3.Display();
        }  
    }
}
