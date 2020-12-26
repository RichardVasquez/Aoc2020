using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data22 : AbstractData, IData
    {
        public Data22() : base(MyData) { }
        private static readonly List<string> MyData = 
            new List<string>
            {
                @"M4&QA>65R(#$Z""C,Q""C(T""C4*,S,*-PHQ,@HS,`HR,@HT.`HQ-`HQ-@HR-@HQ",
                @"M.`HT-0HT""C0R""C(U""C(P""C0V""C(Q""C0P""C,X""C,T""C$W""C4P""@I0;&%Y97(@",
                @"M,CH*,0HS""C0Q""C@*,S<*,S4*,C@*,SD*-#,*,CD*,3`*,C<*,3$*,S8*-#D*",
                @"<,S(*,@HR,PHQ.0HY""C$S""C$U""C0W""C8*-#0*""@``",
                @"`"
            };
    }
}
