using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("************Welcome to my bank!*******************");

            while(true)
            { 
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Print all accounts");
            Console.WriteLine("Please select a choice from the above");
            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting the bank!");
                    return;
                case "1":
                    Console.Write("Email Address: ");
                    var emailAddress = Console.ReadLine();
                    Console.Write("Type of account: ");
                    var typeOfAccount = Console.ReadLine();
                    Console.Write("Amount: ");
                    var amount = Convert.ToDecimal(Console.ReadLine());

                    var account = Bank.CreateAccount(emailAddress, amount, typeOfAccount);
                    Console.WriteLine($"AccountNumber: {account.AccountNumber}, Type: { account.TypeOfAccount}, Balance: { account.Balance:C}, Email Address: { account.EmailAddress}");

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;


                default:
                    break;
            }


                //var account = Bank.CreateAccount("test@test.com", 100, "Saving");
                //creat instance class
                // var account = new Account("test@test.com", "Checking");
                //account.AccountNumber = 1;
                // account.EmailAddress = "test@test.com";
                //account.Balance = 10000000000;
                //  account.TypeOfAccount = "Checking";
                //account.Deposit(150.00M);
                //Console.WriteLine($"AccountNumber: {account.AccountNumber}, Type: { account.TypeOfAccount}, Balance: { account.Balance:C}, Email Address: { account.EmailAddress}");

                //var account2 = Bank.CreateAccount("test2@test2.com", 200, "Checking");

                ////var account2 = new Account();
                ////account2.EmailAddress = "test2@test.com";
                ////account2.TypeOfAccount = "Savings";
                //Console.WriteLine($"AccountNumber: {account2.AccountNumber}, Type: { account2.TypeOfAccount}, Balance: { account2.Balance:C}, Email Address: { account2.EmailAddress}");
            }
        }
    }
}
