using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
     abstract class Shape     
    {
        public string Color { get; set; }   
        public abstract double CalcArea();   
        public virtual void Draw()          
        {
            Console.WriteLine("Drawing from Shape class");
        }

    }
}
