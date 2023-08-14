using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.DataTypes
{
    public class DataTypes
    {
        [Test]
        public void DataTypeExample()
        {
            bool flag = true;
            char ch = 'S';
            int smallNumber = 925423652; // max 9 digits
            long hugeNumber = 946985698542985441; // max 18 digits
            float num1 = 13.52f; // f at the end is mandatory
            double num2 = 56.4511662;
            string name = "Sruthi"; // string is a class

            Console.WriteLine("bool: " + flag);
            Console.WriteLine("char: " + ch);
            Console.WriteLine("int: " + smallNumber);
            Console.WriteLine("long: " + hugeNumber);
            Console.WriteLine("float: " + num1);
            Console.WriteLine("double: " + num2);
            Console.WriteLine("string: " + name);
        }
    }
}
