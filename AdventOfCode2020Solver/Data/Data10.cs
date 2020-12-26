using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data10 : AbstractData, IData
    {
        public Data10() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                @"M,34R""C$X""C$T-@HR,@HR.`HQ,S,*,3$T""C8W""C$Y""C,W""C8V""C$T""CDP""C$V",
                @"M,PHR-@HQ-#D*-S$*,3`V""C0V""C$T,PHQ-#4*,3(*,34Q""C$P-0HU.`HQ,S`*",
                @"M.3,*-#D*-S0*.#,*,3(Y""C$R,@HV,PHQ,S0*.#8*,3,V""C$V-@HQ-CD*,34Y",
                @"M""C,*,3<X""C@X""C$P,PHY-PHQ,3`*-3,*,3(U""C$R.`HY""C$U""C<X""C$*-3`*",
                @"M.#<*-38*.#D*-C`*,3,Y""C$Q,PHT,PHS-@HQ,3@*,3<P""CDV""C$S-0HR,PHQ",
                @"M-#0*,34S""C$U,`HQ-#(*.34*,3@P""C,U""C$W.0HX,`HQ,PHQ,34*,@HQ-S$*",
                @"M,S(*-S`*-@HW,@HQ,3D*,CD*-SD*,C<*-#<*,3`W""C<S""C$V,@HQ-S(*-3<*",
                @"F-#`*-#@*,3`P""C8T""C4Y""C$W-0HQ,#0*,34V""CDT""C<W""C8U""@H`",
                @"`"
            };
    }
}
