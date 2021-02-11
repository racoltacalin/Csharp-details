using System;

namespace ReferenceTypeEqualsMethod
{
    public class Example
    {
        public static void Main()
        {
            Person person1a = new Person("Clain");
            Person person1b = person1a;
            Person person2 = new Person(person1a.ToString());

            Console.WriteLine("Calling Equals:");
            Console.WriteLine("person1a and person1b => person1a.Equals(person1b): {0}", person1a.Equals(person1b));
            Console.WriteLine("person1a and person2  => person1a.Equals(person2): {0}", person1a.Equals(person2));

            Console.WriteLine("\nCasting to an Object and calling Equals:");
            Console.WriteLine("person1a and person1b => ((object) person1a).Equals((object) person1b): {0}", ((object)person1a).Equals((object)person1b));
            Console.WriteLine("person1a and person2  => ((object) person1a).Equals((object) person2): {0}", ((object)person1a).Equals((object)person2));

        }
    }
}
