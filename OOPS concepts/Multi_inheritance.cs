using System;

//HIERARCHICAL inheritance

namespace EmpLoyeeDetails
{
   //Employee class which stores surName
   public class Employee  
    {  
        //surName with default value
        public string surName  = "Saravanan";
    }
    //Emp_1 is inherited from Employee
    class Employee_1 : EmpLoyeeDetails
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
   //Emp_2 is inherited from Employee
   class Employee_2: EmpLoyeeDetails
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
   //Emp_3 is inherited from Employee
   class Employee_3 : EmpLoyeeDetails
    { 
        private string name;
        //To assign a value for private string name
        public string Name
        { 
            get{
                return name;
            } 
            set{
                name = value;
            }
        }
        //Diplay the name with surName
        public void Display()
        {
            Console.WriteLine("Name : "+name +" "+surName) ;
        }
   }
   public class Program
   {  
      
       public static void Main(string[] args)  
        {  
            //Object creation for Employee_1 class
            Employee_1 p1 = new Employee_2();
          
            //Object creation for Employee_2 class
            Employee_2 p2 = new Employee_2();
            
            //Object creation for Employee_3 class
            Employee_3 p2 = new Employee_3();
          
            //setter method gets invoked in Employee_1 class 
            p1.Name= "Kavin";  
            //setter method gets invoked in Employee_2 class
            p2.Name = "Abinav";
            //setter method gets invoked in Employee_3 class
            p3.Name = "Ram";
            
            //Caling Display method
            p1.Display(); 
            p2.Display();
            p3.Display();
        }  
    }
}
