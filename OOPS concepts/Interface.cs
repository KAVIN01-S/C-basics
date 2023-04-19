namespace OopsConcepts
{
    //Example class for Interface
    interface IStudent
    {
        void Display();
    }
    
    interface IStudent1
    {
        void gatherDetails();
    }

    //IStudent and IStudent1 interface is inherited 
    class Interface_2 : IStudent, IStudent1
    {
        public string? name{get;set;}
        public string? dob{get;set;}

        public int id{get;set;}

        public string? placeOfBirth{get;set;}
        //method in interface is declared here
        public void Display()
        {
            Console.WriteLine("   Personal Details");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Name           :"+name);
            Console.WriteLine("DOB            :" +dob);
            Console.WriteLine("ID             :" +id);
            Console.WriteLine("Place Of Birth :"+placeOfBirth);
        }

        public void gatherDetails()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter dob");
            dob = Console.ReadLine();
            Console.WriteLine("Enter ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Place of birth");
            placeOfBirth = Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            //Object creation for class Interface_2
            Interface_2 obj = new Interface_2();
            //calling gatherDetails method
            obj.gatherDetails();
            //calling Display method
            obj.Display();
        }
    }
}
