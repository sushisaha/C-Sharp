using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.Loops
{
    internal class Loops
    {

        [Test]
        public void ForLoop() // entry controlled
        {
            for (int i = 0; i < 5; i++) // i from 0 to 4
            {
                Console.WriteLine(i);
            }
        }

        [Test]
        public void WhileLoop() // entry controlled
        {
            int i = 0;
            while (i < 5) // i from 0 to 4
            {
                Console.WriteLine(i);
                i++;
            }
        }

        [Test]
        public void DoWhileLoop() // exit controlled
        {
            int i = 0;
            do // do is executed at least once
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5); // i from 0 to 4
        }
    }
}
