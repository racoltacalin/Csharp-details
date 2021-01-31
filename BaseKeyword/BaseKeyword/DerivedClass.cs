using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    class DerivedClass : BaseClass
    {
        // This constructor will call BaseClass.BaseClass()
        public DerivedClass() : base()
        {
            Console.WriteLine("This is from DerivedClas() : base()");
        }

        // This constructor will call BaseClass.BaseClass(int i)
        public DerivedClass(int i) : base(i)
        {
            Console.WriteLine("This is from DerivedClas(int i) : base(i)");
        }
    }
}
