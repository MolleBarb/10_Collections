using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset x, IAsset y)
        {
            return x.GetName().CompareTo(y.GetName());
        }
    }
}