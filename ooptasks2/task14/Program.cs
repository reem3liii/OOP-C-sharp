using System;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();         // clear the screen for the user

                Console.WriteLine("Enter a number : ");      // user Insert a number
                int num = int.Parse(Console.ReadLine());


                if (num % 3 == 0 && num % 5 == 0)   // return the right string according to if it is divisible by 3 or by 5 or both
                    Console.WriteLine("FizzBuzz");
                else if (num % 3 == 0)
                    Console.WriteLine("Fizz");
                else if(num % 5 == 0)
                    Console.WriteLine("Buzz");


                Console.WriteLine("Press any letter to continue or press E for exit");  // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')      // end the loop if the user press exit
                    break;

            }
        }
    }
}
