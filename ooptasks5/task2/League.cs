using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class League
    {
        string leagename;
        public string Leagename
        {
            get { return leagename; }
            set { leagename = value; }
        }

        Team[] teams;
        public Team[] Teams
        {
            get { return teams; }
            set { teams = value; }
        }

        public League(string _lname , Team[] _teams)
        {
            leagename = _lname;
            teams = _teams;
        }

        public void Print()
        {
            Console.WriteLine($"******** Leage Data  : {leagename} **********");
            for (int i = 0; i < teams.Length; i++)
            {
                teams[i].Print();
                Console.WriteLine("*************************************");
            }
        }

        public Player[] this[string tName]
        {
            set { 
                for(int i =0;i< teams.Length;i++)
                {
                    if (teams[i].Name == tName)
                    {
                        teams[i].Players = value;
                    }
                }
            }
            get {
                for (int i = 0; i < teams.Length; i++)
                {
                    if (teams[i].Name == tName)
                    {
                        return teams[i].Players;
                    }
                }
                return null;
            }
        }
    }
}
