using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProperties
{
    // Properties can be declared on an interface. The following example declares an interface property accessor:
    public interface ISampleInterface
    {
        // Property declaration:
        public string Name
        {
            get;
            set;
        }
    }
}
