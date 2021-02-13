using System;

namespace ObjectGetTypeMethod
{
    public class Test
    {
        public static void Main()
        {
            MyBaseClass myBase = new MyBaseClass();
            MyDerivedClass myDerived = new MyDerivedClass();

            object o = myDerived;
            //MyBaseClass b = myDerived;
            var b = myDerived;

            Console.WriteLine("myBase: Type is {0}", myBase.GetType());
            Console.WriteLine("myDerived: Type is {0}", myDerived.GetType());
            Console.WriteLine("object o = myDerived: Type is {0}", o.GetType());
            Console.WriteLine("MyBaseClass b = myDerived: Type is {0}", b.GetType());

            Console.WriteLine("-----------------------------------------");

            int n1 = 12;
            int n2 = 82;
            long n3 = 12;

            Console.WriteLine("n1 and n2 are the same type: {0}", Object.ReferenceEquals(n1.GetType(), n2.GetType()));

            Console.WriteLine("n1 and n3 are the same type: {0}", Object.ReferenceEquals(n1.GetType(), n3.GetType()));

            Console.WriteLine("-----------------------------------------");

            object[] values = { (int)12, (long)10653, (byte)12, (sbyte)-5, 16.3, "string" };

            foreach (var value in values)
            {
                Type t = value.GetType();

                if (t.Equals(typeof(byte)))
                {
                    Console.WriteLine("The value: {0} is an unsigned byte.", value);
                }
                else if (t.Equals(typeof(sbyte)))
                {
                    Console.WriteLine("The value: {0} is a signed byte.", value);
                }
                else if (t.Equals(typeof(int)))
                {
                    Console.WriteLine("The value: {0} is a 32-bit integer.", value);
                }
                else if (t.Equals(typeof(long)))
                {
                    Console.WriteLine("The value: {0} is a 32-bit integer.", value);
                }
                else if (t.Equals(typeof(double)))
                {
                    Console.WriteLine("The value: {0} is a double-precision floating point.", value);
                }
                else
                {
                    Console.WriteLine("The value: '{0}' is another data type.", value);
                }
            }
        }
    }
}
