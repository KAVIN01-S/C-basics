using System; 

namespace Emp{
   public class Employee  
    {  
        public string surName  = "Saravanan";
    }
   class Programmer : Employee  
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
            Programmer p1 = new Programmer();
            p1.Name= "Kavin";  
            p1.Display();  
        }  
    }
}
