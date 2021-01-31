using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    public class BaseClass
    {
        int num;

        public BaseClass()
        {
            Console.WriteLine("This is from BaseClass()");
        }

        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("This is from BaseClass(int i)");
        }

        public int GetNum()
        {
            return num;
        }
    }
}
