using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data23 : AbstractData, IData
    {
        public Data23() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                "),S@Y,3(U-#8W",
                "`"
            };
    }
}
