using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.StringOperations
{
    public class StringOperations
    {
        [Test]
        public void Concatenation()
        {
            String s1 = "Sruthi";
            String s2 = "Sagar";
            String fullName = s1 + " " + s2; // using plus symbol
            String fullNameAgain = String.Concat(s1, " ", s2); // using concat method
            Console.WriteLine("With plus symbol: " + fullName);
            Console.WriteLine("With concat method: " + fullNameAgain);
        }

        [Test]
        public void Formatting()
        {
            String comic1 = "Marvel", comic2 = "DC";
            // comic1 and comic 2 goes to index 0 and 1 respectively
            Console.WriteLine("I love {0} more than {1}", comic1, comic2);
        }

        [Test]
        public void SubStrings()
        {
            String message = "My name is Sruthi Sagar";
            String name = message.Substring(11, 6); // 11 - starting index, 6 - length
            Console.WriteLine(name);
        }

        [Test]
        public void StringLength()
        {
            String name = "Sruthi Sagar";
            // Length gives length of the string
            Console.WriteLine("String length: " + name.Length);
        }

        [Test]
        public void IndexOfCharacterOrString()
        {
            String name = "Chandler Bing";
            Console.WriteLine("Index of 'n': " + name.IndexOf('n')); // index of character
            // index of first character of string
            Console.WriteLine("Index of Bing: " + name.IndexOf("Bing"));
            Console.WriteLine("Index of 's': " + name.IndexOf('s'));
        }

        [Test]
        public void Uppercase()
        {
            String name = "Joey Tribbiani";
            // convert all characters to uppercase
            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Actual: " + name); // actual string not affected
        }

        [Test]
        public void Lowercase()
        {
            String name = "Joey Tribbiani";
            // convert all characters to lowercase
            Console.WriteLine("Lowercase: " + name.ToLower());
        }

        [Test]
        public void SplitString()
        {
            String friends = "Joey Tribbiani,Chandler Bing,Rachel Green,Phoebe Buffay";
            String[] friendsArray = friends.Split(','); // split with ',' as delimiter
            foreach (String friend in friendsArray)
                Console.WriteLine(friend);
        }

        [Test]
        public void TrimString()
        {
            String str = "    Too much space      ";
            Console.WriteLine("Trimmed: " + str.Trim()); // trim blank space at beggining and end
        }

        [Test]
        public void ReplaceString()
        {
            String name = "That's Monica Geller";
            Console.WriteLine("Actual string: " + name);
            // replace "Monica" by "Ross"
            Console.WriteLine("String after replacement: " + name.Replace("Monica", "Ross"));
        }
    }
}
