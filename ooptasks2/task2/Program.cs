using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)    // infinity loop until user exit
            {
                Console.Clear();    // clear the screen for the user

                Console.WriteLine("Enter a number : ");     // user insert a number
                int num = int.Parse(Console.ReadLine());

                if (num > 51)   // check if the number greater than 51

                    Console.WriteLine(Math.Abs(num - 51) * 3);      // return triple of the absolute difference 

                else
                    Console.WriteLine(Math.Abs(51 - num));      // return the normal absolute difference

                Console.WriteLine("Press any letter to continue or press E for exit");     // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
            
        }
    }
}
