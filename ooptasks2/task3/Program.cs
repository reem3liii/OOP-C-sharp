using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user

                Console.WriteLine("Enter 2 numbers : ");        // user Insert 2 number
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (num1 == 30 || num2 == 30 || num1 + num2 == 30)  // check if one of the numbers = 30 or their sum = 30

                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");

                Console.WriteLine("Press any letter to continue or press E for exit");   // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }

            
        }
    }
}
