using System;
using System.Text;

namespace StringBuilderProgrammingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }
            Console.WriteLine(sb);

            sb[0] = sb[9];

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
