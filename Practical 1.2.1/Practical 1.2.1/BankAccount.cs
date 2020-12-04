using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1._2._1
{
    class BankAccount
    {
        private string client;
        private int accountNo;
        private double balance;




        public void InitializeBankAccount(string newClient, int newAccountNo)
        {
            accountNo = newAccountNo;
            client = newClient;
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                balance += amount;
            }
        }

        public bool Whitdraw(double amount)
        {
            if (amount > 0 && balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getAccInfo()
        {
            return "Client " + client + "(" + accountNo.ToString() + ") : " + balance.ToString() + "€";
        }
    }
}