using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Delegates
{
    internal class LambdaExpressions
    {
        public delegate void LambdaDel1(String msg); // single parameter
        public delegate void LambdaDel2(String msg1, String msg2); // multiple parameter
        public delegate void LambdaDel3(); // no parameter


        [Test]
        public void Main()
        {
            // Lambda syntax: parameters => statements

            // single parameter and single statement
            LambdaDel1 del1 = Message => Console.WriteLine("The message is: " + Message); 

            // multiple parameter and multiple statements
            LambdaDel2 del2 = (msg1, msg2) =>
            {
                Console.WriteLine("Message 1: " + msg1);
                Console.WriteLine("Message 2: " + msg2);
            };

            // no parameter
            LambdaDel3 del3 = () => Console.WriteLine("This delegate has no parameter");

            del1("Hey guys");
            Console.WriteLine();
            del2("How do you do", "All good?");
            Console.WriteLine();
            del3();
        }
    }
}
