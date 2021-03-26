using System;
using DefineIMyInterface;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, string s)");
        }

        // This method is never called in ExtensionMethodsDemo1, because each
        // of the three classes A, B, and C implements a method named MethodB
        // that has a matching signature.
        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine("Extension.MethodB(this IMyInterface myInterface)");
        }
    }
}

// Define three classes that implement IMyInterface, and then use them to test
// the extension methods.
namespace ExtensionMethodsDemo1
{
    using System;
    using DefineIMyInterface;

    class A : IMyInterface
    {
        public void MethodB()
        {
            Console.WriteLine("A.MethodB()");
        }
    }

    class B : IMyInterface
    {
        public void MethodB()
        {
            Console.WriteLine("B.MethodB()");
        }
        public void MethodA(int i)
        {
            Console.WriteLine("B.MethodA(int i)");
        }
    }

    class C : IMyInterface
    {
        public void MethodB()
        {
            Console.WriteLine("C.MethodB()");
        }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }
}