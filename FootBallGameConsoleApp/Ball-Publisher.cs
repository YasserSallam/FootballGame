using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDay
{
    //Publisher 
    //declare event
   // public  delegate void mydelegat(int x);
    class Ball_Publisher
    {
        #region simplicity
        //public static  mydelegat d = test;                
        //  public static void test(int x) {
        //      Console.WriteLine(x*x);
        //  } 
        #endregion

        //1- declare event  take one args send it to subscribers
        public event Action<Location> locationChange;   
        public int ID { get; set; }
        Location location;
        internal Location Location
        {
            get => location;
            set
            {
                Location distance = value + location;
                if (value != location)
                {
                    location = value;
                    //2-notify subscribers
                    //locationChange();         //unsafe
                    locationChange?.Invoke(distance);   //safe if no subscriber
                }
            }
        } 
        public override string ToString() => $"{ID} , === {location}";        
    }
}
