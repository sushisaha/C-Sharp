using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.LINQ
{
    internal class Conversion
    {
        [Test]
        public void Main()
        {
            // create nums list
            List<int> numsList = new List<int>();
            numsList.Add(64);
            numsList.Add(90);
            numsList.Add(24);
            numsList.Add(49);
            numsList.Add(90);

            // display nums list
            Console.WriteLine("Nums List:");
            foreach (int num in numsList)
                Console.WriteLine(num);

            // ToArray
            int[] numsArray = numsList.ToArray();
            Console.WriteLine("\nToArray:");
            foreach (var num in numsArray)
                Console.WriteLine(num);

            // create avengers array of strings
            String[] avengersArray = { "Iron Man", "Spider Man", "Ant Man", "Captain America", "Black Widow" };

            // display avengers array of strings
            Console.WriteLine("\nAvengers Array:");
            for (int i=0; i < avengersArray.Length; i++)
                Console.WriteLine(avengersArray[i]);

            // ToList
            List<string> avengersList = avengersArray.ToList();
            Console.WriteLine("\nToList:");
            foreach (var avenger in avengersList)
                Console.WriteLine(avenger);

            // ToDictionary
            var avengerLengthDictionary = avengersArray.ToDictionary(avenger => avenger, avenger => avenger.Length);
            Console.WriteLine("\nToDictionary (avenger: length):");
            foreach (var keyValPair in avengerLengthDictionary)
                Console.WriteLine(keyValPair.Key + ": " + keyValPair.Value);
        }
    }
}
