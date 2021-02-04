using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // The following example shows an anonymous type that is initialized with two properties named Amount and Message.
            var anonymousType = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following  
            // statement to verify that their inferred types are int and string.  
            Console.WriteLine(anonymousType.Amount + " " + anonymousType.Message);

            var products = new List<Product>
                {
                    new Product() { Name = "ball", Color="blue", Price = 5.1M},
                    new Product() { Name = "mouse", Color="gray", Price = 10.436346M},
                    new Product() { Name = "dog", Color="brown", Price = 23.343M},
                    new Product() { Name = "rose", Color="red", Price = 100.2M},
                    new Product() { Name = "car", Color="black", Price = 200004.124124M},
                    new Product() { Name = "phone", Color="pink", Price = 4.234234M}
                };

            var productQuery =
                from prod in products
                select new { prod.Name, prod.Price };

            foreach (var p in productQuery)
            {
                Console.WriteLine("Name={0}\t->\tPrice={1}", p.Name, p.Price);
            }

            // You can create an array of anonymously typed elements by combining an implicitly typed local variable and an
            // implicitly typed array, as shown in the following example.
            var anonymousArray = new[]
            {
                new { Name = "apple", Diam = 4 },
                new { Name = "grape", Diam = 1 }
            };

        }
    }
}
