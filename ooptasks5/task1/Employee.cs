using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("-------------");
        }
        #endregion
    }
    #endregion
}
