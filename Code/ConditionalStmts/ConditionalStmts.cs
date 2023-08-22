using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.ConditionalStmts
{
    internal class ConditionalStmts
    {
        // variable declatation can be outside methods
        // variable initialization should be inside a method

        int age1, age2;

        [Test]
        public void AgeComparison()
        {
            age1 = 22;
            age2 = 24;

            if (age1 == age2)
            {
                Console.WriteLine("Equal");
            }
            else // when if fails
            {
                Console.WriteLine("Not equal");
            }
        }

        [Test]
        public void IfElseLadder()
        {
            age1 = 12;

            if (age1 >= 18)
            {
                Console.WriteLine("Adult");
            }
            else if (age1 > 0 && age1 < 18) // when if fails
            {
                Console.WriteLine("Not adult");
            }
            else // when if and else if fails
            {
                Console.WriteLine("Invalid age");
            }
        }

        [Test]
        public void SwitchExample()
        {
            age1 = 18;

            switch (age1)
            {
                case 1: // if age==1
                    Console.WriteLine("One");
                    break;
                case 2: // else if age==2
                    Console.WriteLine("Two");
                    break;
                default: // else
                    Console.WriteLine("Older than 2");
                    break;
            }

        }

        [Test]
        public void Ternary()
        {
            age1 = 18;
            //string result = (age1 >= 18) ? "Adult" : "Not adult";
            //Console.WriteLine(result);

            Console.WriteLine(age1 >= 18 ? "Adult" : "Not adult"); // if age>=18 "Adult" else "Not adult"
        }
    }
}
