using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesForInheritors
{
    public class Person
    {
        private string idNumber;
        private string personName;

        public Person(string name, string id)
        {
            this.personName = name;
            this.idNumber = id;
        }

        public override bool Equals(object obj)
        {
            Person personObj = obj as Person;
            if (personObj == null)
            {
                return false;
            }
            else
            {
                return idNumber.Equals(personObj.idNumber);
            }
        }

        public override int GetHashCode()
        {
            return this.idNumber.GetHashCode();
        }
    }
}
