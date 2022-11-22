using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Account
    {
        public double Balance { get; set; }
        public virtual double GetBalance() { return Balance; }
        public virtual void Credit( double num)
        {
            Balance += num;
            Console.WriteLine("Credit done successfully");
            Console.WriteLine($"Your balance now = {GetBalance()}");
            Console.WriteLine("--------------------------------");
        }
        public virtual void  Debit(double num)
        {
            if (num > Balance)
                Console.WriteLine("Debit amount axceeded account balance");
            else
            {
                Balance -= num;
                Console.WriteLine("Debit done successfully");
                Console.WriteLine($"Your balance now = {GetBalance()}");
                Console.WriteLine("--------------------------------");
            }
            
        }
        public Account(double _balance)
        {
            Balance = _balance;
        }
    }
}
