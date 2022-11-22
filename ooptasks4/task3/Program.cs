using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task3
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
        public static void FillArray(Employee[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                HiringDate date = new HiringDate();
                bool unique;
                int id;
                do
                {
                    Console.Clear();
                    Console.Write("Enter ID (must be unique) :  ");
                    id = int.Parse(Console.ReadLine());
                    unique = CheckUnique(arr, id);
                } while (!unique);
                
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
                arr[index].ID = id;
                arr[index].Name = name;
                arr[index].SecurityLevel = level;
                arr[index].Salary = sal;
                arr[index].Gender = gen;
                arr[index].HireDate = date;
            }
        }
        public static bool CheckUnique(Employee[] arr, int id)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ID == id)
                {
                    return false;
                }
            }
            return true;
        }
        public static void PrintArray(Employee[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Print();
            }
        }
        public static Employee[] ConcatEmpArrys(Employee[] arr1, Employee[] arr2)
        {
            Employee[] newArr = new Employee[arr1.Length + arr2.Length];
            int i = 0;

            for (; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            for (int j = 0; i < newArr.Length; i++, j++)
            {
                newArr[i] = arr1[j];
            }

            return newArr;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter size of first array: ");
            int arrSize = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[arrSize];
            FillArray(employees);

            Console.Clear();
            
            Console.Write("Enter size of second array: ");
            int arrSize2 = int.Parse(Console.ReadLine());
            Employee[] employees2 = new Employee[arrSize2];
            FillArray(employees2);

            Console.Clear();

            Console.WriteLine("First Array Data: ");
            PrintArray(employees);
            Console.WriteLine("Second Array Data: ");
            PrintArray(employees2);
            Console.WriteLine("-------------------------------------------------------------");
            Employee[] employees3 = ConcatEmpArrys(employees, employees2);
            Console.WriteLine("Third Array Data (the concatination of the the 1st & 2nd):");
            PrintArray(employees3);

        }
    }
}
