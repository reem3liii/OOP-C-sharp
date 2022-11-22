using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string ShowClientDetails()
        {
            return $"Client Data : ID = {ID}, Name = {Name}, City = {City}";
        }

    }
}
