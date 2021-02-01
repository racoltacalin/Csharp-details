using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Age
    {
        readonly int year;
        Age(int year)
        {
            this.year = year;
        }

        void ChangeYear()
        {
            //year = 1967; // Compile error if uncommented.
        }
    }
}
