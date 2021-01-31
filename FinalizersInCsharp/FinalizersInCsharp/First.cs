using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizersInCsharp
{
    public class First
    {
        ~First()
        {
            System.Diagnostics.Trace.WriteLine("Firt's finalizer is called.");
        }
    }

    public class Second : First
    {
        ~Second()
        {
            System.Diagnostics.Trace.WriteLine("Second's finalizer is called.");
        }
    }

    public class Third : Second
    {
        ~Third()
        {
            System.Diagnostics.Trace.WriteLine("Third's finalizer is called.");
        }
    }
}
