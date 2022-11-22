using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task1
{
    internal class Program
    {
        #region Operation Functions 
        public static bool checkDeptName(Department[] depts, string name)
        {
            for(int i=0; i < depts.Length; i++)
            {
                if (depts[i].Name == name)
                    return false;
            }
            return true;
        }
        public static bool checkDeptID(Department[] depts, int deptid)
        {
            for (int i = 0; i < depts.Length; i++)
            {
                if (depts[i].ID == deptid)
                    return false;
            }
            return true;
        }
        public static bool checkEmpIDPerDept(Employee[] employees, int id)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ID == id)
                    return false;
            }
            return true;
        }
        public static void PrintDeptsNames(Company company)
        {
            Console.Clear();
            for(int i = 0 ; i < company.Departments.Length ; i++)
            {
                Console.WriteLine($"Department {i+1} : {company.Departments[i].Name}");
            }
            Console.ReadLine();
        }
        public static void DeptEmpNum(Company company)
        {
            Console.Clear();
            for (int i = 0; i < company.Departments.Length; i++)
            {
                Console.WriteLine($"Department {i+1} has {company.Departments[i].Employees.Length} employees");
            }
            Console.ReadLine();
        }
        public static void TotalEmpNum(Company company)
        {
            Console.Clear();
            int total = 0;
            for (int i = 0; i < company.Departments.Length; i++)
            {
                total += company.Departments[i].Employees.Length;
            }
            Console.WriteLine($"The total number of employee in {company.Name} is {total}");
            Console.ReadLine();
        }
        public static void SearchEmpByIDInDept(Company company)
        {
            Console.Clear();
            int id;
            string name;
            Console.Write($"Enter department name : ");
            name = Console.ReadLine();
            Console.Write($"Enter ID of employee : ");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < company.Departments.Length; i++)
            {
                if (company.Departments[i].Name == name)
                {
                    for (int j = 0; j < company.Departments[i].Employees.Length; j++)
                    {
                        if (company.Departments[i].Employees[j].ID == id)
                        {
                            company.Departments[i].Employees[j].Print();
                            Console.ReadKey();
                            return;
                        }
                            
                    }
                }
            }
            Console.WriteLine($"Cant't find that employee in department {name}");
            Console.ReadKey();
        }
        public static void UpdateEmpByIDInDept(Company company)
        {
            Console.Clear();
            int id;
            string name;
            Console.Write($"Enter department name : ");
            name = Console.ReadLine();
            Console.Write($"Enter ID of employee : ");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < company.Departments.Length; i++)
            {
                if (company.Departments[i].Name == name)
                {
                    for (int j = 0; j < company.Departments[i].Employees.Length; j++)
                    {
                        if (company.Departments[i].Employees[j].ID == id)
                        {
                            Console.Write($"Enter new name : ");
                            company.Departments[i].Employees[j].Name = Console.ReadLine();
                            Console.WriteLine($"----------------\nThe name changed successfully");
                            company.Departments[i].Employees[j].Print();
                            Console.ReadKey();
                            return;
                        }

                    }
                }
            }
            Console.WriteLine($"Cant't find that employee in department {name}");
            Console.ReadKey();
        }
        public static void DeleteEmpByIDInDept(Company company)
        {
            Console.Clear();
            int id;
            string name;
            Console.Write($"Enter department name : ");
            name = Console.ReadLine();
            Console.Write($"Enter ID of employee : ");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < company.Departments.Length; i++)
            {
                if (company.Departments[i].Name == name)
                {
                    for (int j = 0; j < company.Departments[i].Employees.Length; j++)
                    {
                        if (company.Departments[i].Employees[j].ID == id)
                        {
                            company.Departments[i].Employees[j] = new Employee();
                            Console.WriteLine($"----------------\nThe employee deleted successfully");
                            //company.Departments[i].Employees[j].Print();
                            Console.ReadKey();
                            return;
                        }

                    }
                }
            }
            Console.WriteLine($"Cant't find that employee in department {name}");
            Console.ReadKey();
        }

        #endregion
        #region The menu function

        public static void Menu(Company company)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("a- Display all departments names");
                Console.WriteLine("b- Display employees count per department");
                Console.WriteLine("c- Display total number of employees in company");
                Console.WriteLine("d- Search for employee ID in depatment");
                Console.WriteLine("e- Update employee name by ID in depatment");
                Console.WriteLine("f- Delete employee by ID in department");
                Console.WriteLine("g- Exit");
                Console.WriteLine("-----------------------------------------");

                Console.Write("Please choose : ");
                char choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'a':
                        PrintDeptsNames(company);
                        break;
                    case 'b':
                        DeptEmpNum(company);
                        break;
                    case 'c':
                        TotalEmpNum(company);
                        break;
                    case 'd':
                        SearchEmpByIDInDept(company);
                        break;
                    case 'e':
                        UpdateEmpByIDInDept(company);
                        break;
                    case 'f':
                        DeleteEmpByIDInDept(company);
                        break;
                    case 'g':
                        return;
                    default:
                        Console.WriteLine("Wrong choice, please enter correct one!");
                        Console.ReadKey();
                        break;

                }

            }
        }

        #endregion

        static void Main(string[] args)
        {
            /* Employee[] employees = new Employee[]
            {
                new Employee(100,"Reem","developer",10000, new HiringDate(1,2,2020),'F'),
                new Employee(101,"Rahma","secretary",5000, new HiringDate(1,1,2018),'F'),
                new Employee(200,"Youssef","DBA",15000, new HiringDate(5,3,2020),'M'),
                new Employee(201,"Omar","secretary",6000, new HiringDate(10,12,2017),'M'),

            };

            Department[] departments = new Department[]
            {
                new Department(1,"Operation","Omar",new Employee[]
                {
                    employees[1], employees[3]
                }),
                new Department(2,"IT","Reem",new Employee[]
                {
                    employees[0], employees[2]
                }),
            };*/

            Company iti = new Company();
            Console.WriteLine("***** Receiving Company Data *****");
            Console.Write("Enter company name : ");
            iti.Name= Console.ReadLine();
            Console.Write("Enter total number of departments : ");
            int numDept = int.Parse(Console.ReadLine());

            Department[] departments= new Department[numDept];
            int deptid= -1;
            string deptname = " ";
            
            Console.Clear();
            
            for(int i =0; i< departments.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"***** Receiving Departments Data Of {iti.Name} Company *****");
                do {
                    Console.Write($"Enter id of department {i+1} (must be unique) : ");
                    deptid = int.Parse(Console.ReadLine());
                } while (!checkDeptID(departments, deptid));
                departments[i].ID = deptid;
                do {
                    Console.Write($"Enter name of department {i+1} (must be unique) : ");
                    deptname = Console.ReadLine();
                } while (!checkDeptName(departments, deptname));
                departments[i].Name = deptname;


                Console.WriteLine("---------");
                Console.WriteLine($"Enter data of department {departments[i].Name} employees : ");
                Console.Write($"Enter number of employees in {departments[i].Name} department : ");
                int numEmps = int.Parse(Console.ReadLine());       
                Employee[] employees = new Employee[numEmps];
                
                Console.Clear();

                HiringDate  date = new HiringDate();
                int emoid = -1;
                for (int j = 0; j < employees.Length; j++)
                {
                    Console.Clear();
                    Console.WriteLine($"***** Receiving Employees Data Of {departments[i].Name} Department *****");
                    do {
                        Console.Write("Enter id (must be unique per department) : ");
                        emoid = int.Parse(Console.ReadLine());
                    } while (!checkEmpIDPerDept(employees, emoid));
                    employees[j].ID = emoid;

                    Console.Write("Enter name : ");
                    employees[j].Name = Console.ReadLine();
                    Console.Write("Enter security level : ");
                    employees[j].SecurityLevel = Console.ReadLine();
                    Console.Write("Enter gender (M or F) : ");
                    employees[j].Gender = char.Parse(Console.ReadLine());
                    Console.Write("Enter salary : ");
                    employees[j].Salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter hire date :");
                    Console.Write("\tDay : ");
                    date.Day = int.Parse(Console.ReadLine());
                    Console.Write("\tMonth : ");
                    date.Month = int.Parse(Console.ReadLine());
                    Console.Write("\tYear : ");
                    date.Year = int.Parse(Console.ReadLine());
                    employees[j].HireDate = date;
                    Console.WriteLine("-----------------------");
                    Console.ReadKey();
                }

                departments[i].Employees=employees;

            }

            iti.Departments=departments;

            Menu(iti);


        }
    }
}
