using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Range
    {
        public Range(string[] sectionRange)
        {
            Min = int.Parse(sectionRange[0]);
            Max = int.Parse(sectionRange[1]);
        }

        public int Min { get; }

        public int Max { get; }
    }
}
