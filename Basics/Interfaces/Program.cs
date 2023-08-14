using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.Interfaces
{
    public class Program: Interface1
    {
        public int AreaOfSquare(int side) // all methods in interface should be defined in child class
        {
            return side * side;
        }

        [Test]
        public void Main()
        {
            Program obj = new Program();
            Console.WriteLine("Area of square is: " + obj.AreaOfSquare(5));
        }
    }
}
