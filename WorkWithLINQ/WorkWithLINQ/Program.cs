using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            // It's important to keep in mind that whether you choose to write your LINQ in the query syntax
            // used above or use method syntax instead, it's always possible to go from one form of syntax
            // to the other. The above query written in query syntax can be written in method syntax as:
            // var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine();

            // 52 cards in a deck , so 52 / 2 =26
            //var top = startingDeck.Take(26);
            //var bottom = startingDeck.Skip(26);
            //var shuffle = top.InterleaveSequenceWith(bottom);

            var times = 0;
            // We can re-use the shuffle variable from earlier
            var shuffle = startingDeck;
            do
            {
                shuffle = shuffle.Take(26).InterleaveSequenceWith(shuffle.Skip(26));

                foreach (var card in shuffle)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();
                times++;

            } while (!startingDeck.SequenceEqual(shuffle));

            Console.WriteLine(times);
        }

        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }



    }
}
