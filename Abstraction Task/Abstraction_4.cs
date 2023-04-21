using System;

//Program to print the percentage of marks
namespace Abstraction
{
    abstract class Marks
    {
        public abstract float getPercentage();
    }

    //abstract class Marks ois inherited here
    class StudentA : Marks
    {
        float subject_1,subject_2,subject_3; 
        public StudentA(int subject_1,int subject_2,int subject_3)
        {
            this.subject_1 = subject_1;
            this.subject_2 = subject_2;
            this.subject_3 = subject_3;
        }
        public override float getPercentage()
        {
            return (float) (subject_1+subject_2+subject_3)/3;
        }
    }

    //StudentB class contains fileds and methods
    class StudentB : Marks
    {
        float subject_1,subject_2,subject_3,subject_4;
        public StudentB(int subject_1,int subject_2,int subject_3,int subject_4)
        {
            //assigning values for the fields
            this.subject_1 = subject_1;
            this.subject_2 = subject_2;
            this.subject_3 = subject_3;
            this.subject_4 = subject_4;
        }
        //abstract method getPercentage is implemented here
        public override float getPercentage()
        {
            return (float) (subject_1+subject_2+subject_3+subject_4)/4;
        }
    }

    class Percentage
    {
        public static void main(string[] args)
        {
            Console.WriteLine("       Student A\n-----------------------\nEnter marks of Subject_1 :");
            int mark_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject_2 :");
            int mark_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject_3 :");
            int mark_3 = Convert.ToInt32(Console.ReadLine());

            //Object instatiated for StudentA class and the constructor is called
            StudentA stud_A = new StudentA(mark_1,mark_2,mark_3);
            
            //Reading the marks from the user
            Console.WriteLine("       Student B\n---------------------------\nEnter marks of Subject_1 :");
            mark_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject_2 :");
            mark_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject_3 :");
            mark_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject_4 :");
            int mark_4 = Convert.ToInt32(Console.ReadLine());

            //Object instatiated for StudentB class and the constructor is called
            StudentB stud_B = new StudentB(mark_1,mark_2,mark_3,mark_4);

            //Displaying Percentage
            Console.WriteLine("The percentage of StudentA is {0}",Math.Round(stud_A.getPercentage(),2));
            Console.WriteLine("The percentage of StudentB is {0}",Math.Round(stud_B.getPercentage(),2));
        }
    }
}