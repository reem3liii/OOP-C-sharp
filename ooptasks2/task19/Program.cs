using System;

namespace task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)         // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user
                
                int sum = 0;        
                while (sum < 400)   // loop unti sum reaches 400
                {
                    Console.Write("Enter a number : ");
                    sum += int.Parse(Console.ReadLine());   // add the inserted value to sum
                }

                Console.WriteLine("Press any letter to continue or press E for exit");  // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
