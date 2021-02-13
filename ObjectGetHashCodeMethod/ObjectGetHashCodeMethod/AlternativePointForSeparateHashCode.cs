using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectGetHashCodeMethod
{
    public struct AlternativePointForSeparateHashCode
    {
        private int x;
        private int y;

        public AlternativePointForSeparateHashCode(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj is AlternativePointForSeparateHashCode)
            {
                var p = (AlternativePointForSeparateHashCode)obj;
                return x == p.x & y == p.y;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(x, y).GetHashCode();
        }
    }
}
