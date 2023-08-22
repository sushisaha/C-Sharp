using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Delegates
{
    internal class GenericDelegate
    {
        [Test]
        public void Main()
        {
            // ready made delegates - Func, Action, Predicate


            // --------- Func (input + return) ---------
            Console.WriteLine("--------- Func (input + return) ---------");

            // single parameter
            Func<String, String> del1 = msg => "Message: " + msg;
            // 2 parameters, 1 return (takes last type as return and rest as parameters)
            Func<String, String, String> del2 = (msg1, msg2) => "Message1: " + msg1 + "\nMessage2: " + msg2;

            Console.WriteLine("Func with single parameter");
            Console.WriteLine(del1("Hey"));
            Console.WriteLine("\nFunc with multiple parameters");
            Console.WriteLine(del2("Hello", "There"));


            // --------- Action (no return) ---------
            Console.WriteLine("\n--------- Action (no return) ---------");

            // single parameter, no return
            Action<String> del3 = msg => Console.WriteLine("Message: " + msg);
            // 2 parameters, no return
            Action<String, String> del4 = (msg1, msg2) => Console.WriteLine("Message1: " + msg1 + "\nMessage2: " + msg2); 

            Console.WriteLine("\nAction with single parameter");
            del3("Hola"); // not returning anything
            Console.WriteLine("\nAction with multiple parameters");
            del4("Como", "Estas"); // not returning anything


            // --------- Predicate (no return) ---------
            // - validates an expression and returns true or false, but return type cant be sepcified
            Console.WriteLine("\n--------- Predicate (no return) ---------");

            // predicate can have only one parameter
            Predicate<int> AgeGreaterThan18 = age => age >= 18;
            Console.WriteLine("\nAge greater than 18? " + AgeGreaterThan18(22));

            // predicate with list
            List<int> ages = new List<int>();
            ages.Add(17);
            ages.Add(24);
            ages.Add(6);
            ages.Add(47);

            int data = ages.Find(AgeGreaterThan18); // retrieves first occurrence of true data
            Console.WriteLine(data);
            Console.WriteLine();

            List<int> ageList = ages.FindAll(AgeGreaterThan18); // retrieves all occurrences of true data
            foreach (int age in ageList)
                Console.WriteLine(age);

            Console.WriteLine("\n--------- Binary Expression ---------");
            // (20 * 10) + (10 - 3)
            BinaryExpression B1 = Expression.MakeBinary(ExpressionType.Multiply, Expression.Constant(20), Expression.Constant(10));
            BinaryExpression B2 = Expression.MakeBinary(ExpressionType.Subtract, Expression.Constant(10), Expression.Constant(3));
            BinaryExpression B3 = Expression.MakeBinary(ExpressionType.Add, B1, B2);
            int result = Expression.Lambda<Func<int>>(B3).Compile()();

            Console.WriteLine("Expression: (20 * 10) + (10 - 5)");
            Console.WriteLine("Result: " + result);

            //// (20 * 10) + (10 ^ 3)
            //BinaryExpression B4 = Expression.MakeBinary(ExpressionType.Multiply, Expression.Constant(20), Expression.Constant(10));
            //BinaryExpression B5 = Expression.MakeBinary(ExpressionType.Power, Expression.Constant(10), Expression.Constant(3));
            //BinaryExpression B6 = Expression.MakeBinary(ExpressionType.Add, B1, B2);
            //int result2 = Expression.Lambda<Func<int>>(B3).Compile()();

            //Console.WriteLine("Expression: (20 * 10) + (10 ^ 5)");
            //Console.WriteLine("Result: " + result2);
        }
    }
}
