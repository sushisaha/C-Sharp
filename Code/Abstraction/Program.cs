using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Abstraction
{
    public class Program : Class1
    {
        public override void display() // abstract method of parent implemented in child class
        {
            Console.WriteLine("This is the implementation of display()");
        }

        [Test]
        public void Main()
        {
            Program obj = new Program();
            obj.display();
        }
    }
}
