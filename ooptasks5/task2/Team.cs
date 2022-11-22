using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Team
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Player[] players;
        public Player[] Players
        {
            get { return players; }
            set { players = value; }
        }

        public Team(string _teamname ,Player[] _players)
        {
            name = _teamname;
            players = _players;
        }

        public string this[int _t]
        {
            set
            {
                // ahly[22]="M.mahmoud"
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].TshirtNumber == _t)
                    {
                        players[i].Name = value;
                        break;
                    }
                }
            }
            get
            {
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].TshirtNumber == _t)
                    {
                        return players[i].Name;
                        
                    }
                }
                return $"No Player For {Name} with TShirt Numebr {_t}";
            }
        }

        public void Print()
        {
            Console.WriteLine($"Team Name : {name} \t Players : ");
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine(players[i].Print());
            }
        }

    }
}
