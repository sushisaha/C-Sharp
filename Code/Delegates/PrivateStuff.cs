using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Delegates
{
    internal class PrivateStuff
    {
        public delegate void NoParamDelegate();
        public delegate void ParamDelegate(String msg);

        [Test]
        public void Delegates()
        {
            // assigning methods to delegates
            NoParamDelegate Aishu = ShowAllDataMethod;
            ParamDelegate Sruthi = PrintMessageMethod;

            // invoking delegates
            InvokePrivateStuff.ShowAllData(Aishu);
            InvokePrivateStuff.PrintMessage(Sruthi);
        }

        public static void ShowAllDataMethod()
        {
            Console.WriteLine("Showing all data");
        }

        public static void PrintMessageMethod(String msg)
        {
            Console.WriteLine("Printing message: " + msg);
        }
    }
}
