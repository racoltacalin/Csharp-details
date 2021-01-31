using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    public class LocationProperties
    {
        private string locationName;

        public LocationProperties(string name) => Name = name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }

    }
}
