using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProperties
{
    public class Employee : IEmployee //, ICitizen
    {
        /*
        // You could use the fully qualified name of the property, which references the interface
        // in which the member is declared. The example below demonstrates Explicit Interface Implementation:
        string IEmployee.Name
        {
            get { return "Employee Name"; }
            set { }
        }

        // For example, if the class Employee is implementing two interfaces ICitizen and IEmployee and both
        // interfaces have the Name property, the explicit interface member implementation will be necessary.
        string ICitizen.Name
        {
            get { return "Citizen Name"; }
            set { }
        }

        int IEmployee.Counter
        {
            get { return 1; }
        }
        */

        public static int numberOfEmployees;

        private string _name;
        public string Name // read-write instance property
        {
            get => _name;
            set => _name = value;
        }

        private int _counter;
        public int Counter // read-only instance property
        {
            get => _counter;
        }

        // Constructor
        public Employee() => _counter = ++numberOfEmployees;

        public static void Main()
        {
            Console.Write("Enter number of employees: ");
            //Employee.numberOfEmployees = int.Parse(Console.ReadLine());
            numberOfEmployees = int.Parse(Console.ReadLine());

            Employee e1 = new Employee();
            Console.Write("Enter the name of the new employee: ");
            e1.Name = Console.ReadLine();

            Console.WriteLine("The employee information:");
            Console.WriteLine("Employee number: {0}", e1.Counter);
            Console.WriteLine("Employee name: {0}", e1.Name);
        }


    }
}
