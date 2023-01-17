using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppDay2Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 113213, 50000, "SDFF@!", "ASDW@2" };
            //list.Add(new ArrayList() { accno}
            InMemoryAccountDaoImp inm = new InMemoryAccountDaoImp();
            Console.WriteLine(inm);
            InMemoryAccountDaoImp nm = new InMemoryAccountDaoImp();
            inm.withdraw(21342, 10000);
            inm.checkbal(20000.0f, 5000);
            inm.changepwd(21342, "sdfgh2", "asdfv*");
            inm.getAccDetails(21342);


        }
    }

    public interface AccountDao
    {
        public void addAnAcc(AccountDao Account);
        public void withdraw(int accno, double amt);
        public void checkbal(double balance, double amt);
        public void changepwd(int accno, string oldpwd, string newpwd);
        public void getAccDetails(int accno);


    }
    internal class Account
    {

        static public String BankName = "State Bank Of India";

        public long accountNo { get; set; }

        public float accountBalance { get; set; }

        public String accountPassword { get; set; }

        public Account()
        {
            accountNo = 99631914228;
            accountBalance = 19000.45f;
            accountPassword = "Giri@12Babu@123";

        }
        public Account(long accountNo, float accountBalance, string accountPassword)
        {
            this.accountNo = accountNo;
            this.accountBalance = accountBalance;
            this.accountPassword = accountPassword;
        }


        public virtual void display()
        {
            Console.WriteLine("\nBank Name         :" + Account.BankName);
            Console.WriteLine("\naccountNo        :" + accountNo);
            Console.WriteLine("\naccountBalance   :" + accountNo);
            Console.WriteLine("\naccountPassword  :" + accountNo);
        }
    }

    class InMemoryAccountDaoImp : AccountDao
    {
        public int accno { get; set; }
        public double amt { get; set; }
        public string oldpwd { get; set; }
        public string newpwd { get; set; }
        public double balance { get; set; }

        public void addAnAcc(AccountDao Account)
        {
            Console.WriteLine("Account number to be added: " + Account);
        }
        public void withdraw(int accno, double amt)
        {
            Console.WriteLine("Account Number: " + accno + " Withdraw amount: " + amt);
        }
        public void checkbal(double balance, double amt)
        {
            Console.WriteLine("Total Balance before withdrawl: " + balance);
            balance = balance - amt;
            Console.WriteLine(" Balance after withdrawl: " + balance);

        }
        public void changepwd(int accno, string oldpwd, string newpwd)
        {
            Console.WriteLine("Account Number: " + accno + " Old Password: " + oldpwd + " New Password: " + newpwd);
        }

        public void getAccDetails(int accno)
        {
            Console.WriteLine("Account Number: " + accno);
        }



    }
}

