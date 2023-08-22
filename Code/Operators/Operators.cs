using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Operators
{
    public class Operators
    {
        [Test]
        public void ArithmeticOperators()
        {
            int a = 11, b = 5, result;

            result = a + b; // addition
            Console.WriteLine("Addition: " + result);
            result = a - b; // subtraction
            Console.WriteLine("Subtraction: " + result);
            result = a * b; // multiplication
            Console.WriteLine("Multiplicaiton: " + result);
            result = a / b; // division
            Console.WriteLine("Division: " + result);
            result = a % b; // modulus
            Console.WriteLine("Remainder: " + result);
        }

        [Test]
        public void LogicalOperators()
        {
            bool a = true, b = false, result;

            result = a && b; // AND - binary operator
            Console.WriteLine("a AND b: " + result);
            result = a || b; // OR - binary operator
            Console.WriteLine("a OR b: " + result);
            result = !a; // NOT - unary operator
            Console.WriteLine("NOT a: " + result);
            result = !b; 
            Console.WriteLine("NOT b: " + result);
            result = a ^ b; // exclusive OR
            Console.WriteLine("a XOR b: " + result);
        }

        [Test]
        public void RelationalOperators()
        {
            int a = 10, b = 5;
            bool result;

            result = a == b; // checking if a and b are equal
            Console.WriteLine("a equal to b: " + result);
            result = a != b; // checking if a and b are not equal
            Console.WriteLine("a not equal to b: " + result);
            result = a > b; // greater than
            Console.WriteLine("a greater than b: " + result);
            result = a < b; // less than
            Console.WriteLine("a less than b: " + result);
            result = a >= b; // greater than or equal to
            Console.WriteLine("a greater than or equal to b: " + result);
            result = a <= b; // less than or equal to
            Console.WriteLine("a less than or equal to b: " + result);
        }

        [Test]
        public void AssignmentOperators()
        {
            int result = 10; // simple assignment

            result += 5; // result = result + 5
            Console.WriteLine("result += 5: " + result);
            result -= 3; // result = result -3
            Console.WriteLine("result -= 3: " + result);
            result *= 10; // result = result * 10
            Console.WriteLine("result *= 10: " + result);
            result /= 10; // result = result / 10
            Console.WriteLine("result /= 10: " + result);
            result %= 2; // result = result % 2
            Console.WriteLine("result %= 2: " + result);
        }

        [Test]
        public void BitwiseOperators()
        {
            int a = 4, b = 1, result;

            result = a & b; // 0100 AND 0001 gives 0000
            Console.WriteLine("Bitwise AND: " + result);
            result = a | b; // 0100 OR 0001 gives 0101
            Console.WriteLine("Bitwise AND: " + result);
            result = a ^ b; // 0100 ^ 0001 gives 0101
            Console.WriteLine("Bitwise XOR: " + result);
            result = ~b; // ~0001 gives 1110, its 2s complement is -2
            Console.WriteLine("Bitwise complement of b: " + result);
            result = b << 2; // 0001 << 2 gives 0100
            Console.WriteLine("Bitwise left shift b by 2: " + result);
            result = a >> 2; // 0100 >> 2 gives 0001
            Console.WriteLine("Bitwise right shift a by 2: " + result);
        }

        [Test]
        public void ConditionalOperator()
        {
            int a = 11, b = 9, big;
            big = (a > b) ? a : b; // if a>b big=a else big=b

            Console.WriteLine("The bigger number is: " + big);
        }
    }
}
