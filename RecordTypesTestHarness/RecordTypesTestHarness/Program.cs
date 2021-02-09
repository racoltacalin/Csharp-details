using System;

namespace RecordTypesTestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTimeNow = DateTime.Now;
            var blogPost1 = new BlogPost("My First Blog Post", "Clain RVC", "This is the post - 1", dateTimeNow);
            var blogPost2 = new BlogPost("My First Blog sPost", "Clain RVC", "This is the post - 1", dateTimeNow);
            Console.WriteLine(blogPost1.Equals(blogPost2));
        }
    }
}
