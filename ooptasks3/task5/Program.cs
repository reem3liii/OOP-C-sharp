using System;

namespace task5
{
    internal class Program
    {
        #region Functions

        public static bool CheckUnique(int[] arr , int num)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]== num)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            int counter = 0;

            while (arr[arr.Length-1]==0)
            {
                Console.Write("Enter 10 unique numbers to fill the array : ");
                int num = int.Parse(Console.ReadLine());

                if (CheckUnique(arr, num))
                {
                    arr[counter]= num;
                    counter++;
                }
                else
                {
                    Console.Write("It's not unique try again");
                    Console.WriteLine();
                }
                    
            }

            Console.WriteLine("Your Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }



        }
    }
}
