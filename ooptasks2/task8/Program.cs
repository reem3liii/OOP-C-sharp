using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)    // infinity loop until user exit
            {
                Console.Clear();        // clear the screen for the user

                Console.WriteLine("Enter 2 numbers : ");     // user Insert 2 number
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                
                int dist1 = Math.Abs(100 - num1);  // calculate the distance between each number and 100 through the absolute difference
                int dist2 = Math.Abs(100 - num2);

                if (dist1<dist2)     // check which distance is smaller 
                    Console.WriteLine(num1);
                else if(dist2<dist1) 
                    Console.WriteLine(num2);
                else
                    Console.WriteLine(0);   // if the two distances are equal return 0


                Console.WriteLine("Press any letter to continue or press E for exit");   // ask the user and get the answer
                char choice = Char.Parse(Console.ReadLine());

                if (choice == 'E' || choice == 'e')     // end the loop if the user press exit
                    break;

            }
        }
    }
}
