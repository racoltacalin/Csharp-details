using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    // The Point class is derived from System.Object.
    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            // If this and obj do not refer to the samy type, then they are not equal.
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            // Return true if x and y fields match.
            var other = (Point)obj;
            return (this.x == other.x) && (this.y == other.y);
        }

        // Return the XOR of the x and y fields.
        public override int GetHashCode()
        {
            return x ^ y;
        }

        // Return the point's value as a string
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // Return a copy of this point object by making a simple field copy
        public Point Copy()
        {
            return (Point)this.MemberwiseClone();
        }
    }
}
