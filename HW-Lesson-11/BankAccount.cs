using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_11
{
    class BankAccount
    {
        private string bankName;
        private long accountNumber;
        private double balance;

        public BankAccount(string bankName, long accountNumber, double balance)
        {
            this.bankName = bankName;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void WithdrawOrDeposit(double add)
        {
            this.balance += add;
        }
        public string GetAccountDetails()
        {
            string a = "Bank name: " + this.bankName + ". Account number: " + this.accountNumber;
            return a;
        }
    }
}
