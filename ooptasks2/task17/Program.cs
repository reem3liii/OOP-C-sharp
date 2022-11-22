using System;

namespace task17
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
                Console.WriteLine($"The multiplication table of {num} :");

                for(int i = 1; i <= 12;i++)     // print the mutiplication table by a loop
                {
                    Console.WriteLine($"{num}*{i}={num * i}");
                }


                Console.WriteLine("Press any letter to continue or press E for exit"); // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
