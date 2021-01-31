using System;

namespace BaseKeyword
{
    class TestClass
    {
        static void Main(string[] args)
        {
            // First Example - Person & Employee
            Employee E = new Employee();
            E.GetInfo();
            Console.WriteLine();

            // SecondExample - BaseClass & DerivedClass
            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(1);
        }
    }
}
