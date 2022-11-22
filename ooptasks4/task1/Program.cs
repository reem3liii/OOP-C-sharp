using System;
using System.Reflection;

namespace task1
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
        public Employee(int _id,string _name, string _securityLevel, int _salary, HiringDate _hireDate, char _gender)
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
                if (value.Trim()=="guest"|| value.Trim() == "developer"|| value.Trim() == "secretary"|| value.Trim() == "DBA")
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
                if(value=='M'|| value == 'F')
                    gender= value;
            }
            get { 
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
        public HiringDate( int _day, int _month, int _year)
        {
            day= _day;
            month= _month;
            year= _year;
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
            get { return day;}
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
        public void SetHireDate(int d,int m, int y)
        {
            if (d >= 1 && d <= DateTime.Now.Day)
            {
                day = d;
            }else day = 1;

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
        public static int numOfEmp = 0;
        #region Public Functions
        public static void InsertEmp(Employee[] arr, int index)
        {
            HiringDate date = new HiringDate();

            Console.Clear();

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

            arr[index].ID= id;
            arr[index].Name = name;
            arr[index].SecurityLevel = level;
            arr[index].Salary = sal;
            arr[index].Gender = gen;
            arr[index].HireDate = date;

            Console.WriteLine("Employee inserted successfully");

        }
        public static void DisplayEmps(Employee[] arr, int size)
        {
            Console.Clear();
            if(size== 0)
            {
                Console.WriteLine("There is no employees!");
                Console.ReadKey();
            }
            else {
                for (int i = 0; i < size; i++)
                {
                    arr[i].Print();
                }
                Console.ReadKey();
            }
            
        }
        public static void SearchEmpByID(Employee[] arr, int size)
        {
            Console.Clear();
            if (size == 0)
            {
                Console.WriteLine("There is no employees!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());

                for (int i = 0; i < size; i++)
                {
                    if (arr[i].ID == id)
                    {
                        arr[i].Print();
                        break;
                    }

                }
                Console.ReadKey();
            }
            
        }
        public static void SearchEmpByName(Employee[] arr, int size)
        {

            Console.Clear();
            if (size == 0)
            {
                Console.WriteLine("There is no employees!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                for (int i = 0; i < size; i++)
                {
                    if (arr[i].Name == name)
                    {
                        arr[i].Print();
                        break;
                    }

                }
                Console.ReadKey();
            }
                
        }
        public static void UpdateEmpByID(Employee[] arr, int size)
        {
            Console.Clear();
            if (size == 0)
            {
                Console.WriteLine("There is no employees!");
                Console.ReadKey();
            }
            else
            {
                HiringDate date = new HiringDate();
                int i;
                Console.Clear();
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Current Data: ");
                for (i = 0; i < size; i++)
                {
                    if (arr[i].ID == id)
                    {
                        arr[i].Print();
                        break;
                    }

                }

                Console.WriteLine("Update the values: ");

                Console.Write("ID: ");
                int newid = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Security Level: ");
                string level = Console.ReadLine();

                Console.Write("Salary: ");
                int sal = int.Parse(Console.ReadLine());

                Console.Write("Gender: ");
                char gen = char.Parse(Console.ReadLine());

                Console.WriteLine("Hire Date:");
                Console.Write("\tDay: ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("\tMonth: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("\tYear: ");
                int y = int.Parse(Console.ReadLine());

                date.Day = d;
                date.Month = m;
                date.Year = y;

                arr[i].ID = newid;
                arr[i].Name = name;
                arr[i].SecurityLevel = level;
                arr[i].Salary = sal;
                arr[i].Gender = gen;
                arr[i].HireDate = date;

                Console.WriteLine("Employee updated successfully");
                Console.ReadKey();

            }

        }
        public static Employee[] DeleteEmpByID(Employee[] arr, int size)
        {
            Console.Clear();
            if (size == 0)
            {
                Console.WriteLine("There is no employees!");
                Console.ReadKey();
                return arr;
            }
            else
            {
                Employee[] newArr = new Employee[arr.Length];
         
                Console.Clear();
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());

                for(int i=0,j=0 ; i< arr.Length-1; j++,i++)
                {
                    if (arr[j].ID == id)
                    {
                        i--;
                        continue;
                    }
                    else newArr[i] = arr[j];
                }
                Console.WriteLine("Employee deleted successfully");
                numOfEmp--;
                Console.ReadKey();
                return newArr;
            }

        }
        #endregion
        static void Main(string[] args)
        {
            Employee[] staff = new Employee[10];        
            while(true)
            {
                Console.Clear();
                Console.WriteLine("a- Insert new employee");
                Console.WriteLine("b- Display inserted employees only");
                Console.WriteLine("c- Search by ID");
                Console.WriteLine("d- Search by name");
                Console.WriteLine("e- Count number od inserted employees");
                Console.WriteLine("f- Update employee by ID");
                Console.WriteLine("g- Delete employee by ID");
                Console.WriteLine("h- Exit");
                Console.WriteLine("-----------------------------------------");

                Console.Write("Please choose : ");
                char choice= char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case'a':
                        InsertEmp(staff, numOfEmp);
                        numOfEmp++;
                        break;
                    case 'b':
                        DisplayEmps(staff, numOfEmp);
                        break;
                    case 'c':
                        SearchEmpByID(staff, numOfEmp);
                        break;
                    case 'd':                              
                        SearchEmpByName(staff, numOfEmp);
                        break;
                    case 'e':
                        Console.Clear();
                        Console.WriteLine($"Number of inserted emplyees = {numOfEmp}");
                        Console.ReadKey();
                        break;
                    case 'f':
                        UpdateEmpByID(staff,numOfEmp); 
                        break;
                    case 'g':
                        staff = DeleteEmpByID(staff,numOfEmp);
                        break;
                    case 'h':
                        return;
                    default:
                        Console.WriteLine("Wrong choice, please enter correct one!");
                        Console.ReadKey();
                        break;

                }

            } 
        }
    }
}
