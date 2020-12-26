using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data25 : AbstractData, IData
    {
        public Data25() : base(MyData) { }
        private static readonly List<string> MyData =
            new List<string>
            {
                @"1-CDR.34Y.0HR-#0X-#(W""@H`",
                @"`"
            };
    }
}
