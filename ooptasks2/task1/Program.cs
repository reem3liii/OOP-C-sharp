using System;

namespace task1
{
    namespace task1
    {
        class Program
        {
            static void Main(string[] args)
            {
                while (true)    // infinity loop until user exit
                {
                    Console.Clear();        // clear the screen for the user

                    Console.WriteLine("Enter 2 numbers : ");    // user Insert 2 number
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    if (num1 == num2)   // check if number 1 equal number 2

                        Console.WriteLine((num1 + num2) * 3);   // triple of the sum

                    else
                        Console.WriteLine(num1 + num2);     // normal sum

                    Console.WriteLine("Press any letter to continue or press E for exit");  // ask the user and get the answer
                    char choice = char.Parse(Console.ReadLine());

                    if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                        break;

                }
            }
        }
    }

}
