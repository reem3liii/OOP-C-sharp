using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration d1= new Duration(1,10,15);
            Duration d2 = new Duration(3600);
            Duration d3 = new Duration(666);
            Duration d4 = d1+ d2;
            Duration d5 = d1 + 7800;
            Duration d6 = d1 + d2;

            d1.Print();
            d2.Print();
            d3.Print();
            d4.Print();
            d5.Print();

            Console.WriteLine(d1 < d2);
            Console.WriteLine(d2 >= d3);
            Console.WriteLine(d4 <= d6);

        }
    }
}
