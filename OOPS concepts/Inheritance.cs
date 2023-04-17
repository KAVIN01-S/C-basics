using System; 

namespace Employee{
   public class Employee  
    {  
        //surName with default value
        public string surName  = "Saravanan";
    }
   class Employee_details : Employee  
   {
        
        private string firstName;
        public string FirstName
        //getter setter for firstName
        {
            get
            {
                return firstName;
            }
            set{
                firstName = value;
            }
        }
        public void Display()
        {
            //Displaying the First Name with Last Name
            Console.WriteLine("Name : "+name +" "+surName) ;
        }
   }
   class Program
   {  
       public static void Main(string[] args)  
        {  
            //Creating object for Employee_details class
            Employee_details emp = new Employee_details();
            //setting value for name variable
            p1.FirstName= "Kavin";
            //Calling display method in Employee_details class
            p1.Display();  
        }  
    }
}
