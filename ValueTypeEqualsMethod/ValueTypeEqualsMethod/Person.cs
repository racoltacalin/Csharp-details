using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEqualsMethod
{
    public struct Person
    {
        private string personName;

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
