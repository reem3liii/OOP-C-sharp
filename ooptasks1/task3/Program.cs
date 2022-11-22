using System;

namespace task3
{
    namespace Reem
    {
        class Printing
        {
            public static void print()
            {
                Console.WriteLine("Print from Reem");
            }
        }
    }

    namespace Dina
    {
        class Printing
        {
            public static void print()
            {
                Console.WriteLine("Print from Dina");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            task3.Reem.Printing.print();
            task3.Dina.Printing.print();
        }
    }
}
