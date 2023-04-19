using System.Collections;

namespace OopsConcepts
{
    //Example class for Abstraction
    abstract class Abstraction1
    {
        public string? studName{get;set;}
        public int id = 55;
        public static int number;
        //getter setter for initiializing blood_group
        public string? blood_group{get;set;}
        //Declaration of abstract method
        public abstract void phoneNumber();
        public void bloodGroup()
        {
            Console.WriteLine("Blood Group         :{0}",blood_group);
        }

    }

    //Abstract class is inherited
    class Abstraction_Example : Abstraction1
    {
        public static void main(string[] args)
        {
            //Object created for class Abstraction_Example
            Abstraction_Example ab = new Abstraction_Example();
            ab.studName = "Kavin";

            //static member is assigned using class name
            Abstraction1.number = 987654345;
            Console.WriteLine("Name of the student :" + ab.studName);

            //calling overriden method
            ab.phoneNumber();

            //initializing blood_group value
            ab.blood_group = "A1+";
            ab.bloodGroup();
        }
        
        //abstract method is overriden
        public override void phoneNumber()
        {
            Console.WriteLine("Phone number        :"+Abstraction1.number);
        }
    }
}