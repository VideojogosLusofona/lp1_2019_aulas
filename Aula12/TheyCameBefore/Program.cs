using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            { 5, 7, 1, -10, 12, 16, 100, -50, 123, 56 };

            IEnumerable<int> theseComeBefore =
                Before<int>(list, 50);

            foreach (int i in theseComeBefore)
            {
                Console.WriteLine(i);
            }
        }

        private static IEnumerable<T> Before<T>(IEnumerable<T> stuff, T item)
            where T : struct, IComparable<T>
        {
            foreach (T currentItem in stuff)
            {
                if (currentItem.CompareTo(item) < 0)
                {
                    yield return currentItem;
                }
            }
        }
    }
}
