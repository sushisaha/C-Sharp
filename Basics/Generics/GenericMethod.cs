using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp.Basics.Generics
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
        }

        public T ReturnData<T>(T data)
        {
            return data;
        }
    }
}
