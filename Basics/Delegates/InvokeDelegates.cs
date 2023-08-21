using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicCSharp.Basics.Delegates.PrivateStuff;

namespace BasicCSharp.Basics.Delegates
{
    internal class InvokeDelegates
    {
        public static void ShowAllData(NoParamDelegate del1)
        {
            del1();
        }

        public static void PrintMessage(ParamDelegate del2)
        {
            del2("Wohoo!!");
        }
    }
}
