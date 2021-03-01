using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsAlive { get; set; } = true;
    }
}
