using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 8, num2= 4;
            Console.WriteLine("num1+num2= {0}, num1*num2= {1}, num1-num2={2}, num1/num2={3}",num1+num2, num1 * num2, num1 - num2, num1 / num2);*/

            Console.WriteLine("Enter 2 numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum = {num1 + num2} , Subtraction = {num1 - num2} , Multiplication = {num1 * num2}");

        }
    }
}
