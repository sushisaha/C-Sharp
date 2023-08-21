using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp.Basics.Delegates
{
    internal class PrivateStuff
    {
        public delegate void NoParamDelegate();
        public delegate void ParamDelegate(String msg);

        [Test]
        public void Delegates()
        {
            NoParamDelegate Aishu = ShowAllDataMethod;
            ParamDelegate Sruthi = PrintMessageMethod;

            InvokeDelegates.ShowAllData(Aishu);
            InvokeDelegates.PrintMessage(Sruthi);
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
