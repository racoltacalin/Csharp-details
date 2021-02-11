﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionClass
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            // This implementation contains an error in program logic:
            // It assumes that the obj argument is not null.
            Person p = (Person)obj;
            return this.Name.Equals(p.Name);
        }

        public class Example
        {
            public static void Main()
            {

            }
        }
    }
}
