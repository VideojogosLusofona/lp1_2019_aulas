using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList sl = new SuperList() { 4, -5, 10, -11, 40, 14, 51, 0 };

            double min, max;
            SuperList.MinMax minMax;
            Tuple<double, double> refTuple;
            (double min, double max) valTuple;

            sl.GetMinMax1(out min, out max);
            Console.WriteLine($"v1: min = {min}, max = {max}");

            minMax = sl.GetMinMax2();
            Console.WriteLine($"v2: min = {minMax.Min}, max = {minMax.Max}");

            refTuple = sl.GetMinMax3();
            Console.WriteLine($"v3: min = {refTuple.Item1}, max = {refTuple.Item2}");

            valTuple = sl.GetMinMax4();
            Console.WriteLine($"v4: min = {valTuple.min}, max = {valTuple.max}");
        }
    }
}
