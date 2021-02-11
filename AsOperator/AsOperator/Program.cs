using System;
using System.Collections;
using System.Collections.Generic;

namespace AsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new[] { 10, 20, 30, 40, 50 };
            IList<int> indexable = numbers as IList<int>;
            if (indexable != null)
            {
                Console.WriteLine(indexable[0] + indexable[indexable.Count - 1]);
            }
        }
    }
}
