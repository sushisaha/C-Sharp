using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.LINQ
{
    internal class Collections
    {
        [Test]
        public void Main()
        {
            List<int> nums = new List<int>();
            nums.Add(64);
            nums.Add(90);
            nums.Add(24);
            nums.Add(49);
            nums.Add(90);

            Console.WriteLine("Nums List:");
            foreach (int num in nums)
                Console.WriteLine(num);

            // filter data where condition matches and join
            var numLessThan50 = nums.Where(n => n < 50);
            Console.WriteLine("\nNumbers less than 50: " + string.Join(", ", numLessThan50));
            
            // multiply each number by 2
            var doubleNums = nums.Select(n => n * 2);
            Console.WriteLine("\nDouble of Nums: " + string.Join(", ", doubleNums));

            // sort numbers in ascending order
            var ascendingNums = nums.OrderBy(n => n);
            Console.WriteLine("\nAscending order: " + string.Join(", ", ascendingNums));

            // sort numbers in descending order
            var descendingNums = nums.OrderByDescending(n => n);
            Console.WriteLine("\nDescending order: " + string.Join(", ", descendingNums));

            // group by condition, if true then left, else right
            var numSizeGroups = nums.GroupBy(n => n > 50 ? "Big" : "Small");
            Console.WriteLine();
            foreach (var group in numSizeGroups)
                Console.WriteLine(group.Key + ": " + string.Join(", ", group));

            // show only distinct numbers
            var distinctNums = nums.Distinct();
            Console.WriteLine("\nDistinct Nums: " + string.Join(", ", distinctNums));

            // check if all numbers satisfy the condition
            bool allEven = nums.All(n => n % 2 == 0);
            Console.WriteLine("\nAre all Nums even? " + string.Join(", ", allEven));

            // check if any number sarisfies the condition
            bool anyEven = nums.Any(n => n % 2 == 0);
            Console.WriteLine("\nIs any Num even? " + string.Join(", ", anyEven));

            // aggregate functions (sum, min, max, avg, count)
            int sum = nums.Sum();
            int min = nums.Min();
            int max = nums.Max();
            double avg = nums.Average();
            int count = nums.Count();

            Console.WriteLine("\nSum: " + sum);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Count: " + count);
        }
    }
}
