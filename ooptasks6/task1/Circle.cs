using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Circle : Shape
    {
        public float Radius { get; set; }
        public override double CalcArea()  
        {
            return 3.14*Radius*Radius;
        }
        public Circle(float _radius)
        {
            Radius = _radius;
        }

        public override void Draw()     // change priority
        {
            Console.WriteLine("Drawing from Circle class");
        }
    }
}
