using System;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user

                Console.WriteLine("Enter a number : ");      // user Insert a number
                int num = int.Parse(Console.ReadLine());
                

                if ((num % 3 == 0 && num % 7 != 0) || (num % 7 == 0 && num % 3 != 0)) // check if it multiple only by 3 or only by 7

                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");


                Console.WriteLine("Press any letter to continue or press E for exit");  // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
