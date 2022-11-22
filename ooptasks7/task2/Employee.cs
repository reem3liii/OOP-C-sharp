using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class Employee
    {
       public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Client[] Clients { get; set; }
        public abstract void ShowEmployeeDetails();
        public Client[] this[int id]
        {
            set
            {
                if(id== ID)
                {
                    Clients = value;
                }
            }
            get
            {
                if (id == ID)
                {
                    return Clients;
                }
                else return null;
            }
        }
    }
}
