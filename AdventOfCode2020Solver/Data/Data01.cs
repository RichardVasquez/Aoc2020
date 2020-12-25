using System.Collections.Generic;

namespace AdventOfCode2020Solver.Data
{
    public class Data01 : AbstractData, IData
    {
        public Data01():base(MyData)
        {
        }

        private static readonly List<string> MyData =
            new List<string>
            {
                @"M,3@V-`T*,3@X,`T*,3,P,`T*,3DV,0T*,34W-PT*,3DP,`T*,3,P-PT*,3@Q",
                @"M.`T*,3<S-@T*,3@T-@T*,30Q-PT*,3,W,@T*,3,U,0T*,3@V,`T*,3<S.`T*",
                @"M,34R-0T*,3<Y.`T*,3(Q.`T*,3<R,PT*,3DS-@T*,3<R-0T*,3DY.`T*,30V",
                @"M-@T*,3DR,@T*,3<X,@T*,3DT-PT*,3<Q-PT*,3DQ-`T*,3@T,PT*,3<S,@T*",
                @"M,3DQ.`T*.#$T#0HQ-S<Q#0HQ-S$R#0HQ.#`T#0HQ,C$S#0HQ.#4Y#0HQ.#(P",
                @"M#0HQ-SDS#0HQ.#<P#0HQ.3DS#0HQ-S@W#0HQ.#(T#0HQ.#0Y#0HQ-C0V#0HQ",
                @"M-#@Y#0HQ,S0X#0HQ.3<X#0HQ-C(X#0HQ-S@Q#0HR,#`R#0HQ,CDW#0HQ.#(Y",
                @"M#0HQ-3DV#0HQ.#$Y#0HQ,S$S#0HQ-#$S#0HQ-S(V#0HQ-#0Y#0HQ.#$P#0HQ",
                @"M,CDU#0HQ-C<Y#0HQ,S4X#0HQ.30Y#0HQ-C0T#0HQ.#(U#0HQ.#DQ#0HT.3`-",
                @"M""C$Y-C(-""C$Y,SD-""C$R,C@-""C$X.#D-""C$Y-S<-""C$Y.#`-""C$W-C,-""C$W",
                @"M-3(-""C$Y.#,-""C$W.#4-""C$V-S@-""C(P,#`-""C$X-3<-""C$V-3@-""C$X-C,-",
                @"M""C$S,S`-""C$S.#`-""C$W.3D-""C$W.#D-""C$V,S,-""C$V-C,-""C(Y-@T*,3DX",
                @"M-0T*,3$Q-PT*,3(S.0T*,3@U-`T*,3DV,`T*,C`P-`T*,3DT,`T*,3@W-@T*",
                @"M,3<S.0T*,3@U.`T*,3(X,PT*,30R,PT*,3DX,@T*,3@S-@T*,30U,0T*,3@T",
                @"M,`T*,3,T-PT*,38U,@T*,38Y-0T*,3(Q,`T*,3@V,0T*,3$Y.0T*,3,T-@T*",
                @"M,3<X-@T*,3@Q-`T*,3DU.`T*,3@U,PT*,3DW-`T*,3DQ-PT*,3,P.`T*-C4T",
                @"M#0HQ-S0S#0HQ.#0W#0HQ,S8W#0HQ-34Y#0HQ-C$T#0HQ.#DW#0HR,#`S#0HQ",
                @"M.#@V#0HQ.#@U#0HQ-C@R#0HQ,C`T#0HQ.3@V#0HQ.#$V#0HQ.3DT#0HQ.#$W",
                @"M#0HQ-S4Q#0HQ-S`Q#0HQ-C$Y#0HQ.3<P#0HX,38-""C$X-3(-""C$X,S(-""C$V",
                @"M,S$-""C<P,PT*,38P-`T*,30T-`T*,3@T,@T*,3DX-`T*,3(U.0T*,3DT.`T*",
                @"M,38R,`T*,38X,0T*,3@R,@T*,3@V-0T*,34R,0T*,3<T,0T*,30U-0T*,3DP",
                @"M.0T*,3<V-`T*,C8Q#0HQ-#8T#0HQ.3`U#0HQ,S(U#0HQ-S8V#0HQ-S0Y#0HQ",
                @"M,CDR#0HQ.#<T#0HQ,C8W#0HQ,C8Y#0HQ.38Y#0HQ.3DQ#0HQ,C$Y#0HQ,S0U",
                @"M#0HQ.3<V#0HQ,S8Y#0HQ.30R#0HQ,S@X#0HQ-S<V#0HQ-C(Y#0HQ.3@W#0HQ",
                @"M-C@T#0HQ.#$S#0HQ,C`S#0HQ.38U#0HQ-S(Y#0HQ.3,P#0HQ-C`Y#0HQ.#`Q",
                @"M#0HQ-#`R#0HQ,C$-""C$X,S,-""C$X.3@-""C$Y-3<-""C$P-3$-""C$T,S`-""C$X",
                @"6.3,-""C$W.#0-""C$X,#`-""C$Y,3`-""@``",
                @"`"
            };
    }
}
