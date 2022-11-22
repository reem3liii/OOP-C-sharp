using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)        // infinity loop until user exit
            {
                Console.Clear();    // clear the screen for the user

                Console.WriteLine("Enter 3 numbers : ");    // user Insert 3 number
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                
                int max = num1;     // set the max to initial value 

                if (num2>max)   // check if there is a greater value than the initial
                    max= num2;
                if(num3>max)
                    max= num3;
                    
                Console.WriteLine(max);         // print the maximum 

                Console.WriteLine("Press any letter to continue or press E for exit");  // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')       // end the loop if the user press exit
                    break;

            }
        }
    }
}
