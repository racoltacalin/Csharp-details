using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedEqualityOperator
{
    class MyClass
    {
        public static void Main()
        {
            Complex cmplx1, cmplx2;

            cmplx1.re = 4.0;
            cmplx1.im = 1.0;

            cmplx2.re = 2.0;
            cmplx2.im = 1.0;

            Console.WriteLine("{0} <> {1} : {2}", cmplx1, cmplx2, cmplx1 != cmplx2);
            Console.WriteLine("{0} <> {1} : {2}", cmplx1, cmplx2, cmplx1.Equals(cmplx2));

            cmplx2.re = 4.0;

            Console.WriteLine("{0} = {1}: {2}", cmplx1, cmplx2, cmplx1 == cmplx2);
            Console.WriteLine("{0} = {1}: {2}", cmplx1, cmplx2, cmplx1.Equals(cmplx2));

        }
    }
}
