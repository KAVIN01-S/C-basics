using System;
using System.Collections;

namespace Bank
{
    abstract class Accounts
    {
        public int customer_id=0;
        public double balance{get;set;}
        public double interestRate{get;set;}
        public int givenPeriod;
        public abstract void calculateInterest(double period);
        public abstract void depositing(double amt);
        public virtual void withdrawing(double amt){}

    }

    //abstract class is inherited 
    class DepositAccounts : Accounts
    {
        public DepositAccounts()
        {
            base.customer_id = ++customer_id;
            base.balance = 0;
            base.interestRate = 7.5D;
        }
        //implementation of abstract method
        public override void calculateInterest(double period)
        {
            if(base.balance<1000 && base.balance>0)
            {
                Console.WriteLine("No Interest rate for this account because balance amount is less than required amount");
            }
            else
            {
                Console.WriteLine("The Interest for givern period : {0}",(base.balance*period*base.interestRate)/100);
            }
        }
        //implementation of abstract method
        public override void depositing(double amount)
        {
            base.balance += amount;
        }
        //method withdrawing is overriden
        public override void withdrawing(double amount)
        {
            base.balance-=amount;
        }
    }
    //abstract class is inherited here
    class LoanAccounts : Accounts
    {   
        public override void calculateInterest(double period){}
        public override void depositing(double amt){}
    }
    //class for Individual account
    class LoanIndividuals : LoanAccounts 
        {
            public LoanIndividuals()
            {
                base.balance = 0;
                base.interestRate = 6.5D;
            }
            public override void calculateInterest(double period)
            {
                if(period<=3)Console.WriteLine("No Interest rate for this account because balance amount is less than required amount"); 
                else
                {
                    Console.WriteLine("The Interest for givern period : {0}",(base.balance*period*base.interestRate)/100);
                }               
            }
            public override void depositing(double amount)
            {
                base.balance += amount;
            }
        }
        //class for Company account
        class LoanCompanies : LoanAccounts
        {
            public LoanCompanies()
            {
                base.balance = 0;
                base.interestRate = 6.5D;
            }
            public void calculateInterest(double period)
            {
                if(period<=2)Console.WriteLine("No Interest rate for this account because balance amount is less than required amount"); 
                else
                {
                    Console.WriteLine("The Interest for givern period : {0}",(base.balance*period*base.interestRate)/100);
                }    
            }
            public override void depositing(double amount)
            {
                base.balance += amount;
            }
        }

