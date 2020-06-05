using System;

namespace JustLikeACollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> keep3Strings =
                new Guarda3<string>() { "Ola", "Adeus", "!" };
            Guarda3<float> keep3Floats =
                new Guarda3<float>() { 3.4f, 1.5f, -1.6f };

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
