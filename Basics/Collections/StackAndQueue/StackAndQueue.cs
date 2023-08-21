using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp.Basics.Collections.StackAndQueue
{
    internal class StackAndQueue
    {
        [Test]
        public void StackExample()
        {
            // stack creation
            Stack<String> friends = new Stack<String>();

            // add data
            friends.Push("Chandler"); // add item to stack top
            friends.Push("Joey");
            friends.Push("Phoebe");
            friends.Push("Rachel");
            friends.Push("Ross");
            friends.Push("Monica");

            // read data
            Console.WriteLine();
            foreach (String friend in friends)
                Console.WriteLine(friend);

            // read top of stack without popping
            Console.WriteLine(friends.Peek());


            // delete data
            Console.WriteLine();
            Console.WriteLine("Popped: " + friends.Pop()); // last item popped first
            Console.WriteLine("Popped: " + friends.Pop());

            Console.WriteLine();
            foreach (String friend in friends)
                Console.WriteLine(friend);

            // stack contains item
            Console.WriteLine();
            Console.WriteLine("Contains Ross? " + friends.Contains("Ross"));
            Console.WriteLine("Contains Rachel? " + friends.Contains("Rachel"));

            // item at specified index
            Console.WriteLine("\nItem at index 1: " + friends.ElementAt(1));

            // count of items in stack
            Console.WriteLine("\nCount: " + friends.Count);

            // update data


        }

        [Test]
        public void QueueExample()
        {
            // queue creation
            Queue<String> avengers = new Queue<String>();

            // add data
            avengers.Enqueue("Iron Man"); // add item to last of queue
            avengers.Enqueue("Captain America");
            avengers.Enqueue("Spider Man");
            avengers.Enqueue("Hulk");
            avengers.Enqueue("Black Widow");
            avengers.Enqueue("Ant Man");

            // read data
            Console.WriteLine();
            foreach (String avenger in avengers)
                Console.WriteLine(avenger);


            // delete data
            Console.WriteLine();
            Console.WriteLine("Deleted: " + avengers.Dequeue()); // last item popped first
            Console.WriteLine("Deleted: " + avengers.Dequeue());

            Console.WriteLine();
            foreach (String avenger in avengers)
                Console.WriteLine(avenger);

            // stack contains item
            Console.WriteLine();
            Console.WriteLine("Contains Iron Man? " + avengers.Contains("Iron Man"));
            Console.WriteLine("Contains Spider Man? " + avengers.Contains("Spider Man"));

            // item at specified index
            Console.WriteLine("\nItem at index 1: " + avengers.ElementAt(1));

            // count of items in queue
            Console.WriteLine("\nCount: " + avengers.Count);
        }
    }
}
