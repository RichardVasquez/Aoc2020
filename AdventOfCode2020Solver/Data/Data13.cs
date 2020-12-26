using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data13 : AbstractData, IData
    {
        public Data13() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                @"M,3`P.#$T,0HQ-RQX+'@L>""QX+'@L>""PT,2QX+'@L>""QX+'@L>""QX+'@L>""PU",
                @"M,C,L>""QX+'@L>""QX+'@L>""QX+'@L>""QX+'@L>""QX+'@L>""QX+#$S+#$Y+'@L",
                @"M>""QX+#(S+'@L>""QX+'@L>""QX+'@L-S@W+'@L>""QX+'@L>""PS-RQX+'@L>""QX",
                @"I+'@L>""QX+'@L>""QX+'@L>""QX+'@L>""QX+'@L>""QX+'@L>""QX+#(Y""@H`",
                @"`"
            };
    }
}
