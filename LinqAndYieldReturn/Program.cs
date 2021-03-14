using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDetails
{
    class Program
    {
        static void Main()
        {
            var source = new List<string>() { "hi", "lol", "insanguination", "bye", "Nebuchadnezzar" };

            var linqResult = source
                .Where(n => n.Length > 10)
                .Select(n => n.ToUpper());

            var listFilter = LongerThanTen(source);
            var listMap = ToUppercase(listFilter);

            source.Add("defenestration");

            Print(linqResult);
            Print(listMap);
        }

        private static IEnumerable<string> LongerThanTen(IEnumerable<string> collection)
        {
            // List<string> longWords = new List<string>();
            foreach (string word in collection)
            {
                if (word.Count() > 10)
                {
                    //longWords.Add(word);
                    yield return word;
                }
            }
            // yield return longWords;
        }

        private static IEnumerable<string> ToUppercase(IEnumerable<string> collection)
        {
            //List<string> upperCaseWords = new List<string>();
            foreach (string word in collection)
            {
                //upperCaseWords.Add(word.ToUpper());

                yield return word.ToUpper();
            }
            //return upperCaseWords;
        }

        private static void Print(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
