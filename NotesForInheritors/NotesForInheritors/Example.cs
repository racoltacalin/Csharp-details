using System;

namespace NotesForInheritors
{
    class Example
    {
        static void Main()
        {
            Person p1 = new Person("Clain", "123456789");
            Person p2 = new Person("Jack", "123456789");
            Person p3 = new Person("Jack", "1234");

            Console.WriteLine("p1.Equals(p2): {0}", p1.Equals(p2));
            Console.WriteLine("Object.Equals(p1,p2) : {0}", Object.Equals(p1, p2));

            Console.WriteLine("----------------------------");

            Console.WriteLine("p1.Equals(p3): {0}", p1.Equals(p3));
            Console.WriteLine("Object.Equals(p1,p3) : {0}", Object.Equals(p1, p3));

        }
    }
}
