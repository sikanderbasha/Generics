using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class MaximumCheck
    {
        public int MaxNumberof3(int first, int second, int third)
        {
            if (first.CompareTo(second) > 1 && first.CompareTo(second) > 1)
                return first;
            if (second.CompareTo(first) > 1 && second.CompareTo(first) > 1)
                return second;
            else
                return third;

        }
    }
}
