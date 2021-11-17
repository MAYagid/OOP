using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    enum AccType
    {
        Credit,
        Debet
    }

    class BankAccount
    {
        private static int num = 1;
        private int accnum;
        private int balance;
        private AccType accounttype;

        public int AccNum
        {
            get { return accnum; }
            set { accnum = num; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(): this(0, AccType.Debet)
        {
            
        }

        public BankAccount(int Bal, AccType Type)
        {
            accnum = num++;
            balance = Bal;
            accounttype = Type;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Balance: {balance} Number: {accnum}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount(1000, AccType.Debet);
            account1.PrintInfo();
            var account2 = new BankAccount(2000, AccType.Debet);
            account2.PrintInfo();
        }
    }
}
