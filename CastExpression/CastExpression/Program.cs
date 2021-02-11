using System;
using System.Collections;
using System.Collections.Generic;

namespace CastExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1234.7;
            int a = (int)x;
            Console.WriteLine(a);

            IEnumerable<int> numbers = new int[] { 10, 20, 30, 40, 50 };
            IList<int> list = (IList<int>)numbers;
            Console.WriteLine(list.Count);
            Console.WriteLine(list[1]);
        }
    }
}
