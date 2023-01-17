using System;

namespace ConsoleAppDay2Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SbiATM s = new SbiATM() { accno = 12345, amt = 50000, oldpwd = "kiru12", newpwd = "pragi12!" };
            s.withdraw(123, 30000);
            s.changePwd(123, "deepu23", "dp12#");
            s.checkbalance();


        }
    }
}
