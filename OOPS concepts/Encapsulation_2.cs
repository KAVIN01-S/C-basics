using System;

namespace Details
{
    //Class User to set location and name string values
    class User
    {
       private string location;
       private string name;
       public string Location
       //getter setter method for private string location
       {
          get
          {
             return location;
          }
          set
          {
             location = value;
          }
       }
       //getter setter method for private string name
       public string Name
       {
         get
         {
             return name;
         }
         set
         {
            name = value;
         }
       }
    }
    class Program
    {
       static void Main(string[] args)
       {
          //Object creation for User class
          User u = new User();
          Console.WriteLine("Enter the name:");
          // set accessor will invoke
          u.Name = Console.ReadLine();
          Console.WriteLine("Enter the Location:");
          // set accessor will invoke
          u.Location = Console.ReadLine();
          // get accessor will invoke
          Console.WriteLine("Details");
          Console.WriteLine("--------------------------");
          Console.WriteLine("Name      : " + u.Name);
          // get accessor will invoke
          Console.WriteLine("Location  : " + u.Location);
       }
    }
}
