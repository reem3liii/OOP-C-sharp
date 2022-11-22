using System;

namespace task3
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
        public static int[] ConcatArrays(int[] a, int[] b)
        {
            int[] concat = new int[(a.Length+b.Length)];
            int counter = 0;
            for(int i = 0; i < concat.Length;i++)
            {
                if (i >= a.Length)
                {
                    concat[i] = b[counter];
                    counter++;
                }
                else
                {
                    concat[i] = a[i];
                }
                
            }
            return concat;
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of first array: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size1];
            FillArray(arr1);

            Console.WriteLine("Enter size of second array: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[size2];
            FillArray(arr2);

            int[] arr3 = ConcatArrays(arr1, arr2);

            Console.WriteLine("The concatination of the two arrays : ");
            DisplayArray(arr3);


        }
    }
}
