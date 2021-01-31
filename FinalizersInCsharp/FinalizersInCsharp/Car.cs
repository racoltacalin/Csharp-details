using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizersInCsharp
{
    class Car
    {
        ~Car() // finalizer
        {
            // cleanup statments...
        }
    }
}
