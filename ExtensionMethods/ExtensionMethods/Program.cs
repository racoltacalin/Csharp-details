using System;
using static ExtensionMethods.MyExtensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Using LIQN - OrderBy Example:
            //UsingLinq.OrderByExample();

            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);
        }
    }
}
