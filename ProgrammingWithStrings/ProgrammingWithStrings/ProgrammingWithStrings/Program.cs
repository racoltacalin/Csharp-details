using System;
using System.Text;

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

            // The example displays the following output:
            //     The value of the string is ''
            //     Object reference not set to an instance of an object.
            String s = "";
            Console.WriteLine("The length of '{0}' is {1}.", s, s.Length);

            // The example displays the following output:
            //     The value of the string is ''
            //     Object reference not set to an instance of an object.

            String nullString = null;

            Console.WriteLine("The value of the string is '{0}'", nullString);

            //try
            //{
            //    Console.WriteLine("String length is {0}", nullString.Length);
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.WriteLine();

            string firstString = "A string is more ";
            string secondString = "than the sum of its chars.";

            // Concatenate s1 and s2. This actually creates a new
            // string object and stores it in s1, releasing the
            // reference to the original object.
            firstString += secondString;

            Console.WriteLine(firstString);

            string s10 = "Hello ";
            string s11 = s10;
            s10 += "World";

            Console.WriteLine(s11);

            string columns = "Column 1\tColumn 2\tColumn 3";
            Console.WriteLine(columns);

            Console.WriteLine();

            string rows = "Row 1\r\nRow 2\r\nRow 3";
            Console.WriteLine(rows);

            Console.WriteLine();

            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            Console.WriteLine(title);

            Console.WriteLine();

            string filePath = @"C:\Users\scoleridge\Documents\";
            Console.WriteLine(filePath);

            Console.WriteLine();

            string text = @"My pensive BETY ! thy soft cheek reclined
                Thus on mine arm, most soothing sweet it is
                To sit beside our Cot,...";
            Console.WriteLine(text);

            Console.WriteLine();

            string quote = @"Her name was ""Bety.""";
            Console.WriteLine(quote);

            Console.WriteLine();

            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

            Console.WriteLine();

            string s100 = "Visual C# Express";
            Console.WriteLine(s100.Substring(7, 2));

            Console.WriteLine();

            Console.WriteLine(s100.Replace("C#", "Basic"));

            Console.WriteLine();

            int index = s100.IndexOf("C");
            Console.WriteLine(index);

            Console.WriteLine();

            string s101 = "Printing backwards";
            for (int i = 0; i < s101.Length; i++)
            {
                Console.Write(s101[s101.Length - i - 1]);
            }

            Console.WriteLine();

            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            StringBuilder sb = new StringBuilder(question);

            for (int j = 0; j < sb.Length; j++)
            {
                if (Char.IsLower(sb[j]) == true)
                    sb[j] = Char.ToUpper(sb[j]);
                else if (Char.IsUpper(sb[j]) == true)
                    sb[j] = Char.ToLower(sb[j]);
            }

            // Store the new string.
            string corrected = sb.ToString();
            Console.WriteLine(corrected);

            Console.WriteLine();

            string numberInString = "ssdasfa 233 2 4 52";

            int numberOfDigits = 0;

            foreach (var character in numberInString)
            {
                if (char.IsDigit(character))
                    numberOfDigits++;
            }
            Console.WriteLine(numberOfDigits);

            Console.WriteLine();

            string helloString = "hello";
            string nullStr = null;
            string emptyStringHere = string.Empty;

            string tempStr = helloString + nullStr;
            Console.WriteLine(tempStr);

            Console.WriteLine();

            // The following line creates a new empty string.
            string newStr = emptyStringHere + nullStr;
            Console.WriteLine(newStr);

            Console.WriteLine();

            Console.WriteLine(emptyStringHere.Length);
            Console.WriteLine(newStr.Length);

            string s1000 = "\x0" + "abc";
            string s1001 = "abc" + "\x0";

            // Output of the following line: * abc*
            Console.WriteLine("*" + s1000 + "*");
            // Output of the following line: *abc *
            Console.WriteLine("*" + s1001 + "*");
            // Output of the following line: 4
            Console.WriteLine(s1001.Length);

            var stringBuilder = new StringBuilder("Rat: the ideal pet");
            stringBuilder[0] = 'C';
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
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
