using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)         // infinity loop until user exit
            {
                Console.Clear();         // clear the screen for the user

                Console.WriteLine("Enter 3 numbers : ");     // user Insert 3 number
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());

                if ((num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50))  // check if at least one of the numbers is in range [20 .. 50]

                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");


                Console.WriteLine("Press any letter to continue or press E for exit");      // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
