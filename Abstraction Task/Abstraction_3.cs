using System;

namespace Abstraction
{
    abstract class Bank
    {
        public abstract int getBalance();
    }
    
    //abstract class Bank is inherited
    class BankA : Bank
    {
        int amount;
        public BankA(int amount)
        {
            //assigning value for the field amount
            this.amount=amount;
        }
        public override int getBalance()
        {
            return amount;
        }
    }
    //abstract class Bank is inherited
    class BankB : Bank
    {
        int amount;
        public BankB(int amount)
        {
            //assigning value for the field amount
            this.amount = amount;
        }
        //abstract method is implemented here
        public override int getBalance()
        {
            return amount;
        }
    }
    class BankC : Bank
    {
        int amount;
        public BankC(int amount)
        {
            //assigning value for the field amount
            this.amount = amount;
        }

        //abstract method is implemented here
        public override int getBalance()
        {
            return amount;
        }
    }
    class BankBalance
    {
        public static void main()
        {
            //Object insatantiation for BankA and BankA constructor is called
            BankA obj_bankA = new BankA(100);

            //Object insatantiation for BankB and BankB constructor is called
            BankB obj_bankB = new BankB(150);

            //Object insatantiation for BankC and BankC constructor is called
            BankC obj_bankC = new BankC(200);

            Console.WriteLine("Balance amount in BankA : ${0}", obj_bankA.getBalance());
            Console.WriteLine("Balance amount in BankB : ${0}", obj_bankB.getBalance());
            Console.WriteLine("Balance amount in BankC : ${0}", obj_bankC.getBalance());
        }
    }
}