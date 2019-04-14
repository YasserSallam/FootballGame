using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDay
{
    //subscriber
    class Player
    {
        public string Name { get; set; }
        public string Teame { get; set; }

        Location playerLocation { get; set; } = new Location { X = 50, Y = 50, Z = 0 };

        //3- subscribere  define call back method 
        public void run(Location pl) {
            playerLocation += pl;
            Console.WriteLine($"{this} is runing to location {playerLocation}");
        }
        public override string ToString() => $"{Name} on team {Teame}";
        
    }
}
