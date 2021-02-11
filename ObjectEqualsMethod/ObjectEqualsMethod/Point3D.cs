using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectEqualsMethod
{
    sealed class Point3D : Point
    {
        int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public override bool Equals(object obj)
        {
            Point3D pt3 = obj as Point3D;
            if (pt3 == null)
            {
                return false;
            }
            else
            {
                return base.Equals((Point)obj) && z == pt3.z;
            }
        }

        public override int GetHashCode()
        {
            return (base.GetHashCode() << 2) ^ z;
        }

        public override string ToString()
        {
            return String.Format("Point({0}, {1}, {2})", x, y, z);
        }
    }
}
