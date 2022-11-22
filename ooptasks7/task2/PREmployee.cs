using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class PREmployee : Employee
    {
        public override void ShowEmployeeDetails()
        {
            Console.WriteLine($"PR Employee Data : ID = {ID}, Name = {Name}, Salary = {Salary}");
        }
    }
}
