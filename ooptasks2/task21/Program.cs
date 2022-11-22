using System;

namespace task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user

                Console.WriteLine("Enter 2 numbers : ");        // user Insert 2 numbers
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                
                int oddsum = 0, evensum = 0;        // initiate the sum variables to zeros

                Console.WriteLine();
                Console.WriteLine($"First= {num1}, Last= {num2}");  // print the start and the end 

                if (num1 % 2 == 0)  // if the start is an even number 
                {
                    Console.WriteLine();
                    Console.Write("Even: ");        // print the even numbers by a loop
                    for (int i =num1; i <= num2; i += 2)
                    {
                        Console.Write($"{i} ");
                        evensum += i;       // adding the even values to EvenSum
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Sum of even = {evensum}");  // print EvenSum
                    
                    Console.WriteLine();

                    Console.Write("Odd: ");     // print the odd numbers by a loop
                    for (int i = num1+1; i <= num2; i += 2)
                    {
                        Console.Write($"{i} ");
                        oddsum += i;        // adding the odd values to OddSum
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Sum of odd = {oddsum}");        // print OddSum

                }
                else        // else if the start is an odd number 
                {
                    Console.WriteLine();
                    Console.Write("Odd: ");     // print the odd numbers by a loop
                    for (int i = num1; i <= num2; i += 2)
                    {
                        Console.Write($"{i} ");
                        oddsum += i;        // adding the odd values to OddSum
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Sum of odd = {oddsum}");         // print OddSum
                    
                    Console.WriteLine();

                    Console.Write("Even: ");        // print the even numbers by a loop
                    for (int i = num1+1; i <= num2; i += 2)
                    {
                        Console.Write($"{i} ");
                        evensum += i;       // adding the even values to EvenSum
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Sum of even = {evensum}");      // print EvenSum
                }
                Console.WriteLine();
                Console.WriteLine($"EvenSum - OddSum = {evensum-oddsum}"); // print the diff between EvenSum and OddSum

                Console.WriteLine();
                Console.WriteLine("Press any letter to continue or press E for exit"); // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
