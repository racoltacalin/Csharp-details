using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizersInCsharp
{
    public class Destroyer
    {
        public override string ToString() => GetType().Name;

        ~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
    }

    /// <summary>
    ///  The finalizer implicitly calls Finalize on the base class of the object. 
    ///  Therefore, a call to a finalizer is implicitly translated to the following code:
    /// </summary>
    /*
    protected override void Finalize()
    {
        try
        {
            // Cleanup statements...
        }
        finally
        {

            base.Finalize();
        }
    }
    */
}
