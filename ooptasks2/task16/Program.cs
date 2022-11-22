using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user

                Console.WriteLine("Enter 3 numbers : ");      // user Insert 3 numbers
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = int.Parse(Console.ReadLine());

                if (y>x&& z>y)      // check if the numbers in ascending order

                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");


                Console.WriteLine("Press any letter to continue or press E for exit");   // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')      // end the loop if the user press exit
                    break;

            }
        }
    }
}
