using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Generics
{
    internal class GenericMethod
    {
        [Test]
        public void GenericExample()
        {
            int intData = 50;
            Console.WriteLine("Integer data: " + ReturnData(intData));

            String stringData =  "Sushi Saha";
            Console.WriteLine("String data: " + ReturnData(stringData));

            int num1 = 50, num2 = 20;
            AddData(num1, num2);

            String str1 = "Sushi ", str2 = "Saha";
            AddData(str1, str2);
        }

        public T ReturnData<T>(T data)
        {
            return data;
        }

        public void AddData<T>(T data1, T data2)
        {
            T result = (dynamic) data1 + data2;
            Console.WriteLine(result);
        }
    }
}
