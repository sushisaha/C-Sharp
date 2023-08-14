using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.AccessModifiers
{
    public class Program: Class1
    {   
        [Test]
        public void Display()
        {
            Program obj = new Program();
            Class1 c1 = new Class1();

            Console.WriteLine("\nDetails displayed in child class"); // private members not available
            Console.WriteLine("Name: " + obj.name); // public members available
            Console.WriteLine("Age: " + obj.age); // protected members available

            c1.DisplayInParentClass();
        }
        
    }
}
