using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.InheritanceAndPolymorphism
{
    public class Program: Class1 // inheritance
    {
        [Test]
        public void MethodOverloading()
        {
            Program shape = new Program();
            shape.Area(5); // square
            shape.Area(5, 10); // rectangle
            shape.Area(3, 3, 3); // traingle
        }

        [Test]
        public void MethodOverrinding()
        {
            Program obj1 = new Program();
            obj1.Display(); // displayig overrided method

            Class1 obj2 = new Class1();
            obj2.Display(); // displaying method of parent
        }

        public void Display() // method overriding
        {
            Console.WriteLine("This is display() in child class");
        }
    }
}
