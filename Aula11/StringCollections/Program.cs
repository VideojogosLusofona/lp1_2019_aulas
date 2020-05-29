using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[]
            { "paulo", "zé", "ana", "ana", "pedro" };

            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            HashSet<string> set = new HashSet<string>();

            IEnumerable<string>[] collections =
                new IEnumerable<string>[] { list, stack, queue, set };

            foreach (string s in strings)
            {
                list.Add(s);
                stack.Push(s);
                queue.Enqueue(s);
                set.Add(s);
            }

            foreach(IEnumerable<string> collection in collections)
            {
                Console.WriteLine(collection);
                foreach (string s in collection)
                {
                    Console.WriteLine($"\t{s}");
                }
            }
        }
    }
}
