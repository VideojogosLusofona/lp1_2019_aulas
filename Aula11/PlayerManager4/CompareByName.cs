using System.Collections.Generic;

namespace PlayerManager4
{
    public struct CompareByName : IComparer<Player>
    {
        private readonly bool order;

        public CompareByName(bool order)
        {
            this.order = order;
        }

        public int Compare(Player x, Player y)
        {
            if (x == y) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            if (order)
                return x.Name.CompareTo(y.Name);
            else
                return -1 * x.Name.CompareTo(y.Name);
        }
    }
}