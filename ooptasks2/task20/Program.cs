using System;

namespace task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();         // clear the screen for the user

                Console.WriteLine("+) summation\n-) subtraction\n/) division\n*) multiplication\ne) exit"); // print menu to user
                Console.WriteLine("Please enter your operation ( +,*,-,/ or e ): ");

                char operation = char.Parse(Console.ReadLine());  // get the choice
                
                if (operation == 'e' || operation == 'E')   // end the loop if the user press exit
                    break;

                Console.WriteLine("Enter 2 numbers : ");     // user Insert 2 numbers
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                switch (operation)      // do the calculation according to the choice
                {
                    case'+':
                        Console.WriteLine(x + y);
                        break;
                    case '-':
                        Console.WriteLine(x - y);
                        break;
                    case '*':
                        Console.WriteLine(x * y);
                        break;
                    case '/':
                        Console.WriteLine(x / y);
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;

                }

                Console.WriteLine("Press any letter to continue or press E for exit"); // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
