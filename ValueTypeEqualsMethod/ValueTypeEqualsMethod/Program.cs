using System;

namespace ValueTypeEqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            byte value1 = 12;
            int value2 = 12;

            object object1 = value1;
            object object2 = value2;

            Console.WriteLine("{0} ({1}) = {2} ({3}): {4}",
                                object1, object1.GetType().Name,
                                object2, object2.GetType().Name,
                                object1.Equals(object2));

            Person person1 = new Person("Clain");
            Person person2 = new Person("Clain");

            Console.WriteLine("\nCalling Equals:");
            Console.WriteLine("person1.Equals(person2): {0}", person1.Equals(person2));

            Console.WriteLine("\nCasting to an Object and calling Equals:");
            Console.WriteLine("((object)person1).Equals((object)person2): {0}", ((object)person1).Equals((object)person2));
        }
    }
}
