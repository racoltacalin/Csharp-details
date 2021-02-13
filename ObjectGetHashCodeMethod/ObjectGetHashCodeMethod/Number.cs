using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectGetHashCodeMethod
{
    public struct Number
    {
        private int n;

        public Number(int value)
        {
            n = value;
        }

        public int Value
        {
            get
            {
                return n;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Number))
            {
                return false;
            }
            else
            {
                return n == ((Number)obj).n;
            }
        }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
