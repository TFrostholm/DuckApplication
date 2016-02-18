using System;
using System.Collections.Generic;

namespace DuckApplication
{
    public class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size)
            {
                return -1;
            } if (x.Size == y.Size)
            {
                return 0;
            }
                return 1;
        }    
    }
}