using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Delegates
{
    internal class AnonymousDelegate
    {
        public delegate void AnonymousDel(String msg);

        [Test]
        public void Main()
        {
            // inline delegate
            AnonymousDel Sushi = new AnonymousDel( 
                delegate (String msg) // give method content in delegate constructor for single invocation
                {
                    Console.WriteLine("This is an anonymous method");
                    Console.WriteLine("Passed data: " + msg);
                }
                );

            Sushi("Holaa!!");
        }
    }
}
