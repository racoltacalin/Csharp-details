using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_members
{
    public class Sports
    {
        private string[] types = { "Baseball", "Basketball", "Football", "Hockey", "Soccer", "Tennis", "Volleyball" };

        public string this[int i]
        {
            get => types[i];
            set => types[i] = value;
        }
    }
}
