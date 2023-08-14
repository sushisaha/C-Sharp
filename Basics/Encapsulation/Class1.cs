using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.Encapsulation
{
    public class Class1
    {
        private int salary = 50000; //private variable

        public int Salary // public property
        {
            get
            {
                return salary + 10000;
            }
            set
            {
                salary = value;
            }
        }
    }
}
