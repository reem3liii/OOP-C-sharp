using System;
using System.Linq;

namespace task4
{
    internal class Program
    {
        #region Functions
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int arrsize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrsize];
            FillArray(arr);

            int[] distinctArr = arr.Distinct().ToArray();
            int[] freq = new int[distinctArr.Length];

            for(int i = 0; i < distinctArr.Length; i++)
            {
                for(int j = 0 ; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        freq[i]++;
                    }
                }
            }

            for(int i = 0; i < distinctArr.Length; i++)
            {
                Console.WriteLine($" {distinctArr[i]} occurs {freq[i]} times");
            }
        }
    }
}
