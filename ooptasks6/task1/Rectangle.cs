using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Rectangle : Shape
    {
        public float Lenght { get; set; }
        public float Width { get; set; }

        public override double CalcArea()
        {
            return Lenght * Width;
        }
        public Rectangle(float _lenght, float _width)
        {
            Lenght = _lenght;
            Width = _width;
        }
        public override void Draw()       // change priority
        {
            Console.WriteLine("Drawing from Rectangle class");
        }
    }
}
