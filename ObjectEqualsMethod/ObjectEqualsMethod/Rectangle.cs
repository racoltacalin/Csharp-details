using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectEqualsMethod
{
    class Rectangle
    {
        private Point a, b;

        public Rectangle(int upLeftX, int upLeftY, int downRightX, int downRightY)
        {
            this.a = new Point(upLeftX, upLeftY);
            this.b = new Point(downRightX, downRightY);
        }

        public override bool Equals(object obj)
        {
            // Perfom an equality on two rectangles (Point object pairs).
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Rectangle r = (Rectangle)obj;
            return a.Equals(r.a) && b.Equals(r.b);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(a, b).GetHashCode();
        }

        public override String ToString()
        {
            return String.Format("Rectangle({0}, {1}, {2}, {3})",
                                a.x, a.y, b.x, b.y);
        }


    }
}
