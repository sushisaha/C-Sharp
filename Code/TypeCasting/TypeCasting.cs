using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.TypeCasting
{
    public class TypeCasting
    {
        [Test]
        public void ImplicitConversion()
        {
            int num = 23;
            double doubleNum = num; // num implicitly converted from int to double
            Console.WriteLine("Actual int value");
            Console.WriteLine(num);
            Console.WriteLine("Implicit type conversion to double");
            Console.WriteLine(doubleNum.ToString("F2"));

            char c = 'A';
            int intc = c; // c implicitly converted from char to int
            Console.WriteLine("\nActual char value");
            Console.WriteLine(c);
            Console.WriteLine("Implicit type conversion to int");
            Console.WriteLine(intc);
        }

        [Test]
        public void ExplicitConversion()
        {
            double doubleNum = 45.432;
            int num = (int)doubleNum; // Explicitly type casting double to int
            Console.WriteLine("Actual double value");
            Console.WriteLine(doubleNum);
            Console.WriteLine("Type casted to int");
            Console.WriteLine(num);
            

            int intc = 65;
            char c = (char)intc; // Explicitly type casting from int to char
            Console.WriteLine("\nActual int value");
            Console.WriteLine(intc);
            Console.WriteLine("Type casted to char");
            Console.WriteLine(c);          
        }
    }
}
