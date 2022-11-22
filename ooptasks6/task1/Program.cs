using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        #region Functions
        public static double CalcAllAreas(Shape[] shapes)
        {
            double result = 0;
            for(int i = 0; i < shapes.Length; i++)
            {
                result += shapes[i].CalcArea();
            }
            return result;
        }
        public static void DrawAllShapes(Shape[] shapes)
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();
            }
        }

        #endregion
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Rectangle(8,5),
                new Square(2),
                new Circle(3),
                new Triangle(12,6),               
            };
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"The total area of the shapes = {CalcAllAreas(shapes)}");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("The output of RunAllDraw : ");
            Console.WriteLine();
            /* Draw output according my code : Shape refer to object
             * Rec -> Rec draw : override done
             * Squ -> Rec draw : the last override is Rec
             * Cir -> Cir draw : override done
             * Tri -> Shape draw : no override
             */
            DrawAllShapes(shapes);
            Console.WriteLine();


        }
    }
}
