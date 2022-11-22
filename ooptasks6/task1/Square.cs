using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Square : Rectangle
    {
        public override double CalcArea()
        {
            return Lenght*Lenght;
        }
        public Square(float _length) : base(_length, _length) { }
        

    }
}
