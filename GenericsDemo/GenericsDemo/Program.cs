using GenericsDemo.Models;
using GenericsDemo.WithGenerics;
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

            Console.ReadLine();

            DemonstrateTextFileStorage();

            Console.WriteLine();
            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Users\calin.racolta\Desktop\people.csv";
            string logFile = @"C:\Users\calin.racolta\Desktop\logs.csv";

            PopulateLists(people, logs);

            /* New way of doing things - generics*/
            GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
            GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($" { p.FirstName } { p.IsAlive }  (IsAlive = { p.IsAlive })");
            }

            Console.WriteLine();

            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

            foreach (var log in newLogs)
            {
                Console.WriteLine($" { log.ErrorCode } : { log.Message } at { log.TimeOfEvent.ToShortTimeString() }");
            }


            /* Old way of doing things - non-generics*/

            //OriginalTextFileProcessor.SaveLogs(logs, logFile);

            //var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);

            //foreach (var log in newLogs)
            //{
            //    Console.WriteLine($"{ log.ErrorCode }: { log.Message } at { log.TimeOfEvent.ToShortTimeString() }");
            //}

            /********
            //OriginalTextFileProcessor.SavePeople(people, peopleFile);

            //var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            //foreach (var p in newPeople)
            //{
            //    Console.WriteLine($" {p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
            //}
             ********/
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Clain", LastName = "Rvc" });
            people.Add(new Person { FirstName = "Cami", LastName = "Rvc" });
            people.Add(new Person { FirstName = "Greg", LastName = "Doucette", IsAlive = false });

            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
            logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });
        }
    }
}
