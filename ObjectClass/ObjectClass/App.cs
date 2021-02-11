using System;

namespace ObjectClass
{
    public sealed class App
    {
        static void Main()
        {
            // Construct a Point object.
            var p1 = new Point(1, 2);

            // Make another Point object that is a copy of the first.
            var p2 = p1.Copy();

            // Make another variable that references the first Point object.
            var p3 = p1;

            // The line below displays false because p1 and p2 refer to two different objects.
            Console.WriteLine("Object.ReferenceEquals(p1, p2) : {0}", Object.ReferenceEquals(p1, p2));

            // The line below displays true because p1 and p2 refer to two different objects that have the same value.
            Console.WriteLine("Object.Equals(p1, p2) : {0}", Object.Equals(p1, p2));

            // The line below displays true because p1 and p3 refer to one objects.
            Console.WriteLine("Object.ReferenceEquals(p1, p3) : {0}", Object.ReferenceEquals(p1, p3));

            // The line below displays: p1's value is: (1, 2)
            Console.WriteLine($"p1's value is: {p1.ToString()} and p2's value is : {p2.ToString()}");
        }
    }
}
