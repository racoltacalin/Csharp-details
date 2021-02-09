using System;
using System.Text.Json;

namespace RecordTypesTestHarness
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //var dateTimeNow = DateTime.Now;
            //var blogPost1 = new BlogPost("My First Blog Post", "Clain RVC", "This is the post - 1", dateTimeNow);
            //var blogPost2 = new BlogPost("My First Blog Post", "Clain RVC", "This is the post - 1", dateTimeNow);
            //Console.WriteLine(blogPost1 == blogPost2);

            //// It is taking this blog post and it's destructuring it into these different variables on the left side
            //var (title, _, _, date) = blogPost1;

            //var roundTrippedBlog = JsonSerializer.Deserialize<BlogPost>(JsonSerializer.Serialize(blogPost1));
            //Console.WriteLine(roundTrippedBlog == blogPost1);

            // DailyTemperature
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

        }

        // DailyTemperature

        private static DailyTemperature[] data = new DailyTemperature[]
        {
            new DailyTemperature(HighTemp: 57, LowTemp: 30),
            new DailyTemperature(60, 35),
            new DailyTemperature(63, 33),
            new DailyTemperature(68, 29),
            new DailyTemperature(72, 47),
            new DailyTemperature(75, 55),
            new DailyTemperature(77, 55),
            new DailyTemperature(72, 58),
            new DailyTemperature(70, 47),
            new DailyTemperature(77, 59),
            new DailyTemperature(85, 65),
            new DailyTemperature(87, 65),
            new DailyTemperature(85, 72),
            new DailyTemperature(83, 68),
            new DailyTemperature(77, 65),
            new DailyTemperature(72, 58),
            new DailyTemperature(77, 55),
            new DailyTemperature(76, 53),
            new DailyTemperature(80, 60),
            new DailyTemperature(85, 66)
        };
    }
}
