using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.Arrays
{
    internal class Arrays
    {
        [Test]
        public void ArrayExample()
        {
            int[] arr = new int[10]; // declaration
            arr[0] = 100; // assignment

            int[] arr2 = { 1, 2, 3, 4, 5 }; // declaration with initialization

            for (int i = 0; i < arr2.Length; i++) // traversal
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
