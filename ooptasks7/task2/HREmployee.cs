using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class HREmployee : Employee
    {
        public override void ShowEmployeeDetails()
        {
            Console.WriteLine($"HR Employee Data : ID = {ID}, Name = {Name}, Salary = {Salary}, NO.Clients = {Clients.Length}");
        }
        public static HREmployee operator +(HREmployee emp1, HREmployee emp2)
        {
            return new HREmployee() { ID = emp1.ID + emp2.ID, Name = emp1.Name + " " + emp2.Name, Salary = emp1.Salary + emp2.Salary , Clients = new Client[1] };
        }
        public string this[int clientID]
        {
            set
            {
                for(int i=0; i<Clients.Length; i++)
                {
                    if (Clients[i].ID == clientID)
                    {
                        Clients[i].Name = value; break;
                    }
                }
            }

            get
            {
                for (int i = 0; i < Clients.Length; i++)
                {
                    if (Clients[i].ID == clientID)
                    {
                        return Clients[i].Name;
                    }
                }
                return "Client Not Found";

            }
        }
    }
}
