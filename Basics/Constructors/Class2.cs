using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.Constructors
{
    public class Class2
    {
        public int age; // initialized to 0 by default contructor
        public String name; // inirialized to null by default constructor
        public void Display()
        {
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Name: " + this.name);
        }
    }
}
