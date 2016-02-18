using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DuckApplication
{
    public class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public enum KindOfDuck
        {
            Mallard,
            Muscovy,
            Decoy
        }

        public enum SortCriteria
        {
            SizeThenKind,
            KindThenSize
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (Size > duckToCompare.Size)
            {
                return 1;
            } else if (Size < duckToCompare.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}