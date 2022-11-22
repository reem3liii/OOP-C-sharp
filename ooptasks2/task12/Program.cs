using System;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user

                Console.WriteLine("Enter 2 numbers : ");    // user Insert 2 numbers
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (num1==5||num2==5||num1+num2==5||Math.Abs(num1-num2)==5) // check if one of them = 5 or their sum or their diff = 5

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
