using System;

namespace IsOperator
{
    public class Base { }

    public class Derived : Base { }

    public static class IsOperatorExample
    {
        public static void Main()
        {
            object b = new Base();
            Console.WriteLine("b is Base: {0}", b is Base);
            Console.WriteLine("b is Derived: {0}", b is Derived);

            Console.WriteLine("---------------------------------");

            object d = new Derived();
            Console.WriteLine("d is Base: {0}", d is Base);
            Console.WriteLine("d is Derived: {0}", d is Derived);

            Console.WriteLine("---------------------------------");

            int i = 27;
            Console.WriteLine("i is System.IFormattable: {0}", i is System.IFormattable);

            Console.WriteLine("---------------------------------");

            object iBoxed = i;
            Console.WriteLine("iBoxed is int: {0}", iBoxed is int);
            Console.WriteLine("iBoxed is long: {0}", iBoxed is long);

            Console.WriteLine("---------------------------------");

            int j = 23;
            object jBoxed = j;
            int? jNullable = 7;
            if (jBoxed is int x && jNullable is int y)
            {
                Console.WriteLine(x + y);
            }
        }
    }

}
