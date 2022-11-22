using System;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)         // infinity loop until user exit
            {
                Console.Clear();         // clear the screen for the user

                Console.WriteLine("Enter 2 numbers : ");    // user Insert 2 numbers
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if ((num1 >= 20 && num1 <= 30) && (num2 >= 20 && num2 <= 30)) // check if both in range [20 .. 30]
                {
                    if (num1 >= num2)      // get the max from them 
                        Console.WriteLine(num1);
                    else
                        Console.WriteLine(num2);

                }

                else
                    Console.WriteLine(0);   // return 0 if they are out of range


                Console.WriteLine("Press any letter to continue or press E for exit");  // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
