    using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount();
            int response;
            do
            {
                Console.WriteLine("Hello! What would you like to do today? \n1 - Deposit\n2 - Get Balance\n3 - Sign Out");
                var userInput = int.TryParse(Console.ReadLine(), out response);

                if (!userInput)
                {
                    do
                    {
                        Console.WriteLine("I'm sorry. That is not a valid response. Please try again. \nYour options are:\n1 - Deposit \n2- Get Balance\n3 - Sign Out");
                        userInput = int.TryParse(Console.ReadLine(), out response);
                    }
                    while (!userInput);
                }
                if (response == 1)
                {
                    Console.WriteLine("How much will you be depositing today?");
                    var userDeposit = Double.TryParse(Console.ReadLine(), out double responseDeposit);
                    if (!userDeposit)
                    {
                        do { Console.WriteLine("I'm sorry that is not a valid amount. Please enter a valid amount.");
                            userDeposit = Double.TryParse(Console.ReadLine(), out responseDeposit);
                            userAccount.Deposit(responseDeposit);
                        }
                        while (!userDeposit);
                    }
                    else
                        userAccount.Deposit(responseDeposit);

                }
                else if (response == 2)
                {
                    Console.WriteLine($"Your account balance is {userAccount.GetBalance()}.");
                
                }
            }
            while (response != 3);
            Console.WriteLine("Thank you for your patronage. Have a nice day!");
        }
    }
}
