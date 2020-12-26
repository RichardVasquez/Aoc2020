using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data17 : AbstractData, IData
    {
        public Data17() : base(MyData) { }
        private static readonly List<string> MyData =
            new List<string>
            {
                @"M(R,C(R,N+B,*(RXN(R,C+B,*(R,C+BXN+BX*+B,N(RXC+BX*(R,N(RXN(RX*",
                @"<(R,C(R,C+BX*+B,C+BXC(R,*(R,C+B,C(R,*""@``",
                @"`"
            };
    }
}
