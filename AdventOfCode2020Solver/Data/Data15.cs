using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data15 : AbstractData, IData
    {
        public Data15() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                @".,3`L,38L-BPP+#$L,3<`",
                @"`"
            };
    }
}
