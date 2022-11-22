using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
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
}
