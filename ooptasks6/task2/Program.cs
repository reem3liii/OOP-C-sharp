using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        public static void Menu(Account account)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("a- Credit");
                Console.WriteLine("b- Debit");
                Console.WriteLine("c- Show Current Balance");
                Console.WriteLine("d- Exit");
                Console.WriteLine("--------------------------------");

                Console.Write("Please choose : ");
                char choice = char.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                double amount = 0;
                switch (choice)
                {
                    case 'a':
                        Console.Write("Enter amount : ");
                        amount = double.Parse(Console.ReadLine());
                        account.Credit(amount);
                        break;
                    case 'b':
                        Console.Write("Enter amount : ");
                        amount = double.Parse(Console.ReadLine());
                        account.Debit(amount);
                        break;
                    case 'c':
                        Console.Write($"Your Current Balance = {account.GetBalance():C} ");
                        break;
                    case 'd':
                        return;
                    default:
                        Console.WriteLine("Wrong choice, please enter correct one!");
                        break;

                }
                Console.ReadKey();


            }
        }
        static void Main(string[] args)
        {
            Account firstAccount = new SavingsAccount(20, 20000);
            Account secondAccount = new CheckingAccount(4, 8000);

            //Menu(firstAccount);     //Saving Account
            Menu(secondAccount);      //Checking Account

        }
    }
}
