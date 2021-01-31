using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    public class LocationConstructors
    {
        private string locationName;

        public LocationConstructors(string name) => Name = name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }

    }
}
