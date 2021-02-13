using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectGetHashCodeMethod
{
    // A type that represents a 2-D point.
    public struct Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            Point p = (Point)obj;
            return x == p.x & y == p.y;
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
}
