using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Constructors
{
    public class Class1
    {
        public int age;
        public String name;

        public Class1() // non parameterized constructor
        {
            this.age = 22;
            this.name = "Sruthi";
        }

        public Class1(int age, String name) // parameterized constructor
        {
            this.age = age;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Name: " + this.name);
        }
    }
}
