using System; 

//MULTIPLE inheritance

namespace Emp{
   class Employee  
    {  
        public string surName  = "Saravanan";
    }
    //Programmer1 is inherited from Employee
    class Programmer1 : Employee  
   { 
        private string name;
        public string Name
        { 
            get{
                return name;
            } 
            set{
                name = value;
            }
        }
        public void Display(){
            Console.WriteLine("Name : "+name +" "+surName) ;
        }
   }
   //Programmer2 is inherited from Employee
   class Programmer2: Employee
   {
        private string name;
        public string Name
        { 
            get{
                return name;
            } 
            set{
                name = value;
            }
        }
        public void Display(){
            Console.WriteLine("Name : "+name +" "+surName) ;
        }
   }
   class Program
   {  
       public static void Main(string[] args)  
        {  
            //Object for Programmer1 class
            Programmer1 p1 = new Programmer1();

            //Object for Programmer2 class
            Programmer2 p2 = new Programmer2();

            p1.Name= "Kavin";  
            p2.Name = "Abinav";
            p1.Display(); 
            p2.Display();
        }  
    }
}
