using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    //Readonly field example
    public class Age
    {
        public readonly int DayOfBirth = 12;
        readonly int year;
        Age(int year)
        {
            this.year = year;
        }

        void ChangeYear()
        {
            //year = 1967; // Compile error if uncommented.
        }

        public void ShowDayOfBirth()
        {
            Console.WriteLine("Day of birth is: {0}", DayOfBirth);
        }

        // How to create an object of type Age ?
        /*
        static void Main(string[] args)
        {

        }
        */
    }
}
