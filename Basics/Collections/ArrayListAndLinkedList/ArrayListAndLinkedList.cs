using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp.Basics.Collections.ArrayListAndLinkedList
{
    public class Collections
    {
        public ArrayList fruits;

        public void PrintArrayList() // print elements in ArrayList
        {
            foreach (var fruit in fruits)
                Console.WriteLine(fruit);
            Console.WriteLine();
        }

        [Test]
        public void ArrayListExample()
        {
            fruits = new ArrayList();

            fruits.Add("Apple"); // add item
            fruits.Add("Orange");
            fruits.Add("Mango");
            fruits.Add(3);
            fruits.Add("Pineapple");
            fruits.Add("Orange");

            //Console.WriteLine(fruits);

            PrintArrayList();

            fruits.Remove(3); // remove item 3
            Console.WriteLine("Removed 3");
            PrintArrayList();

            fruits.Sort(); // sort
            Console.WriteLine("Sorted arraylist");
            PrintArrayList();

            fruits.Remove("Orange"); // remove first occurrence of "Orange"
            Console.WriteLine("Remove first occurence of 'Orange'");
            PrintArrayList();

            fruits.Reverse(); // reverse
            Console.WriteLine("Reversed arraylist");
            PrintArrayList();

            fruits.Add("Grape"); // add item at runtime
            Console.WriteLine("Added 'Grape' at run time");
            PrintArrayList();

            Console.WriteLine("Count: " + fruits.Count); // size of arraylist

            Console.WriteLine("Is 'Apple' present? " + fruits.Contains("Apple")); // check if arraylist contains "Apple"
        }

        public LinkedList<string> avengers;

        public void PrintLinkedList() // print elements in ArrayList
        {
            foreach (var avenger in avengers)
                Console.WriteLine(avenger);
            Console.WriteLine();
        }

        [Test]
        public void LinkedListExample()
        {
            avengers = new LinkedList<string>();

            avengers.AddLast("Iron Man"); // add at the last
            avengers.AddLast("Spider Man");
            avengers.AddLast("Groot");
            avengers.AddLast("Captain America");
            avengers.AddLast("Black Widow");

            //Console.WriteLine(avengers);

            PrintLinkedList();

            avengers.Remove("Groot"); // remove "Groot"
            Console.WriteLine("Removed 'Groot'");
            PrintLinkedList();

            avengers.AddFirst("Ant Man"); // add at the beginning
            Console.WriteLine("Added 'Ant Man' at the beginning");
            PrintLinkedList();

            avengers.AddLast("Hawkeye"); // add item at runtime
            Console.WriteLine("Added 'Hawkeye' at run time");
            PrintLinkedList();

            Console.WriteLine("Is 'Groot' present? " + avengers.Contains("Groot")); // check if arraylist contains "Groot"

            Console.WriteLine("Count: " + avengers.Count); // size of linkedlist
        }
    }
}
