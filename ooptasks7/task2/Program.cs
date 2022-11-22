using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        public static Employee GetEmployeeWithLongestClientsArray(Employee[] emps)
        {
            Employee maxEmpArr = emps[0];
            for(int i = 0; i< emps.Length; i++)
            {
                if(emps[i].Clients.Length > maxEmpArr.Clients.Length)
                    maxEmpArr= emps[i];
            }
            return maxEmpArr;
        }
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new HREmployee(){ID= 10, Name = "Ahmed", Salary = 5000, 
                    Clients = new Client[]
                    {
                        //new Client(){ID = 1, Name= "Sara", City = "Cairo"},
                        new Client(){ID = 2, Name= "Salma", City = "Alex"},
                    }
                    },
                new PREmployee(){ID= 20, Name = "Arwa", Salary = 6000,
                    Clients = new Client[]
                        {
                            //new Client(){ID = 5, Name= "Omar", City = "Cairo"},
                            new Client(){ID = 4, Name= "Kareem", City = "Dumyat"},
                        }
                },
                new HREmployee(){ID= 30, Name = "Ali", Salary = 8000,
                    Clients = new Client[]
                    {
                        new Client(){ID = 12, Name= "Mohammed", City = "Mansoura"},
                        new Client(){ID = 15, Name= "Youssef", City = "Zagazig"},
                    }
                },
                new PREmployee(){ID= 40, Name = "Dina", Salary = 4000,
                    Clients = new Client[]
                    {
                        //new Client(){ID = 1, Name= "Rawan", City = "Arish"},
                        new Client(){ID = 2, Name= "Rahma", City = "Port Saed"},
                    }
                },


            };

            GetEmployeeWithLongestClientsArray(employees).ShowEmployeeDetails();

            HREmployee hr1 = new HREmployee()
            {
                ID = 6,
                Name = "Ahmed",
                Salary = 5000,
                Clients = new Client[]
                    {
                        new Client(){ID = 1, Name= "Sara", City = "Cairo"},
                        new Client(){ID = 2, Name= "Salma", City = "Alex"},
                    }
            };
            HREmployee hr2 = new HREmployee()
            {
                ID = 20,
                Name = "Gamal",
                Salary = 10000,
                Clients = new Client[]
                    {
                        new Client(){ID = 1, Name= "Sara", City = "Cairo"},
                        new Client(){ID = 2, Name= "Salma", City = "Alex"},
                    }
            };
            HREmployee hr3 = hr1+hr2;
            hr3.ShowEmployeeDetails();

            //hr1[1] --> return "Sara" , 1 = ID of client
            Console.WriteLine(hr1[1]);
            hr1[1] = "Shaza";
            Console.WriteLine(hr1[1]);


        }
    }
}
