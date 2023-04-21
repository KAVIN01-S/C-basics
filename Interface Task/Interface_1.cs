using System;

namespace Inheritance
{
    interface Stall
    {
        public void Display();
    }
    class GoldStall : Stall
    {
        //fields of this class is made as private
        private string stallName;
        private int cost;
        private string ownerName;
        private int tvSet;

        
        public GoldStall(){}
        //parameterized Constructor
        public GoldStall(string stallName, int cost, string ownerName, int tvSet)
        {
            //Assigning values for the fields of this class
            this.stallName= stallName;
            this.cost = cost;
            this.ownerName = ownerName;
            this.tvSet = tvSet;
        }

        //method in interface is implemented
        public void Display()
        {
            Console.WriteLine("Stall Name :{0}",stallName);
            Console.WriteLine("Cost :{0}",cost);
            Console.WriteLine("ownerName :{0}",ownerName);
            Console.WriteLine("tvSet :{0}",tvSet);
        }
    }

    //interface Stall is implemented
    class PremiumStall : Stall
    {
        private string stallName;
        private int cost;
        private string ownerName;
        private int projector;
        public PremiumStall(){}
        public PremiumStall(string stallName,int cost,string ownerName,int projector)
        {
            //Assigning values for the fileds of this class
            this.stallName= stallName;
            this.cost = cost;
            this.ownerName = ownerName;
            this.projector = projector;
        }
        //method in interface is implemented
        public void Display()
        {
            Console.WriteLine("Stall Name :{0}",stallName);
            Console.WriteLine("Cost :{0}",cost);
            Console.WriteLine("ownerName :{0}",ownerName);
            Console.WriteLine("Projector :{0}",projector);
        }
    }

    //interface Stall is implemented
    class ExecutiveStall : Stall
    {
        private string stallName;
        private int cost;
        private string ownerName;
        private int screen;
        public ExecutiveStall(string stallName,int cost,string ownerName,int screen)
        {
            //assigning values for the fields of this class
            this.stallName= stallName;
            this.cost = cost;
            this.ownerName = ownerName;
            this.screen = screen;
        }
        //method in interface is implemented
        public void Display()
        {
            Console.WriteLine("Stall Name :{0}",stallName);
            Console.WriteLine("Cost :{0}",cost);
            Console.WriteLine("ownerName :{0}",ownerName);
            Console.WriteLine("Screen :{0}",screen);
        }
    }

    class MainClass
    {
        public static void main(string[] args)
        {
            starthere:
            Console.WriteLine("ChooseStall Type\n1)Gold Stall\n2)Premium Stall\n3)Executive Stall");

            //input from 1 to 3
            int option = Convert.ToInt32(Console.ReadLine());
            
            if(option==1)
            {
                Console.WriteLine("Enter Stall details comma seperated(Stall Name,Stall Cost,Owner Name,Number of TV sets)");
                string str = Console.ReadLine();
                var array = str.Split(",");
                string stallName=array[0];
                int cost=Convert.ToInt32(array[1]);
                string ownerName=array[2];
                int tvSet=Convert.ToInt32(array[3]);
                //GoldStall constructor is called
                GoldStall obj_goldStall = new GoldStall(stallName,cost,ownerName,tvSet);
                obj_goldStall.Display();
            }
            else if(option==2)
            {
                Console.WriteLine("Enter Stall details comma seperated(Stall Name,Stall Cost,Owner Name,Number of Projectors)");
                string str = Console.ReadLine();
                var array = str.Split(",");
                string stallName=array[0];
                int cost=Convert.ToInt32(array[1]);
                string ownerName=array[2];
                int Projectors=Convert.ToInt32(array[3]);
                //PremiumStall constructor is called
                PremiumStall obj_premiumStall = new PremiumStall(stallName,cost,ownerName,Projectors);
                obj_premiumStall.Display();
            }
            else if(option==3)
            {
                Console.WriteLine("Enter Stall details comma seperated(Stall Name,Stall Cost,Owner Name,Number of Screens)");
                string str = Console.ReadLine();
                var array = str.Split(",");
                string stallName=array[0];
                int cost=Convert.ToInt32(array[1]);
                string ownerName=array[2];
                int Screens=Convert.ToInt32(array[3]);
                //ExecutiveStall constructor is called
                ExecutiveStall obj_executiveStall = new ExecutiveStall(stallName,cost,ownerName,Screens);
                obj_executiveStall.Display();
            }
            else
            {
                Console.WriteLine("Enter a valid number!!!\n\n");
                //flow of control goes to the start
                goto starthere;
            }
        }
    }
}