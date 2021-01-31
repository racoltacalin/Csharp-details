using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    public class Location
    {
        private string locationName;

        public Location(string name)
        {
            locationName = name;
        }

        public string Name => locationName;
    }
}
