using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    public class Destroyer
    {
        public override string ToString() => GetType().Name;

        ~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
    }
}
