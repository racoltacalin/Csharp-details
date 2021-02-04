using System;
using System.Linq;

namespace DeferredExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "abc", "def", "ghi", "jkl" };

            var query = from str in stringArray.ConvertCollectionToUpperCase()
                        select str;

            foreach (string str in query)
            {
                Console.WriteLine("Main: str {0}", str);
            }
        }
    }
}
