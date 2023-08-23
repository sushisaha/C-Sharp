using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.LINQ
{
    internal class Range
    {
        [Test]
        public  void Main()
        {
            // generate number in the range
            var rangeNums = Enumerable.Range(1, 5); // generates 1 2 3 4 5
            Console.WriteLine("Range Nums:");
            foreach (var num in rangeNums)
                Console.WriteLine(num);

            // reapeat 5 times
            var repeatMessage = Enumerable.Repeat("Hola ", 5);
            Console.WriteLine("\nRepeat Message:");
            foreach (var msg in repeatMessage)
                Console.WriteLine(msg);
        }
    }
}
