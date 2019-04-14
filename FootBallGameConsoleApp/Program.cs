using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDay
{
    class Program
    {
        static void Main(string[] args)
        {

            Ball_Publisher ball = new Ball_Publisher() { ID = 1 };
            Player p1 = new Player() { Name = "P1", Teame = "Alahly" };
            Player p2 = new Player() { Name = "P2", Teame = "Alahly" };
            Player p3 = new Player() { Name = "P3", Teame = "Alahly" };
            Player p4 = new Player() { Name = "P4", Teame = "Alahly" };
            Refree r1 = new Refree() { Name = "r1" };

            //4-subscripton done here
            ball.locationChange += r1.look;
            ball.locationChange += p1.run;
            ball.locationChange += p2.run;
            ball.locationChange += p3.run;
            //subscrib with audians
            ball.locationChange += (Location l) => Console.WriteLine("audians are watching");
            ball.Location = new Location() { X = 1, Y = 1, Z = 12 };
            
            //change player unsubscrib to event and subscribe new player
            Console.WriteLine("-----after change----");
            ball.locationChange -= p1.run;
            ball.locationChange += p4.run;
            ball.Location = new Location() { X = -2, Y = -2, Z = -2 };
            Console.WriteLine("///////////////");
        }


    }
}
