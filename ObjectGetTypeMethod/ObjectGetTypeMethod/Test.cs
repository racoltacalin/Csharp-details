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
            MyBaseClass b = myDerived;

            Console.WriteLine("myBase: Type is {0}", myBase.GetType());
            Console.WriteLine("myDerived: Type is {0}", myDerived.GetType());
            Console.WriteLine("object o = myDerived: Type is {0}", o.GetType());
            Console.WriteLine("MyBaseClass b = myDerived: Type is {0}", b.GetType());
        }
    }
}
