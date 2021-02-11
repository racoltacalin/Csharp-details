using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionClass
{
    public class Example
    {
        public static void Main()
        {
            String s = "It was a cold day when...";
            int[] indexes = s.FindOccurrences("a");
            ShowOccurrences(s, "a", indexes);
            Console.WriteLine();

            String toFind = null;
            try
            {
                indexes = s.FindOccurrences(toFind);
                ShowOccurrences(s, toFind, indexes);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("An exception ({0}) occurred.",
                    e.GetType().Name);
                Console.WriteLine("Message:\n {0}\n", e.Message);
                Console.WriteLine("Stack Trace:\n {0}\n", e.StackTrace);
            }
        }

        private static void ShowOccurrences(String s, String toFind, int[] indexes)
        {
            Console.WriteLine("'{0}' occurs at the followubg cgaracter positions: ",
                toFind);
            for (int ctr = 0; ctr < indexes.Length; ctr++)
            {
                Console.Write("{0}{1}", indexes[ctr],
                    ctr == indexes.Length - 1 ? "" : ", ");
            }
            Console.WriteLine();
        }
    }
}
