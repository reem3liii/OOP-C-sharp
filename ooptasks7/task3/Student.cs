using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public void Print()
        {
            Console.WriteLine($"Student Data : ID = {ID}, Name = {Name}, User Name = {UserName}, Password = {UserPass}, Email = {Email}");
            Console.WriteLine("--------------");
        }
    }
}
