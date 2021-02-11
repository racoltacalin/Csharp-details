using System;
using System.Text;

namespace NotesForCallers
{
    public class Example
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("building a string...");
            StringBuilder sb2 = new StringBuilder("building a string...");

            Console.WriteLine("sb1.Equals(sb2): {0}", sb1.Equals(sb2));
            Console.WriteLine("\n((Object)sb1).Equals(sb2): {0}", ((Object)sb1).Equals(sb2));
            Console.WriteLine("\nObject.Equals(sb1, sb2): {0}", Object.Equals(sb1, sb2));


            Object sb3 = new StringBuilder("building a string...");
            Console.WriteLine("\nsb3.Equals(sb2): {0}", sb3.Equals(sb2));


        }
    }
}
