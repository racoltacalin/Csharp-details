﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithLINQ
{
    public static class EnumerationSourceWithIteratorMethods
    {
        public static void Main()
        {
            var collection = GetSingleDigit();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }


        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            //yield return 0;
            //yield return 1;
            //yield return 2;
            //yield return 3;
            //yield return 4;
            //yield return 5;
            //yield return 6;
            //yield return 7;
            //yield return 8;
            //yield return 9;

            /// You can (and often do) use other language constructors to simplify the code of an iterator method
            /// The method definition below produces the exact same sequence of numbers!
            int index = 0;
            while (index < 10)
            {
                yield return index++;
            }
        }

        public static IEnumerable<int> GetSingleDigit()
        {
            int index = 0;
            while (index < 10)
            {
                yield return index++;
            }

            yield return 50;

            index = 100;
            while (index < 110)
            {
                yield return index++;
            }
        }

        //public static IEnumerable<T> Sample(this IEnumerable<T> sourceSequence, int interval)
        public static IEnumerable<int> Sample(this IEnumerable<int> sourceSequence, int interval)
        {
            int index = 0;
            foreach (var item in sourceSequence)
            {
                if (index++ % interval == 0)
                {
                    yield return item;
                }
            }
        }


        /// <summary>
        ///  There is one important restriction on iterator methods: you can't have both a return statement
        ///  and a yield return statement in the same method. The following will not compile:
        /// </summary>
        public static IEnumerable<int> GetSingleDigitFromNumbers()
        {
            int index = 0;
            while (index < 10)
            {
                yield return index++;
            }

            yield return 50;

            // This will generates a compile time error:
            var items = new int[] { 100, 100, 102, 103, 104, 105, 106, 107, 108, 109 };
            //return items;
            foreach (var item in items)
            {
                yield return item;
            }
        }

        ///  Sometimes, the right answer is to split an iterator method into two different methods. 
        ///  One that uses return, and a second that uses yield return. Consider a situation where 
        ///  you might want to return an empty collection, or the first 5 odd numbers, based on a 
        ///  boolean argument. You could write that as these two methods:
        public static IEnumerable<int> GetSingleDigitOddNumbers(bool getCollection)
        {
            if (getCollection == false)
            {
                return new int[0];
            }
            else
            {
                return IteratorMethod();
            }
        }

        private static IEnumerable<int> IteratorMethod()
        {
            int index = 0;
            while (index < 10)
            {
                if (index % 2 == 1)
                {
                    yield return index;
                }
                index++;
            }
        }
    }

}
