using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Collections.Dictionaries
{
    public class Dictionaries
    {
        Dictionary<string, int> avengers; // declaring dictionary with string key and int value

        public void PrintDictionary()
        {
            Console.WriteLine("\nAvengers and thier age");
            foreach (var avenger in avengers)
                Console.WriteLine(avenger);
        }

        [Test]
        public void DictionaryExample()
        {
            avengers = new Dictionary<string, int>();

            avengers.Add("Iron Man", 53); // add items to dictionary
            avengers.Add("Spider Man", 19);
            avengers.Add("Captain America", 34);
            avengers.Add("Baby Groot", 4);
            avengers.Add("Black Widow", 39);
            PrintDictionary();

            avengers.Remove("Baby Groot"); // remove 'Baby Groot'
            Console.WriteLine("\nRemoved 'Baby Groot");
            PrintDictionary();

            avengers.Add("Hawkeye", 53); // add item at runtime
            Console.WriteLine("\nAdded ['Hawkeye', 53] at runtime");
            PrintDictionary();

            Console.WriteLine("\nAge of Spider Man is: " + avengers["Spider Man"]); // access value with key
        }
    }
}
