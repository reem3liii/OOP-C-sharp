using System;

namespace task1
{
    internal class Program
    {
        #region MyFunctions 
        public static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void DisplayArray(int[] arr)
        {
            Console.WriteLine("You entered:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
        public static int SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void GetOdd(int[] arr)
        {
            Console.Write("Odd numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static void GetEven(int[] arr)
        {
            Console.Write("Even numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        public static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        public static int GetAvg(int[] arr)
        {
            return SumArray(arr) / arr.Length;
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] array = new int[arrSize];

            FillArray(array);
            DisplayArray(array);
            Console.WriteLine($"Summation = {SumArray(array)}");
            GetEven(array);
            GetOdd(array);
            Console.WriteLine($"Maximum = {GetMax(array)}");
            Console.WriteLine($"Minimum = {GetMin(array)}");
            Console.WriteLine($"Avrage = {GetAvg(array)}");


        }
    }
}
