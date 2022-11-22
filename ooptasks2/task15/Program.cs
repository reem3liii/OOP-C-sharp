using System;

namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)     // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user

                Console.WriteLine("Enter 3 numbers : ");         // user Insert 3 numbers
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());

                if (num1+num2==num3 || num2 + num3 == num1 || num1 + num3 == num2) // check if it possible to adding two to get the third

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
