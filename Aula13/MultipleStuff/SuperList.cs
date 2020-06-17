using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public struct MinMax
        {
            public double Min { get; }
            public double Max { get; }
            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public void GetMinMax1(out double min, out double max)
        {
            Sort();
            min = this[0];
            max = this[Count - 1];
        }

        public MinMax GetMinMax2()
        {
            Sort();
            return new MinMax(this[0], this[Count - 1]);
        }

        public Tuple<double, double> GetMinMax3()
        {
            Sort();
            //return new Tuple<double, double>(this[0], this[Count - 1]);
            return Tuple.Create(this[0], this[Count - 1]);
        }

        public (double, double) GetMinMax4()
        {
            Sort();
            return (this[0], this[Count - 1]);
        }
    }
}