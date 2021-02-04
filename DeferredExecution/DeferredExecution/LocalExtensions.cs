using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredExecution
{
    public static class LocalExtensions
    {
        // Use the yield return construct in an extension method to defer execution
        public static IEnumerable<string>
            ConvertCollectionToUpperCase(this IEnumerable<string> source)
        {
            foreach (string str in source)
            {
                Console.WriteLine("ToUpper: source {0}", str);
                yield return str.ToUpper();
            }
        }
    }
}