    //class for Mortgage Accounts 
    class MortgageAccounts : Accounts
    {
        public override void calculateInterest(double period){}
        public override void depositing(double amt){}
    }
    //class for Individual Mortgage Account
    class Individuals : MortgageAccounts
    {
        public Individuals()
            {
                base.balance = 0;
                base.interestRate = 6.5D;
            }
            public override void calculateInterest(double period)
            {
                if(period<=6)Console.WriteLine("No Interest rate for this account because balance amount is less than required amount"); 
                else
                {
                    Console.WriteLine("The Interest for givern period : {0}",(base.balance*period*base.interestRate)/100);
                }               
            }
            public override void depositing(double amount)
            {
                base.balance += amount;
            }
    }
    ////class for Company Mortgage Account
    class Companies : MortgageAccounts
    {
        public Companies()
            {
                base.balance = 0;
                base.interestRate = 6.5D;
            }
            public override void calculateInterest(double period)
            {
                if(period<=12)Console.WriteLine("The Interest for givern period : {0}",((base.balance*period*base.interestRate)/100)/2); 
                else
                {
                    Console.WriteLine("The Interest for givern period : {0}",(base.balance*period*base.interestRate)/100);
                } 
            }
            public override void depositing(double amount)
            {
                base.balance += amount;
            }
    }
    class MainMethod 
    {
        public static void Main(string[] args)
        {
            //Object creation for DepositAccount class
            DepositAccounts obj_depositAccount = new DepositAccounts();

            //reference given to LoanAccounts
            LoanAccounts loan_individualAccount;

            //reference given to MortgageAccounts
            MortgageAccounts mortgage_individualAccount;

            start:
            Console.WriteLine("Choose an account :\n1) Deposit Account\n2) Loan Account\n3) Montgage Account");

            //Reading which type of account
            int option = Convert.ToInt32(Console.ReadLine());
            if(option==1)
            {
                Console.WriteLine("Choose one option\n-----------------\n1) Balance Enquiry\n2) Deposit amount\n3) Withdraw Amount\n4) Calculate Interest rate");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Balance amount : {0}",obj_depositAccount.balance);
                        break;
                    case 2:
                        Console.Write("Enter the amount to deposit : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        //depositing method is called
                        obj_depositAccount.depositing(amount);
                        Console.WriteLine("Amount Depsoited Successfully!!\n");
                        break;
                    case 3:
                        Console.Write("Enter the amount to withdraw : ");
                        double amount1 = Convert.ToDouble(Console.ReadLine());
                        //withdrawing method is called
                        obj_depositAccount .withdrawing(amount1);
                        Console.WriteLine("Amount withdrawn successfully");
                        break;
                    case 4:
                        Console.Write("Enter the period (in months) : ");
                        double no_of_months = Convert.ToDouble(Console.ReadLine());
                        //calculateInterest method is invoked
                        obj_depositAccount.calculateInterest(no_of_months);
                        break;
                }
            }
            else if(option==2)
            {
                Console.WriteLine("1) Individual\n2) Company");
                int y = Convert.ToInt32(Console.ReadLine());
                if(y==1)
                {
                    //LoanIndividuals constructor is called
                    loan_individualAccount = new LoanIndividuals();
                }
                else
                {
                    //LoanCompanies constructor is called
                    loan_individualAccount = new LoanCompanies();
                }
                Console.WriteLine("Choose one option\n-----------------\n1)Balance Enquiry\n2)Deposit Amount\n3)Calculate rate of Interest");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Balance Amount : {0}",loan_individualAccount.balance);
                        break;
                    case 2:
                        Console.Write("Enter Amount to deposit : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        loan_individualAccount.depositing(amount);
                        Console.WriteLine("Amount Depsoited Successfully!!\n");
                        break;
                    case 3:
                        Console.Write("Enter the period (in months) : ");
                        double no_of_months = Convert.ToDouble(Console.ReadLine());
                        loan_individualAccount.calculateInterest(no_of_months);
                        break;
                }
            }
            else if(option==3)
            {
                
                Console.WriteLine("1) Individual\n2) Company");
                int y = Convert.ToInt32(Console.ReadLine());
                if(y==1)
                {
                    //
                    mortgage_individualAccount = new Individuals();
                }
                else
                {
                    mortgage_individualAccount = new Companies();
                }
                Console.WriteLine("Choose one option\n-----------------\n1)Balance Enquiry\n2)Deposit Amount\n3)Calculate rate of Interest");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Balance Amount : {0}",mortgage_individualAccount.balance);
                        break;
                    case 2:
                        Console.Write("Enter Amount to deposit : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        mortgage_individualAccount.depositing(amount);
                        Console.WriteLine("Amount Depsoited Successfully!!\n");
                        break;
                    case 3:
                        Console.Write("Enter the period (in months) : ");
                        double no_of_months = Convert.ToDouble(Console.ReadLine());
                        mortgage_individualAccount.calculateInterest(no_of_months);
                        break;
                }
            }
            //if 1 is entered flow of control goes to starting point 
            //else the program finishes its execution
            Console.Write("Want to continue transaction??\n1)YES\n2)NO ?? ");
            int value = Convert.ToInt32(Console.ReadLine());
            if(value ==1)goto start;
            else Console.WriteLine("                   Thank You !\n                   Visit Again !!");
        }
    }
}