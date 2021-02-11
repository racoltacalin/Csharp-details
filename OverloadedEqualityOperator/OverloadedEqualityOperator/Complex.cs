using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedEqualityOperator
{
    public struct Complex
    {
        public double re, im;

        public override bool Equals(object obj)
        {
            return obj is Complex && this == (Complex)obj;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(re, im).GetHashCode();
        }

        public static bool operator ==(Complex x, Complex y)
        {
            return x.re == y.re && x.im == y.im;
        }

        public static bool operator !=(Complex x, Complex y)
        {
            return !(x == y);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", re, im);
        }
    }
}
