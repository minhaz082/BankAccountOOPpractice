using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAccountOOPApp
{
    class Account
    {
        private string number;
        private string name;
        private double balance;
        //public double amount;

        public string Number
        {
            set
            {
                this.number = value;
                
            }
            get
            {
                return this.number;
            }

        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Balance
        {
            get { return this.name; }
        }











        //public double Setbalance(double balance)
        //{
        //    return balance;
        //}

        //public string SetNumber(string number)
        //{
        //    return number;
        //}
        //public string SetName(string name)
        //{
        //    return name;
        //}

        public double Withdraw(double amount)
        {
              return balance -= amount;
        }

        public double Deposit(double amount)
        {
            return balance = +amount;
        }
    }
}
