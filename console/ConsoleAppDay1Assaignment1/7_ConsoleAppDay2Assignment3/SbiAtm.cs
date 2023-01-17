using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay2Assignment3
{
    class SbiATM : ATM
    {
        public int accno { get; set; }
        public double amt { get; set; }
        public string oldpwd { get; set; }
        public string newpwd { get; set; }
        public void withdraw(int no, double a)
        {

            Console.WriteLine("Account number: " + accno + " Balance Amount: " + amt);
        }
        public void changePwd(int no, string old, string new1)
        {

            Console.WriteLine("Account number: " + accno + " Old Password: " + oldpwd + " New Password: " + newpwd);




        }

        public void checkbalance()
        {
            Console.WriteLine("Balance: " + amt);
        }
    }
}
