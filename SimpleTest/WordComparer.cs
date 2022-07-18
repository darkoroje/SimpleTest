using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    internal class WordComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (string.IsNullOrEmpty(x))
                return -1;
            else if (string.IsNullOrEmpty(y))
                return 1;
            var equal = string.Compare(x,y, StringComparison.OrdinalIgnoreCase);
            if (equal == 0)
                // uppercase should come before lower case
                equal = string.Compare(x, y, StringComparison.Ordinal);
            return equal;

        }
    }
}
