using System;

namespace task2
{
    internal class Program
    {
        #region MyFunctions 
        public static void Fill2DArray(int[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
                
            }
        }
        public static void Display2DArray(int[,] arr)
        {
            Console.Clear();
            Console.WriteLine("Your array :");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = {arr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        public static void DisplayRowsSum(int[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i,j];
                }
                Console.WriteLine($"Sum of row {i+1} = {sum}");             
            }
        }
        public static void DisplayColsAvg(int[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine($"Average of column {i+1} = {sum/ arr.GetLength(0)}");
            }
        }
        public static void Warning()
        {
            Console.WriteLine("You have to Enter Dimention first!");
        }

        #endregion
        static void Main(string[] args)
        {
            int rows, cols, flag;
            int[,] array = null;
            char answer = 'N';
            do
            {
                Console.Clear();
                Console.WriteLine("1) Enter Dimention");
                Console.WriteLine("2) Fill Array");
                Console.WriteLine("3) Display Array");
                Console.WriteLine("4) Display Rows Summation");
                Console.WriteLine("5) Display Columns average");
                Console.WriteLine("6) Exit");
                Console.WriteLine("-----------------------------");
                
                Console.Write("Please Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice == 6)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter number of rows : ");
                        rows = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of columns : ");
                        cols = int.Parse(Console.ReadLine());
                        array = new int[rows, cols];
                        Console.WriteLine("Array created successfully");
                        break;
                    
                    case 2:
                        if (array != null)
                            Fill2DArray(array);
                        else
                            Warning();
                        break;
                    
                    case 3:
                        if (array != null)
                            Display2DArray(array);
                        else
                            Warning();
                        break;

                    case 4:
                        if (array != null)
                            DisplayRowsSum(array);
                        else
                            Warning();
                        break;

                    case 5:
                        if (array != null)
                            DisplayColsAvg(array);
                        else
                            Warning();
                        break;
                    
                    default:
                        Console.WriteLine("Wrong Choice!");
                        break;
                }

                Console.WriteLine();
                Console.Write("Do you want to continue? press Y for yes and N for no ");
                answer = char.Parse(Console.ReadLine());

            } while (answer=='Y') ;
        }
    }
}
