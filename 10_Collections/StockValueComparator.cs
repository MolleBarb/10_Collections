using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset x, IAsset y)
        {
            return y.GetValue().CompareTo(x.GetValue());
        }
    }
}