using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] ahlyplayers = new Player[]
            {
                new Player(){TshirtNumber=22,Name="Abu Trika" },
                new Player(){TshirtNumber=1,Name="El Shenawy" },
                 new Player(){TshirtNumber=14,Name="Solia" },
                  new Player(){TshirtNumber=10,Name="Meteb" }
            };
            Team ahly = new Team("Ahly", ahlyplayers);

            Player[] zamalekplayers = new Player[]
            {
                new Player(){TshirtNumber=10,Name="Sheka" },
                new Player(){TshirtNumber=32,Name="Awaad" },
            };
            Team zamalek = new Team("Zamalek", zamalekplayers);

            Team[] egyptianteams = new Team[] { ahly, zamalek };
            League EgyptianLeage = new League("EgyptianLeage", egyptianteams);

            EgyptianLeage.Print();

            Console.WriteLine(ahly[22]);    // indexer on team level
            ahly[22] = "M.Mahmoud";
            Console.WriteLine(ahly[22]);

            Player[] temp = EgyptianLeage["Zamalek"];   // indexer on league level
            EgyptianLeage["Zamalek"] = ahlyplayers;
            zamalek.Print();
            Console.WriteLine("----------");
            for(int i=0;i< temp.Length; i++)
            {
                Console.WriteLine(temp[i].Print());
            }
            
            
        }
    }
}
