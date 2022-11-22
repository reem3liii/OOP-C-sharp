using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in decimal:");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine($"The equivalent hexadical of {num:D} is {num:X}");
        }
    }
}
