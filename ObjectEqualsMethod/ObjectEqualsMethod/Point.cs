using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectEqualsMethod
{
    class Point
    {
        internal int x;
        internal int y;

        public Point(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public override bool Equals(object obj)
        {
            // Performs an equality check on two points (integer pairs).
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Point p = (Point)obj;
            return (x == p.x) && (y == p.y);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(x, y).GetHashCode();
        }
    }



    //class Point
    //{
    //    protected int x, y;
    //    public Point() : this(0, 0)
    //    { }
    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        // Check for null and compare run-time types.
    //        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            Point p = (Point)obj;
    //            return (x == p.x) && (y == p.y);
    //        }
    //    }

    //    public override int GetHashCode()
    //    {
    //        return (x << 2) ^ y;
    //    }

    //    public override string ToString()
    //    {
    //        return String.Format("Point({0}, {1})", x, y);
    //    }
    //}
}
