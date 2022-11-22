using System;

namespace task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();    // clear the screen for the user

                Console.WriteLine("Enter 3 numbers : ");         // user Insert 3 numbers
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                
                int max, min;
                max = min = num1;       // set max & min to initial value

                if(num2 > max) {        // check if their is value greater than max
                    max= num2;
                }
                if(num3 > max)
                {
                    max= num3;
                }
                if(num2< min) {         // check if their is value smaller than min
                    min= num2;
                }
                if(num3< min) {
                    min= num3;
                }   
                Console.WriteLine($"First number = {num1}");        // print the results
                Console.WriteLine($"Second number = {num2}");
                Console.WriteLine($"Third number = {num3}");
                Console.WriteLine($"Maximum = {max} , Minimum = {min}");


                Console.WriteLine("Press any letter to continue or press E for exit"); // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
