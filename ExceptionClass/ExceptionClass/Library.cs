using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionClass
{
    public static class Library
    {
        public static int[] FindOccurrences(this String s, String f)
        {
            var indexes = new List<int>();
            int currentIndex = 0;
            try
            {
                while (currentIndex >= 0 && currentIndex < s.Length)
                {
                    currentIndex = s.IndexOf(f, currentIndex);
                }
                if (currentIndex >= 0)
                {
                    indexes.Add(currentIndex);
                    currentIndex++;
                }
            }
            catch (ArgumentNullException e)
            {
                // Perform some action here, such as logging this exception.
                throw;
            }
            return indexes.ToArray();
        }
    }
}
