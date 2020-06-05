using System;

namespace MyEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> keep3Strings = new Guarda3<string>();
            Guarda3<float> keep3Floats = new Guarda3<float>();

            keep3Strings.SetItem(0, "Ola");
            keep3Strings.SetItem(2, "Adeus");

            keep3Floats.SetItem(1, 3.4f);

            foreach (string s in keep3Strings)
            {
                Console.WriteLine($"'{s}'");
            }

            foreach (float f in keep3Floats)
            {
                Console.WriteLine($"'{f}'");
            }
        }
    }
}
