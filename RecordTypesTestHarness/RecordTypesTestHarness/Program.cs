using System;
using System.Text.Json;

namespace RecordTypesTestHarness
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var dateTimeNow = DateTime.Now;
            var blogPost1 = new BlogPost("My First Blog Post", "Clain RVC", "This is the post - 1", dateTimeNow);
            var blogPost2 = new BlogPost("My First Blog Post", "Clain RVC", "This is the post - 1", dateTimeNow);
            Console.WriteLine(blogPost1 == blogPost2);

            // It is taking this blog post and it's destructuring it into these different variables on the left side
            var (title, _, _, date) = blogPost1;

            var roundTrippedBlog = JsonSerializer.Deserialize<BlogPost>(JsonSerializer.Serialize(blogPost1));
            Console.WriteLine(roundTrippedBlog == blogPost1);
        }
    }
}
