using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeEqualsMethod
{
    // Define a reference type that does not override Equals.
    public class Person
    {
        public string personName;

        public Person(string name)
        {
            this.personName = name;
        }

        public override string ToString()
        {
            return this.personName;
        }
    }
}
