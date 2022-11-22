using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Triangle : Shape
    {
        public float Height { get; set; }
        public float Base { get; set; }
        public override double CalcArea()
        {
            return Height*Base*0.5;
        }

        public Triangle(float _height, float _base)
        {
            Height = _height;
            Base = _base;
        }
 
    }
}
