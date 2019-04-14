using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDay
{
            //Publisher 
            //declare event
    class Ball_Publisher
    {
        //1- declare event
        public event Action locationChange;
        public int ID { get; set; }
        Location location;
        internal Location Location
        {
            get => location;
            set
            {
                if (value != location)
                {
                    location = value;
                    //2-notify subscribers
                    //locationChange();         //unsafe
                    locationChange?.Invoke();   //safe if no subscriber
                }
            }
        } 
        public override string ToString() => $"{ID} , === {location}";        
    }
}
