using System;
using System.Collections.Generic;

namespace Quiz09_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 9");
            Console.WriteLine("");

            Stack<string> numbers = new Stack<string>();
            numbers.Push("One");
            numbers.Push("Two");
            numbers.Push("Three");
            Console.WriteLine("Here is the Stack:");
            
            foreach (string stackNum in numbers)
            {
                Console.WriteLine(stackNum);
            }

            Console.WriteLine("");
            
            Console.WriteLine("Here is the Queue:");
            Queue<string> queNum = new Queue<string>();
            queNum.Enqueue("One");
            queNum.Enqueue("Two");
            queNum.Enqueue("Three");

            foreach (string index in queNum)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine("");

            Console.WriteLine("Here is the Dictionary:");
            Dictionary<string, int> dictNumbers = new Dictionary<string, int>();
            dictNumbers.Add("One", 1);
            dictNumbers.Add("Two", 2);
            dictNumbers.Add("Three", 3);

            foreach (KeyValuePair<string, int> keyVal in dictNumbers)
            {
                Console.WriteLine($"{keyVal.Key} {keyVal.Value}");
            }
            Console.WriteLine("");
            Console.WriteLine("Press an key to continue . . .");
            Console.ReadLine();

        }
    }
}
