using System;

namespace MyGenericClass
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

            Console.WriteLine("'{0}'\n'{1}'\n'{2}'",
                keep3Strings.GetItem(0),
                keep3Strings.GetItem(1),
                keep3Strings.GetItem(2));
            Console.WriteLine("'{0}'\n'{1}'\n'{2}'",
                keep3Floats.GetItem(0),
                keep3Floats.GetItem(1),
                keep3Floats.GetItem(2));
        }
    }
}
