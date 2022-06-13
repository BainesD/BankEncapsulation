using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;
        public void Deposit(double deposit)
        {
            _balance += deposit;
        }
        public double GetBalance()
        {
            return _balance;
        }

//In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
//Once finished save, commit, and push back to Github

    }
}
