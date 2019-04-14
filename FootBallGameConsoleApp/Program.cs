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

            Ball_Publisher ball = new Ball_Publisher() { ID = 1, Location = new Location() { X = 10, Y = 10, Z = 10 } };
            Player p1 = new Player() { Name = "ali", Teame = "Alahly" };
            Refree r1 = new Refree() { Name = "r1" };

            //4-subscripton done here
            ball.locationChange += p1.run;
            ball.locationChange += r1.look;
            ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            ball.Location = new Location() { X = 23, Y = 1, Z = 1 };
            ball.locationChange += () => Console.WriteLine("audians are watching");
            ball.Location = new Location() { X = 24, Y = 1, Z = 1 };

        }


    }
}
