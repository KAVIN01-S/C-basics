using System;

namespace Abstraction
{
    abstract class Animals
    {
        //abstract methods are declared here
        public abstract void cats();
        public abstract void dogs();

    }
    class Cats: Animals
    {
        //abstract methods are implemented here
        public override void dogs(){}

        public override void cats()
        {
            Console.WriteLine("Cats meow");
        }
    }
    class Dogs : Animals
    {
        //abstract methods cats and dogs are implemented here
        public override void cats(){}
        public override void dogs()
        {
            Console.WriteLine("Dogs bark");
        }
    }
    class MainClass1
    {
        public static void Main(string[] args)
        {
            //Object instatiation for Cats class
            Cats objectCats = new Cats();
            objectCats.cats();
            //Object instatiation for Dogs class
            Dogs objectDogs = new Dogs();
            objectDogs.dogs();
        }
    }
}