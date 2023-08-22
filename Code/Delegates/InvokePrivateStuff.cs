using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Code.Delegates.PrivateStuff;

namespace CSharp.Code.Delegates
{
    internal class InvokePrivateStuff
    {
        public static void ShowAllData(NoParamDelegate del1)
        {
            del1(); // invoke delegate instead of actual method
        }

        public static void PrintMessage(ParamDelegate del2)
        {
            del2("Wohoo!!"); // invoke delegate with parameter
        }
    }
}
