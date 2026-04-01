using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{

    class Accounts
    {
        private int Account_no;
        private string Name;
        public string AccountType;
        public string TransactionType;
        public double Amount;
        public double Balance;
        public void Data()
        {
            Console.WriteLine("Enter the Account_no : ");
            Account_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Account Type : ");
            AccountType = Console.ReadLine();
            Console.WriteLine("Enter the amount : ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Balance : ");
            Balance = Convert.ToDouble(Console.ReadLine());
            //if(TransactionType == "Credit")
            //{
            //    Transaction.Credit
            //}
        }
        public void Display()
        {
            Console.WriteLine("Account_no : " + Account_no);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Account Type : " + AccountType);
            Console.WriteLine("Transaction Type : " + TransactionType);
            Console.WriteLine("Amount : " + Amount);
        }
    }

    class Transaction : Accounts
    {
        //Accounts ac = new Accounts();
        public void Credit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Total Balance : " + Balance);
        }

        public void Debit(double amount)
        { 
            Balance -= amount;
            Console.WriteLine("Total Balance : " + Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction accounts = new Transaction();
            accounts.Data();
            Console.WriteLine("Enter the Transaction Type : ");
            accounts.TransactionType = Console.ReadLine();
            accounts.Display();
            if (accounts.TransactionType == "Credit" || accounts.TransactionType== "credit")
            {
                
                accounts.Credit(accounts.Amount);
            }
            else if(accounts.TransactionType == "Debit" || accounts.TransactionType == "debit")
            {
                accounts.Debit(accounts.Amount);
            }
            else
            {
                Console.WriteLine("Select the correct Transaction Type..");
            }
        }
    }
}
