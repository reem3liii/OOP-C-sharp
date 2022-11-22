using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    struct Department
    {
        int id;
        string name;
        string manager;
        Employee[] employees;

        public Department(int _id,string _name, string _manager, Employee[] _emps )
        {
            id = _id;
            name= _name;
            manager= _manager;
            employees= _emps;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            set
            {
                name= value;
            }
            get
            {
                return name;
            }
        }

        public string Manager
        {
            set
            {
                if(value.Length>=3)
                manager = value;
            }
            get
            {
                return manager;
            }
        }

        public Employee[] Employees
        {
            set
            {
                employees = value;
            }
            get
            {
                return employees;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Department Data : Name = {name}, Manager = {manager}, Employees :");
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Print();
            }
            Console.WriteLine("----------------------------------------------");
        }

    }
}
