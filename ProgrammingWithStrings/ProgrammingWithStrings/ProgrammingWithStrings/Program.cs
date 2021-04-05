using System;

namespace ProgrammingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare without initializing.
            string message1;

            // Initialize to null.
            string message2 = null;

            // Initialize as an empty string.
            // Use the Empty constant instead of the literal "".
            string message3 = "";
            string message4 = string.Empty;

            // Initialize with a regular string literal.
            string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

            // Initialize with a verbatim string literal.
            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

            // Use System.String if you prefer.
            System.String greeting = "Hello World!";

            // In local variables (i.e. within a method body)
            // you can use implicit typing.
            var temp = "I'm still a strongly-types System.String";

            // Use a const string to prevent 'message5' from
            // being used to store another string value.
            const string message5 = "You can't get rid of me!";

            // Use the String constructor only when creating
            // a string from a char*, char[], or sbyte*. See
            // System.String documentation for details.
            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);
            Console.WriteLine(alphabet);

            var emptyString = new string(string.Empty);
            if (string.IsNullOrEmpty(emptyString))
            {
                Console.WriteLine($"The string <{emptyString}> is Empty!");
            }

            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));

            Console.WriteLine();

            string s4 = null;
            string s5 = "";
            Console.WriteLine(TestForNullOrEmpty(s4));
            Console.WriteLine(TestForNullOrEmpty(s5));
        }

        public static String Test(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "is null or empty";
            else
                return String.Format("(\"{0}\") is neither null nor empty", s);
        }

        public static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = s == null || s == string.Empty;
            return result;
        }
    }
}
