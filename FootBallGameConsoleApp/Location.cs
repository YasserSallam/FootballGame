using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDay
{
    internal struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString() => $"({X},{Y},{Z})";
        public static bool operator ==(Location r, Location l) {

            return r.X == l.X && r.Y == l.Y && r.Z == l.Z;
        }
        public static bool operator !=(Location r, Location l)
        {
            return r.X != l.X || r.Y != l.Y || r.Z != l.Z;
        }
        public static Location operator -(Location r, Location l)
        {

            return new Location() { X = l.X - r.X, Y = l.Y - r.Y, Z = l.Z - r.Z };
        }
        public static Location operator +(Location r, Location l)
        {

            return new Location() { X = l.X + r.X, Y = l.Y + r.Y, Z = l.Z + r.Z };
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
