using System;

namespace task7
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
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] array = new int[arrSize];

            FillArray(array);

            int firstCell=-1, lastCell=-1, longDistance=-1;
            bool flag=false;

            for (int i = 0; i < array.Length -1 ; i++)
            {
                for (int j = array.Length - 1; j > 0 ; j--)
                {
                    if (array[i] == array[j])
                    {
                        firstCell= i;
                        lastCell= j;
                        longDistance = j-i-1;
                        break;
                    }
                }
                if (longDistance > 0)
                {
                    flag= true;
                    break;
                }
                    
            }
            if (flag)
            {
                Console.WriteLine($"The longest distance is {longDistance} cells between index {firstCell} and {lastCell}");
            }
            else
            {
                Console.WriteLine($"There is no equal cells");

            }

        }
    }
}
