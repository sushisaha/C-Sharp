using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.Collections.Arrays
{
    public class MultiDimensionalArrays
    {
        [Test]
        public void matrices()
        {
            int rows = 3, cols = 4;
            int[,] matrix = new int[rows, cols]; // declaration of matrix

            int element = 1;
            for (int i = 0; i < rows; i++) // traverse row
            {
                for (int j = 0; j < cols; j++) // traverse column for each row
                {
                    matrix[i, j] = element; // assignment
                    element++;
                }
            }

            for (int i = 0; i < rows; i++) // display
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
