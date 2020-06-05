using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] stuffInMain = new object[]
            {
                12,
                4.5,
                5.4f,
                "ola",
                123m,
                true,
                (byte) 12,
                "adeus",
                "",
                124
            };

            Console.WriteLine("How many int: {0}",
                HowMany<int>(stuffInMain));
        }

        private static int HowMany<T>(IEnumerable<object> stuff)
        {
            int count = 0;

            foreach (object o in stuff)
            {
                if (o is T) count++;
            }

            return count;
        }
    }
}
