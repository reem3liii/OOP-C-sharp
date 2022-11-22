using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    #region Struct Employee
    struct Employee
    {
        #region Fields
        int id;
        string name;
        string securityLevel;
        int salary;
        HiringDate hireDate;
        char gender;
        #endregion
        #region Constrcutors
        public Employee(int _id, string _name, string _securityLevel, int _salary, HiringDate _hireDate, char _gender)
        {
            id = _id;
            name = _name;
            securityLevel = _securityLevel;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
        }
        #endregion
        #region Properties
        public int ID
        {
            set
            {
                if (value >= 1) { id = value; }
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                if (value.Length >= 3) { name = value; }
            }
            get
            {
                return name;
            }
        }
        public string SecurityLevel
        {
            set
            {
                if (value.Trim() == "guest" || value.Trim() == "developer" || value.Trim() == "secretary" || value.Trim() == "DBA")
                {
                    securityLevel = value;
                }
            }
            get
            {
                return securityLevel;
            }
        }
        public int Salary
        {
            set
            {
                if (value >= 5000 && value <= 20000) salary = value;
            }
            get
            {
                return salary;
            }
        }
        public HiringDate HireDate
        {
            set
            {
                hireDate = value;
            }
            get
            {
                return hireDate;
            }
        }
        public char Gender
        {
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
            }
            get
            {
                return gender;
            }
        }
        #endregion
        #region Methods
        public void Print()
        {
            Console.WriteLine($"Employee Data : ID = {id}, Name = {name}, SecurityLevel = {securityLevel}, Salary = {salary}, Gender = {gender}, Hire Date = {hireDate.Day}/{hireDate.Month}/{hireDate.Year} ");
        }
        #endregion
    }
    #endregion
    #region Struct HireDate
    struct HiringDate
    {
        #region Fields
        int day;
        int month;
        int year;
        #endregion
        #region Constrcutors
        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        #endregion
        #region Properties
        public int Day
        {
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
            }
            get { return day; }
        }
        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
            }
            get { return month; }
        }
        public int Year
        {
            set
            {
                if (value >= 1 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
            }
            get { return year; }
        }

        #endregion
        #region Methods
        public void Print()
        {
            Console.WriteLine($"Hire Data : {day}/{month}/{year} ");
        }
        public void SetHireDate(int d, int m, int y)
        {
            if (d >= 1 && d <= DateTime.Now.Day)
            {
                day = d;
            }
            else day = 1;

            if (m >= 1 && m <= DateTime.Now.Month)
            {
                month = m;
            }
            else month = 1;

            if (y >= 1 && y <= DateTime.Now.Year)
            {
                year = y;
            }
            else year = 1;
        }
        public void SetHireDateToToday()
        {
            day = DateTime.Now.Day;

            month = DateTime.Now.Month;

            year = DateTime.Now.Year;
        }

        #endregion
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp= new Employee();
            HiringDate date= new HiringDate();

            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Security Level: ");
            string level = Console.ReadLine();

            Console.Write("Enter Salary: ");
            int sal = int.Parse(Console.ReadLine());

            Console.Write("Enter Gender: ");
            char gen = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Hire Date:");
            Console.Write("\tDay: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("\tMonth: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("\tYear: ");
            int y = int.Parse(Console.ReadLine());

            date.Day = d;
            date.Month = m;
            date.Year = y;

            emp.ID = id;
            emp.Name = name;
            emp.SecurityLevel = level;
            emp.Salary = sal;
            emp.Gender = gen;
            emp.HireDate = date;

            Console.WriteLine();
            Console.WriteLine("Employee inserted successfully");
            Console.WriteLine();
            emp.Print();
            Console.WriteLine();

        }
    }
}
