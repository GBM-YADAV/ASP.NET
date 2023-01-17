using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay2Assignment3
{
    public interface ATM
    {
        public void withdraw(int accountNumber, double amount);
        public void changePwd(int accountNumber, String oldPassword, String newPassword);
        public void checkbalance();
    }
}
