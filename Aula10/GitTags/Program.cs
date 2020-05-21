// The namespaces we import to our program
using System;

// The namespace we put our program in
namespace GitTags
{
    // Our class is called Program, we should change it some day
    class Program
    {
        // This is the old boring main method
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.PrintSomething();
        }

        // And this is an instance method
        private void PrintSomething()
        {
            Console.WriteLine("I'm a test for git tags");
            Console.WriteLine("Tags are a good way to remember versions");
            Console.WriteLine("Another writeline for testing purposes");
        }
    }
}
