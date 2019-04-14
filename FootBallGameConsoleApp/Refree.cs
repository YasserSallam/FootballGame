using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDay
{
    //second subscriber
    class Refree
    {
        public string Name { get; set; }

        public override string ToString()
        => $"referee {Name}";

        public void look() {
            Console.WriteLine("refree is looking");
        }
    }
}
