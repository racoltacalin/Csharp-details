using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    class Employee : Person
    {
        public string id = "ABC234EFG";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }
}
