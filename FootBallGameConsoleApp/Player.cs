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

        //3- subscribere  define call back method 
        public void run() {
            Console.WriteLine($"{this} is runing");
        }
        public override string ToString() => $"{Name} on team {Teame}";
        
    }
}
