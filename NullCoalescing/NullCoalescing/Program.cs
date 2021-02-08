using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = null;
            int? a = null;

            // The left-hand operand of the ??= operator must be a variable, a property, or an indexer element.
            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(a);

            // 1.
            Console.WriteLine("------");
            var sum = SumNumbers(null, 0);
            Console.WriteLine(sum);
            Console.WriteLine("------");

            // 2. 
            // 2.When you work with nullable value types and need to provide a value of an underlying value type,
            // use the ?? operator to specify the value to provide in case a nullable type value is null:
            int? c = null;
            int d = c ?? -1;
            Console.WriteLine(d);
            // Use the Nullable<T>.GetValueOrDefault() method if the value to be used when a nullable type value
            // is null should be the default value of the underlying value type.

            // 4. 
            // 4.Beginning with C# 8.0, you can use the ??= operator to replace the code of the form
            //if (variable is null)
            //{
            //    variable = expression;
            //}

            // with the following code:
            //variable ??= expression;
        }

        // In C# 7.3 and earlier, the type of the left-hand operand of the ?? operator must be either a
        // reference type or a nullable value type.
        // Beginning with C# 8.0, that requirement is replaced with the following: the type of the
        // left-hand operand of the ?? and ??= operators cannot be a non-nullable value type.
        // In particular, beginning with C# 8.0, you can use the null-coalescing operators with
        // unconstrained type parameters:
        private static void Display<T>(T a, T backup)
        {
            Console.WriteLine(a ?? backup);
        }

        // The ?? and ??= operators can be useful in the following scenarios:
        // 1.In expressions with the null-conditional operators ?. and ?[], you can use the ?? operator to
        // provide an alternative expression to evaluate in case the result of the expression with
        // null-conditional operations is null:
        static double SumNumbers(List<double[]> setOfNumbers, int indexOfSetToSum)
        {
            return setOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
        }

        // 3. Beginning with C# 7.0, you can use a throw expression as the right-hand operand of the ?? operator
        // to make the argument-checking code more concise:
        private string name;
        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot be null");
        }
    }
}
