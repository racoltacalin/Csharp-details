using GenericsDemo.Models;
using GenericsDemo.WithoutGenerics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Do not use an ArrayList 
            //ArrayList list = new ArrayList();

            //list.Add(23);
            //list.Add("Hello");

            //int val = (int)list[0];
            ////int val2 = (int)list[1];

            //List<int> ages = new List<int>();

            //ages.Add((int)23.5);

           
            Console.WriteLine();
            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Temp\people.csv";
            string logFile = @"C:\Temp\logs.csv";

            PopulateLists(people, logs);

            OriginalTextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($" {p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
            }

        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Clain", LastName = "Rvc" });
            people.Add(new Person { FirstName = "Cami", LastName = "Rvc" });
            people.Add(new Person { FirstName = "Greg", LastName = "Doucette", IsAlive = false});

            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
            logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });
        }
    }
}
