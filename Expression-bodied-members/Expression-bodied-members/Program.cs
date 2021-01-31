using System;
using System.Security.Cryptography.X509Certificates;

namespace Expression_bodied_members
{
    class Program
    {
        static void Main(string[] args)
        {
            /// METHODS
            // An expression-bodied method consists of a single expression that returns a value whose type matches
            // the method's return type, or, for methods that return void, that performs some operation.
            // For example, types that override the ToString method typically include a single expression that
            // returns the string representation of the current object.
            var person = new Person("Clain", "Rvc");
            Console.WriteLine(person);
            person.DisplayName();

            /// READ-ONLY PROPERTIES
            // Starting with C# 6, you can use expression body definition to implement a read-only property.
            // To do that, use the following syntax:
            // PropertyType PropertyName => expresion;

            /// PROPERTIES
            // Starting with C# 7.0, you can use expression body definitions to implement property get and set accessors.

            /// CONSTRUCTORS
            // An expression body definition for a constructor typically consists of a single assignment expression or a method
            // call that handles the constructor's arguments or initializes instance state.

            /// FINALIZERS
            // An expression body definition for a finalizer typically contains cleanup statements, such as statements
            // that release unmanaged resources.

            /// INDEXERS
            // Like with properties, indexer get and set accessors consist of expression body definitions if the get accessor
            // consists of a single expression that returns a value or the set accessor performs a simple assignment.
        }
    }
}
