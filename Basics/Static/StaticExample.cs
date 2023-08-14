using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.Static
{
    public class StaticExample
    {
        public static int age = 20; //  static variable

        public static void Display() // static method
        {
            Console.WriteLine("This is the static Display() method");
            Console.WriteLine("It is invoked directly as StaticExample.Display()");
            Console.WriteLine("The keyword 'static' ensures that an object is not required to invoke this method");
        }
    }
}
