using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Delegates
{
    internal class MulticastDelegate
    {
        public delegate void MultiDelegate();

        [Test]
        public void Main()
        {
            MultiDelegate Sushi;

            Sushi = Display1; // assign a method to delegate
            Sushi += Display2; // assign one more method of same signature to same delegate

            Sushi(); // single invocation executes both the methods (all methods assigned to the delegate)
            Console.WriteLine();

            Sushi -= Display1; // remove second method from delegate
            Sushi();

        }

        public static void Display1()
        {
            Console.WriteLine("Data 1");
        }

        public static void Display2()
        {
            Console.WriteLine("Data 2");
        }
    }
}
