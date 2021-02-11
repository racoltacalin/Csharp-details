using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofOperator
{
    public class Animal { }

    public class Giraffe : Animal { }

    public static class TypeOfExample
    {
        public static void Main()
        {
            object b = new Giraffe();
            Console.WriteLine("b is Animal: {0}", b is Animal);
            Console.WriteLine("b.GetType() == typeof(Animal): {0}", b.GetType() == typeof(Animal));

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("b is Giraffe: {0}", b is Giraffe);
            Console.WriteLine("b.GetType() == typeof(Giraffe): {0}", b.GetType() == typeof(Giraffe));
        }
    }
}
