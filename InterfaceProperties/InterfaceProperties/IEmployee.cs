using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProperties
{
    interface IEmployee
    {
        string Name
        {
            get;
            set;
        }

        int Counter
        {
            get;
        }
    }
}
