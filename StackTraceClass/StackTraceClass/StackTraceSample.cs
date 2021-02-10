using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StackTraceClass
{
    class StackTraceSample
    {
        [STAThread]
        static void Main(string[] args)
        {
            StackTraceSample sample = new StackTraceSample();
            try
            {
                sample.MyPublicMethod();
            }
            catch (Exception)
            {
                // Create a StackTrace that captures
                // filename, line number and column
                // information for the current thread.
                StackTrace st = new StackTrace(true);
                for (int i = 0; i < st.FrameCount; i++)
                {
                    // Note that at this level, there are four 
                    // stack frames, one for each method invocation.
                    StackFrame sf = st.GetFrame(i);
                    Console.WriteLine();
                    Console.WriteLine("High up the call stack, Method: {0}",
                        sf.GetMethod());

                    Console.WriteLine("High up the call stack, Line Number: {0}",
                        sf.GetFileLineNumber());

                }
            }
        }
        public void MyPublicMethod()
        {
            MyProtectedMethod();
        }

        protected void MyProtectedMethod()
        {
            MyInternalClass myInternalClass = new MyInternalClass();
            myInternalClass.ThrowsException();
        }

        class MyInternalClass
        {
            public void ThrowsException()
            {
                try
                {
                    throw new Exception("A problem was encountered in MyInternalClass.");
                }
                catch (Exception e)
                {
                    // Create a StackTrace that captures filename,
                    // line number and column information.
                    StackTrace st = new StackTrace(true);
                    string stackIndent = "";
                    for (int i = 0; i < st.FrameCount; i++)
                    {
                        // Note that at this level, there are four
                        // stack frames, one for each method invocation.
                        StackFrame sf = st.GetFrame(i);
                        Console.WriteLine();
                        Console.WriteLine(stackIndent + "Method: {0}",
                            sf.GetMethod());
                        Console.WriteLine(stackIndent + "File: {0}",
                            sf.GetFileName());
                        Console.WriteLine(stackIndent + "Line Number: {0}",
                            sf.GetFileLineNumber());
                        Console.WriteLine(stackIndent + "Type: {0}",
                            sf.GetType());
                        //stackIndent += " ";
                    }
                    throw e;
                }
            }
        }
    }
}

