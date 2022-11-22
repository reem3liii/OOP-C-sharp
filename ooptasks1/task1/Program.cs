
using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = 103;
            char letter = 's';
            Console.WriteLine("The ASCII code of s is {0}, The equivalent letter of 24 is {1} ",(int)letter,(char)num);*/

            Console.WriteLine("Enter a letter:");
            char letter = char.Parse(Console.ReadLine());
            Console.WriteLine($"The ASCII code of {letter} is : {(int)letter}");
            Console.WriteLine();
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The equivalent character of {num} is : {(char)num}");
        }
    }
}
