using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public delegate void MyDelegate();
    public class Bank
    {
        private double balance;
        public event MyDelegate LowBal;
        public event MyDelegate ZeroBal;
        public Bank()
        {
            balance =5000;
        }
        public void Debit(double debit)
        {
            if(balance == 0)
            {
                ZeroBal();
            }
            else if(balance <debit)
            {
                LowBal();
            }
            else
            {
                balance=balance-debit;
            }
            Console.WriteLine($"Current balance {balance}");
        }
    }
    public class Msg
    {
        public void LowBalMsg()
        {
            Console.WriteLine("your account have no debit the amount");
        }
        public void ZeroBalMsg()
        {
            Console.WriteLine("your account has zero balance");
        }
    }
    public class O
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Msg msg = new Msg();
            bank.LowBal+=new MyDelegate(msg.LowBalMsg);
            bank.ZeroBal += new MyDelegate(msg.ZeroBalMsg);
            bank.Debit(7000);
        }
    }
}
