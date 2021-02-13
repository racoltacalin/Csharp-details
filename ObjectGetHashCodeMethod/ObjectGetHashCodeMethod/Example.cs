using System;

namespace ObjectGetHashCodeMethod
{
    public class Example
    {
        public static void Main()
        {
            Random rnd = new Random();
            for (int ctr = 0; ctr <= 9; ctr++)
            {
                int randomN = rnd.Next(Int32.MinValue, Int32.MaxValue);
                Number n = new Number(randomN);
                Console.WriteLine("n = {0,12}, hash code = {1,12}", n, n.GetHashCode());
            }

            Console.WriteLine("------------------------------------------");

            Point pt = new Point(5, 8);
            Console.WriteLine("BEFORE: pt.GetHashCode(): {0}", pt.GetHashCode());

            pt = new Point(8, 5);
            Console.WriteLine("AFTER:  pt.GetHashCode(): {0}", pt.GetHashCode());

            pt = new Point(2, 2);
            Console.WriteLine("AFTER 2:  pt.GetHashCode(): {0}", pt.GetHashCode());

            Console.WriteLine("------------------------------------------");

            var newPt = new AlternativePointForSeparateHashCode(5, 8);
            Console.WriteLine("BEFORE: newPt.GetHashCode() : {0}", newPt.GetHashCode());

            newPt = new AlternativePointForSeparateHashCode(8, 5);
            Console.WriteLine("AFTER: newPt.GetHashCode() : {0}", newPt.GetHashCode());

            newPt = new AlternativePointForSeparateHashCode(2, 2);
            Console.WriteLine("AFTER 2: newPt.GetHashCode() : {0}", newPt.GetHashCode());
        }
    }
}
