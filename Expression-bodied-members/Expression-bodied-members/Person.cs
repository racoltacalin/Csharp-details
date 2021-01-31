using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    public class Person
    {
        private string fName;
        private string lName;
        public Person(string firstName, string lastName)
        {
            fName = firstName;
            lName = lastName;
        }

        public override string ToString() => $"{fName} {lName}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }
}
