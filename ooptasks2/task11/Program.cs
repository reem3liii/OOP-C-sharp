using System;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();         // clear the screen for the user

                Console.WriteLine("Enter string: ");        // user insert string
                string word = Console.ReadLine();
                Console.WriteLine("Enter number: ");        // insert the number of repetitions
                int num = int.Parse(Console.ReadLine());

                for(int i = 0; i < num;i++)     // for loop to print the copies
                {
                    Console.Write(word);
                }

                Console.WriteLine();


                Console.WriteLine("Press any letter to continue or press E for exit");   // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')      // end the loop if the user press exit
                    break;

            }
        }
    }
}
