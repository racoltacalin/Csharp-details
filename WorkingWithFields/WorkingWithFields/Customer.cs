using System.Collections.Generic;

namespace WorkingWithFields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            /// A readonly field cannot be assigned to 
            /// (except in a constructor or a variable initializer)
            //Orders = new List<Order>();
            // ....
        }
    }
}
