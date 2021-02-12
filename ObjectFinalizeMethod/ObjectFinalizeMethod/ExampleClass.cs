using System;
using System.Diagnostics;

namespace ObjectFinalizeMethod
{
    public class ExampleClass
    {
        Stopwatch sw;

        public ExampleClass()
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object of {0}", this);
        }

        public void ShowDuration()
        {
            Console.WriteLine("This istance of {0} has been in existence for {1}",
                                this, sw.Elapsed);
        }

        ~ExampleClass()
        {
            Console.WriteLine("Finalizing object of {0}", this);
            sw.Stop();
            Console.WriteLine("This istance of {0} has been in existence for {1}",
                                this, sw.Elapsed);
        }
    }
}
