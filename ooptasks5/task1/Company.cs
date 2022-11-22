using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    struct Company
    {
        string name;
        Department[] departments;

        public Company(string _name, Department[] _departs)
        {
            name = _name;
            departments= _departs;
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public Department[] Departments
        {
            get { return departments ; }
            set {  departments = value; }
        }


        public void Print()
        {
            Console.WriteLine($"Company Data : Name = {name}, Departments :");
            for (int i = 0; i < departments.Length; i++)
            {
                departments[i].Print();
            }
        }

    }
}
