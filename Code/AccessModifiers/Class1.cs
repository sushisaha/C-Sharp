using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.AccessModifiers
{
    public class Class1
    {
        private int salary = 50000; // available in same class only
        public String name = "Chandler Bing"; // available in different class
        protected int age = 37; // available in child class

        public void DisplayInParentClass()
        {
            Console.WriteLine("\nDetails displayed from parent class");
            Console.WriteLine("Salary: " + salary); // availabe here since same class
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}
