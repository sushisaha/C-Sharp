using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Static
{
    public class Program
    {
        [Test]
        public void Main()
        {
            Console.WriteLine("Invoking Display() of StaticExample class without creating it's object\n");
            StaticExample.Display(); // invoking static method without object

            StaticExample.age += 10; // updating static variable without object
            Console.WriteLine("\nStatic age of StaticExample class: " + StaticExample.age);
        }

    }
}
