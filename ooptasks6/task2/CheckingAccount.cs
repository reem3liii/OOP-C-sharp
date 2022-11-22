using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class CheckingAccount : Account
    {
        public double Fee { get; set; }
        public override void Debit(double num)
        {
            if (num > Balance)
            {
                Balance -= Fee;
                Console.WriteLine("Debit amount axceeded account balance");
            }
            else
            {
                Balance -= num;
                Balance -= Fee;
                Console.WriteLine("Debit done successfully");
                Console.WriteLine($"Your balance now = {Balance}");
                Console.WriteLine("--------------------------------");
            }
        }
        public override void Credit(double num)
        {
            Balance += num;
            Balance -= Fee;
            Console.WriteLine("Credit done successfully");
            Console.WriteLine($"Your balance now = {Balance}");
            Console.WriteLine("--------------------------------");
        }
        public CheckingAccount(double _fee, double _balance) : base(_balance)
        {
            Fee= _fee;    
        }
      
        
    }
}
