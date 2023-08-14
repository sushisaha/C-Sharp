using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Assignments.Array
{
    internal class ArrayCodes
    {
        [Test]
        public void ReverseOfArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }

        [Test]
        public void CountOfEachElement()
        {
            int count;
            int[] arr = { 1, 2, 1, 6, 3, 4, 3, 3 };

            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] == int.MinValue)
                {
                    continue;
                }

                count = 1;
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = int.MinValue;
                    }
                }

                Console.WriteLine("'" + arr[i] + "': " + count);
            }
        }

        [Test]
        public void PrintDuplicateLocationsOfElements()
        {
            int[] arr = { 1, 2, 1, 6, 3, 4, 3, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == int.MinValue)
                {
                    continue;
                }
                Console.Write("'" + arr[i] + "': " + i + " ");

                for(int j=i+1; j<arr.Length; j++)
                {
                    

                    if (arr[i] == arr[j])
                    {
                        Console.Write(j + " ");
                        arr[j] = int.MinValue;
                    }
                }
                Console.WriteLine();
            }
        }

        [Test]
        public void CompareTwoArrays()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int flag = 0;

            if(arr1.Length != arr2.Length)
            {
                Console.WriteLine("Not equal");
                return;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    flag = 1;
                    Console.WriteLine("Not equal");
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Equal");
            }
        }

        [Test]
        public void PalindromeOrNot()
        {
            int flag = 0;
            String word = "veev veev";
            for (int i = 0, j = word.Length-1; i < (word.Length/2); i++, j--)
            {
                if (word[i] != word[j])
                {
                    flag = 1;
                    Console.WriteLine("Not palindrome");
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Palindrome");
            }
        }

        [Test]
        public void RemoveDuplicatesAndPrintRemaining()
        {
            int[] arr = { 1, 2, 1, 6, 3, 4, 3, 3 };
            int flag;

            for (int i = 0; i < arr.Length; i++)
            {
                flag = 0;
                if (arr[i] == int.MinValue)
                    continue;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        flag = 1;
                        arr[j] = int.MinValue;
                    }
                }
                if (flag == 1)
                    arr[i] = int.MinValue;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != int.MinValue)
                    Console.Write(arr[i] + " ");
            }
        }
    }
}
