using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456", 1000);
            account.Deposit(500);
            account.Withdraw(111300);
            Console.WriteLine(account.Balance); 

        }

        class BankAccount 
        { 
        private string AccountNumber {  get; set; }
        public double Balance {  get; private set; }

            public BankAccount(string AccountNumber, double Balance)
            {
                this.AccountNumber = AccountNumber;
                this.Balance = Balance; 
                
            }

            public void Deposit(int amount) 
            {
                Balance += amount; 
            }

            public void Withdraw(int amount) 
            { 
                Balance -= amount;

                if (Balance < 0) 
                {
                    Balance += amount;
                    Console.WriteLine("Операция невозможна, на карте недостаточно средств");
                }
            }

        }
    }
}
