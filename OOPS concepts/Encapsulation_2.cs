using System;

namespace Details
{
    class User
    {
       private string location;
       private string name;
       public string Location
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
