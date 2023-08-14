using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.Encapsulation
{
    public class Program
    {
        [Test]
        public void Main()
        {
            Class1 obj1 = new Class1();
            Console.WriteLine("Salary of obj1: " + obj1.Salary); // getter increments actual salary by 10000
            obj1.Salary = 20000; // setter sets salary for obj1 as 20000
            Console.WriteLine("Salary of obj1 after setting a value: " + obj1.Salary); // getter increments the set salary for obj1 by 10000
          
            Class1 obj2 = new Class1();
            Console.WriteLine("Salary of obj2: " + obj2.Salary); // setter for obj1 doesn't affect value in obj2
        }
    }
}
