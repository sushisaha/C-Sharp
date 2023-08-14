using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Basics.BreakAndContinue
{
    public class BreakAndContinue
    {
        [Test]
        public void BreakExample()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("\nBreak from the loop after " + arr[i-1]);
                    break; // break from the loop
                }
                Console.Write(arr[i] + " ");
            }
       }

        [Test]
        public void ContinueExample()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("\nContinue the loop after skipping " + arr[i]);
                    continue; // skip the current iteration and continue from the next iteration
                }
                Console.Write(arr[i] + " ");
            }
        }
    }
}
