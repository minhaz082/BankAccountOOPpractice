using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAccountOOPApp
{
    class Account
    {
        public string accountNumber;
        public string customerName;
        public double balance;
        public double amount;

        public double withdrawMoney(double amount)
        {
              balance -= amount;
        }

        public double depositMoney(double amount)
        {
            balance = +amount;
        }
    }
}
