using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    public class Person
    {
        protected string ssn = "444-55-7777";
        protected string name = "Clain R. VC";

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
        }
    }
}
