using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Player
    {
        public int TshirtNumber { get; set; }
        public string Name { get; set; }
   
        public string Print()
        {
            return $"Player Data : Tshirt Number = {TshirtNumber} , Name= {Name}";
        }

    }
}
