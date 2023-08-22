using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Constructors
{
    public class Program
    {
        [Test]
        public void Main()
        {
            Class1 obj1 = new Class1(); // Non parameterized
            Class1 obj2 = new Class1(18, "Joey Tribbiani"); // Parameterized
            Class2 obj3 = new Class2(); // Default

            Console.WriteLine("Non parameterized contructor");
            obj1.Display();
            Console.WriteLine("Parameterized contructor");
            obj2.Display();
            Console.WriteLine("Default constructor");
            obj3.Display();
        }
    }
}
