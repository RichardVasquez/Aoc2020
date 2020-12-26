using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data19 : AbstractData, IData
    {
        public Data19() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                @"M.3`Z(#@V(#@V""C$R,CH@.#8@,2!\(#DY(#(P""C$Q-CH@.#8@-3@@?""`Y.2`W",
                @"M-0HR,#H@.#8@,3(S""C8R.B`Y.2`Y-2!\(#@V(#$Q,PHX,3H@-S8@.3D@?""`Y",
                @"M,""`X-@HQ,#8Z(#$R,""`X-B!\(#DS(#DY""C<S.B`Y.2`W,B!\(#@V(#0U""C$Q",
                @"M-SH@,3,Q(#DY('P@-S(@.#8*.3(Z(#@V(#DV('P@.3D@.3@*,3,Z(#,@.3D@",
                @"M?""`Q,3@@.#8*-38Z(#DP(#@V('P@-3@@.3D*.#4Z(#<R(#DY('P@-3$@.#8*",
                @"M-3$Z(#DY(#DY('P@.#8@.#8*-3DZ(#DY(#(U('P@.#8@-C(*-C4Z(#DY(#$U",
                @"M('P@.#8@.3<*,3$R.B`X-B`Q,R!\(#DY(#,X""C0V.B`S,R`X-B!\(#(@.3D*",
                @"M,3`Z(#8W(#@V('P@-C@@.3D*,S,Z(#$R,""`Y.2!\(#<V(#@V""C,X.B`S-2`X",
                @"M-B!\(#$R-2`Y.0HR-CH@.#8@,3`@?""`Y.2`U-0HQ.B`S,R`Y.2!\(#8P(#@V",
                @"M""C@Z(#0R""C$V.B`U,2`X-B!\(#DS(#DY""C$P-SH@-#`@.3D@?""`R(#@V""C0P",
                @"M.B`Q-R`Q,C`*,S0Z(#@V(#@R('P@.3D@,3(W""C@X.B`Y,R`Q-PHR.B`Y.2`U",
                @"M,2!\(#@V(#$R,`HS,CH@,3`P(#DY('P@-R`X-@HQ,3,Z(#@V(#$R-R!\(#DY",
                @"M(#@R""C$T.B`W,R`X-B!\(#0T(#DY""C(U.B`X-B`Q,#$@?""`Y.2`U-@HQ,S`Z",
                @"M(#$Q,""`X-B!\(#$P.2`Y.0HQ.3H@.#8@-""!\(#DY(#0Y""C,P.B`X-B`Y,B!\",
                @"M(#DY(#<P""C(W.B`Q-R`X-B!\(#@V(#DY""CDT.B`T-R`X-B!\(#4S(#DY""C$Q",
                @"M-3H@.#8@,3`W('P@.3D@.#0*,34Z(#<V(#DY('P@-3@@.#8*-3@Z(#@V(#DY",
                @"M""C$P-3H@,3,P(#@V('P@,S(@.3D*-S$Z(#$R,""`Y.2!\(#$S,2`X-@HQ,CH@",
                @"M.3D@,3,Q('P@.#8@.#(*-C`Z(#<R(#@V('P@.3,@.3D*.#0Z(#@V(#$P,B!\",
                @"M(#DY(#@P""C0T.B`Y.2`W-B!\(#@V(#<R""C$R-3H@-S8@.3D@?""`Q,S$@.#8*",
                @"M,3@Z(#DY(#<Q('P@.#8@-3(*,3(Y.B`S-R`X-B!\(#$Q,2`Y.0HQ,#(Z(#DY",
                @"M(#$S,2!\(#@V(#<V""C8V.B`X-B`Q,#4@?""`Y.2`T,0HY.3H@(F$B""CDZ(#DY",
                @"M(#$X('P@.#8@-C4*,3,Q.B`Q-R`Y.2!\(#DY(#@V""C,Y.B`W-B`Y.2!\(#DS",
                @"M(#@V""C8T.B`Q,34@.3D@?""`Q,30@.#8*-3<Z(#@V(#0X('P@.3D@.30*,S4Z",
                @"M(#<R(#@V('P@-3$@.3D*,#H@.""`Q,0HW-SH@.#8@.#,@?""`Y.2`Q,#8*,3$X",
                @"M.B`W,B`X-B!\(#<U(#DY""C0W.B`Y.2`Q,#,@?""`X-B`X-0HR,SH@.3D@,C<@",
                @"M?""`X-B`W-@HT.#H@,3$Y(#DY('P@-S@@.#8*-#DZ(#@V(#4Q('P@.3D@-#4*",
                @"M-C<Z(#@V(#$R,`HV,3H@.#8@-S(@?""`Y.2`Q,C<*,3`X.B`W,B`Y.2!\(#<R",
                @"M(#@V""CDU.B`X-B`U.""!\(#DY(#DP""C@S.B`X-B`R-R!\(#DY(#$S,0HW-3H@",
                @"M.#8@.3D@?""`Y.2`Y.0HQ,#$Z(#4Q(#DY('P@,C<@.#8*,3`S.B`Y,""`Y.2!\",
                @"M(#DP(#@V""C$R.#H@.#8@-CD@?""`Y.2`S,PHW,#H@.3D@,30@?""`X-B`Q.0HU",
                @"M,CH@,3(W(#@V('P@.3`@.3D*,C$Z(#@V(#(T('P@.3D@-3D*,C(Z(#@V(#8S",
                @"M('P@.3D@,3(*-#(Z(#<Y(#@V('P@-C8@.3D*.3<Z(#4Q(#$W""C$P-#H@.#8@",
                @"M,S,@?""`Y.2`R.`HQ,#`Z(#DY(#$V('P@.#8@,SD*-S(Z(#DY(#@V""C<X.B`X",
                @"M-B`T,R!\(#DY(#4P""C4U.B`X-B`V('P@.3D@,S0*-#4Z(#DY(#DY""C4Z(#@V",
                @"M(#0V('P@.3D@-S<*.3,Z(#DY(#DY('P@.3D@.#8*-CH@,3,Q(#DY('P@-3$@",
                @"M.#8*,3$P.B`W,2`X-B!\(#(X(#DY""C8X.B`Y,""`X-B!\(#(W(#DY""C(Y.B`X",
                @"M-R`X-B!\(#$R,B`Y.0HX,#H@.#8@.3,@?""`Y.2`Q,S$*-30Z(#$R,""`X-B!\",
                @"M(#<U(#DY""C0S.B`Y,R`X-@HY.#H@.3D@,3`S('P@.#8@,3$W""C<Z(#$P,2`X",
                @"M-B!\(#@X(#DY""C$R-SH@,3<@.#8@?""`Y.2`Y.0HY-CH@.#8@,3(@?""`Y.2`V",
                @"M,0HT,3H@.3D@-2!\(#@V(#$Q,@HW.3H@.#8@-3<@?""`Y.2`R,0HQ,3H@-#(@",
                @"M,S$*.#8Z("")B(@HQ,3$Z(#0U(#DY('P@-S(@.#8*-C,Z(#<V(#DY('P@,3(W",
                @"M(#@V""C$R-#H@.#8@.#$@?""`Y.2`Q,38*,C@Z(#@V(#<U('P@.3D@-3@*.#(Z",
                @"M(#DY(#@V('P@.#8@.3D*,3(Q.B`V-""`X-B!\(#<T(#DY""C@W.B`X-B`Q,C0@",
                @"M?""`Y.2`Q,#0*-S0Z(#DY(#(V('P@.#8@.0HS,3H@,3(V(#DY('P@,3(Q(#@V",
                @"M""C4P.B`Y.2`W,@HQ,3DZ(#,T(#@V('P@,S8@.3D*,S8Z(#@V(#@R('P@.3D@",
                @"M-S4*.3$Z(#@V(#$S,0HS.B`U.""`Y.2!\(#(W(#@V""C$Q-#H@.3D@,3(Y('P@",
                @"M.#8@,C(*,C0Z(#@V(#@Y('P@.3D@,3(X""C4S.B`Y,2`Y.2!\(#DU(#@V""C$R",
                @"M-CH@,CD@.#8@?""`S,""`Y.0HQ,#DZ(#DY(#$P.""!\(#@V(#(S""C$W.B`X-B!\",
                @"M(#DY""C<V.B`X-B`X-B!\(#DY(#@V""C$R,#H@,3<@,3<*.#DZ(#4T(#@V('P@",
                @"M,S<@.3D*-#H@.3D@,3,Q('P@.#8@-3@*-CDZ(#(W(#$W""C,W.B`Y.2`U.`HQ",
                @"M,C,Z(#@V(#<V('P@.3D@.#(*""F)B86)A8F)A86)B86%A8F%A86%B8F%B8F)B",
                @"M8F%B86)B8F%B86)A86%A8F)A86)A86%A86%B86%A86)B86%B8F$*86%A8F)B",
                @"M86)B86)B8F)B8F%A8F)A8F%B86)A86%A86)A86%B86%A86%B86%A86)B8F)A",
                @"M8F)A8F(*8F%B86%B86%B8F%B86%A86%B8F%B86)B""F)A8F)A8F)A86)A8F)A",
                @"M86%A8F%B8F%A8F)B8F)A86)A86)B8F%B86)A86)B8F%B8F)A8F%B86)A86)B",
                @"M86)B86)A86)B8F%A8F%B8F)B8F)B""F)A8F%B8F)A8F%A86)B86%B8F%B86)A",
                @"M8@IA86%A86)A86%A8F)A86)A86%A86)B86$*86%B8F)A86%A86)A8F)A86%B",
                @"M86%B8F)B86)B8F%A86%A8F)A86%A8@IB86%A86)A86%A8F)A8F%B8F%A86)B",
                @"M86(*86)A8F%B86)A86%A86)A86%A86)B86%A""F)A86)A86)A8F%A86)B86%B",
                @"M8F)A8F%B8@IA8F)B86)B8F)B86)A86%B86%B8F%B8F(*86%A8F%B8F)A8F%B",
                @"M86)B8F%A8F)A86%A8F%B86)B86$*8F%B8F%A86)B86%A86)A86)A8F)B86)B",
                @"M""F)B8F%B8F)A8F)A8F%A86%B86%B86%A8@IB8F)B86%A8F%A86%B8F)A86)B",
                @"M8F)A8F(*86%A86%A86%A86%A86)A86)A86%A8F)B""F)A8F%A8F)A8F%B8F%B",
                @"M86%B86)B86%B80IB8F%B86%A86)A86%B8F%A86%B8F)B8F)B86)B86)B8F)A",
                @"M86%A8F%B""F)A8F%A8F)B8F)B8F)B86%B8F%A86)A80IB86%B8F)A8F%B86)B",
                @"M86)A8F%A8F)B86$*8F%A86%B86%A86)A86%A86%A86%A86%B""F%A86)B8F)B",
                @"M8F)A8F)B86)B8F)B86)B8@IB8F%B86%A8F%A86)A8F%A8F)B8F)B8F$*8F%A",
                @"M86)A86%B8F%B8F%A86%A86%B86)B""F%B8F%B86%B8F%A86%A86%A86)A86)B",
                @"M80IA86%A8F%B86)B8F)B8F%A8F%B86)B86(*8F)B8F)B86)A8F%B8F%A8F%A",
                @"M8F)B86)A86%A8F)A8F)A86)B86)B8F)A86)A8F)B86)A86)B8F)A8F)A8F%A",
                @"M8F%B86)A86)A86%A86%B86(*8F)B86)B86%A86)A8F)A8F%A8F%A8F)B86)B",
                @"M8F%B86(*8F)B86)B8F%B86)B8F)A86)B8F)B8F%B""F)A86)A86%A86)A86)B",
                @"M8F)A86%B86%A86)B8F)B8F%B""F)B8F)A86%A86%B86%A86%A8F)B86)A86)A",
                @"M8F)A86)B""F)B8F)B86)A86)A86%A86)A8F)A86%B8F)A86)A8F)B8F)A86%B",
                @"M86$*86%A8F%A8F%A86%B86%A86%B86)B86%A86%A8F%B8F)A86%B86)A8@IB",
                @"M8F%A86%B86)B8F%A86)B86)B86)B86)B86)B8F)A8F)A8F%B86%B8F)A8F)A",
                @"M8F)A8F%A86)B86)A86%A8F)A""F%A8F%B8F)A86%A8F)B86%B8F)B86)A8F)A",
                @"M8F)A86%A""F%B8F)A86)B86)A86%A86)A8F%A86%A80IB86)B86)B86)B86%B",
                @"M86)A8F)A8F%A86%A86)B8F%B8F)A8F%A8F)B8F%B8F)A86)B86%A86%B80IA",
                @"M86)B8F%A8F%A86)B86)B8F)A86)A86%B8F)A8F)A8F%B8F%A8F%B86)A8F)B",
                @"M8F$*8F%A8F)A8F)B86%B8F)B8F)B86%A86%A8F%B86)A8F%A86)B8F)A8F%A",
                @"M8F%A8F)A86%A86)B86(*8F)A8F%A86)B8F)B86%A86)A8F)A8F)B""F)A86)A",
                @"M86)A86%B86)B8F%B86%A8F%B80IA86%A8F)B8F%B8F)A86)B86)A8F%A86$*",
                @"M8F%B8F%B86)A86%A8F%B86)A8F%A8F%B""F)B8F%A8F)B86)B8F%B86%B8F)A",
                @"M8F)B86%A8F)A86)B86)B8F)B8F)A86%A8F%A86)A86%B8F%A8F)B8F%B8F(*",
                @"M86%B8F%A8F)A8F)A8F)B86)A86%A8F)A""F%B86%B8F%A86%A8F)A8F)A86%B",
                @"M8F)A8F)A8F)A86%A""F)A8F%B86%B8F%A86)A86%B86)B86)A8F)B8F)B86)B",
                @"M8F%A86)A86(*86%A8F%B8F)A86)B86%B8F)B86%A8F)A86%B86)A86%B86%B",
                @"M8F)A80IA8F)A86%B86)B86%A8F%B8F%A86%B8F$*8F)A86)A8F%A86)B86)A",
                @"M86%B86)B86%B8F%A8F)B8F%A86)B86%B8F%B86%A8F)A8F)A8F)B8F)A8F)B",
                @"M86%A8F)B86)A8F)B""F)B86%A8F)B8F)A86%B8F%B86%A86)B80IA8F)B86)A",
                @"M86)B86%B86%A86%A8F)A86$*8F)B86)A86)B8F)B8F)A86)A8F)B8F%A86)B",
                @"M8F%B8F$*86)B86)B86%A86%A8F)B8F)B86)A86%B8F%A86%A86(*8F)A86)A",
                @"M8F%A86%B86)A86)A86)B86)A8F)B8F)A86(*86%B8F%B86)A86%B8F)A86%A",
                @"M86)B86)B86%B8F)B8F)B86)B8F%B8@IA86%B8F)A86%A8F%B8F%B8F%B86)B",
                @"M8F(*86%B86)B86)A8F%A86)A86)A8F%B8F)B""F)B86)B8F%B8F)A8F)B86)A",
                @"M8F%B8F)B80IA86%B86%A86%B8F)B8F)B8F%A86%A86(*8F%B86%B8F)A86%B",
                @"M8F)A8F)A86%A86%B""F)B86%B8F)A86%B8F%B86)B8F%A86)A80IA86)B8F%A",
                @"M86%A86%A86%A86%A86%B86%A86)B8F)B86)B86)A86%A86)B8F)B86(*86)A",
                @"M86%A86)A86)B8F%A86%B8F)A86%B""F%B86%B8F%B8F%B8F)B8F%B8F%B86)A",
                @"M80IB86%A8F)A86%A8F)B86)B86%A86)A86$*86)B8F)B86%B8F%A86)A8F)B",
                @"M8F%B86%B""F%A8F%B8F%A86%B8F)B8F%B86%B86)A86)A8F%B86%B8F%B8F)A",
                @"M8F$*86)A86)A86%B8F%B86)A8F%B86)A8F%B8F%A8F%A86)B8F%A8F%A8F%A",
                @"M8F)B86)A8F)B86)B8F%B8F%B8F)B8F%B86)A8F%A8F)A8F)A8F$*86%A86%A",
                @"M8F%A86%A8F%B86)B8F%B8F%B8F)A86)B86)A86)A8F)B8@IB86)A86%A8F%B",
                @"M86%A8F%B86%B8F%B8F$*86)A8F)A86%A8F%A86)B8F)A8F%B86%A""F)A86)A",
                @"M8F)B86)B8F)A86%B86%B86)B8F%B8F)B86%B86)A86%B86%A86)B86%B86)A",
                @"M8F%B86)A86%A86)A8F$*8F)A86)B86)A8F)A8F%A8F)B86)B86)B""F)B86)B",
                @"M8F)A86)A8F)A86)B8F)A8F)B8F)A8F)A8F%A86%A8F)B86)A8F)B8F%A8F%A",
                @"M86%A86)B8F%B86)B8F)B86)B8F%B8@IB86%A86%A86)A8F%A86%B8F)B8F%A",
                @"M86%A8F%A8F)B8F)A86)A8F)B""F%A8F)A8F%A86)B8F)B86%B8F)A86)A8@IA",
                @"M8F%B8F%B8F)B86%B86%A8F%B86)A86)A86%A8F)A8@IA86%B8F%B86%A86%B",
                @"M8F)B86)B8F)A86$*8F)A86%A86)B86%A86)A86%B8F)A86%A""F%B8F)A86%A",
                @"M86)B8F%B8F)A8F)A8F%A80IB8F%A86%B8F%A86%B86)A8F%B86%B86)A86%A",
                @"M8F)B86%A8F%A8F%A86%B86)B86)B8F%A86%B86%B86%A8F)A86)A8F)B86%A",
                @"M8F%A8F)A86)A8F)B86%B86%B86%B8F(*8F)A86)B86%A86)A8F)A8F%B8F%A",
                @"M86)B8F%B8F)A8F%B8F)B8F)A86)B86%B86)A8F)A8F%B86%B86)B86%B86)B",
                @"M8F%A86)B86%B8F)B86(*86%B86)B86)A86%B86%A86)B86%B8F%A""F)A8F%A",
                @"M86)B86%A8F%A8F%B8F%B8F)B86)B8F%A8F%A8F)A86)B8F%B86)B86)A86)A",
                @"M8F%B86%B8F)A8F%B8F%B8F)B86%B86)B86%B86%A""F)A86)B86)B8F)A86)B",
                @"M8F%A86)B86%A8@IA8F%A86%A8F)B86%B86)A86)B86%B86(*86%A8F)B8F)A",
                @"M86%B86)A86%B86)A8F%A8F)A86)A8F(*8F)A86%B86)B86%B8F)B86)A8F)B",
                @"M8F)A8F)A86)B86)B8F)B86%A8F)B86)B86)B""F)B86)B8F)A86)B8F)B8F)B",
                @"M86%A86)B80IA86)A8F)A8F%A86)A86)A8F%A8F)A8F)A8F%A86%B86%A8F)B",
                @"M86)A86%B8F)A8F)B86)A86%A80IB86)B8F)B8F%A8F)B86%B8F%B8F)A8F(*",
                @"M8F%A8F)B8F%A8F%B8F%A8F%A86)B86)B""F%A86)A86)A86)B8F%A8F%B86)B",
                @"M8F)A86%A86%B86%B8F%B86%B8F)A8F%A86)B8F%A86%B86)A8F%A8F%B8F)A",
                @"M8F%B8F%B86%A86%A8F%B""F%A8F)A8F%A8F%A86%A86%B86)B86)A8F%A8F%A",
                @"M8F)A""F%B86)B86)A8F)A86)B8F%A8F%A8F%A8F%B8F%A8F)B86%A86)B86$*",
                @"M86%B8F%B86)A86)B8F)B8F)A86)A8F%A8F%B8F%B8F$*8F%A8F)A8F)B86%A",
                @"M86%A86%A86%B86%A""F)A86)B8F%B86%A8F)A8F)B8F)B8F%B8@IB86)A86)A",
                @"M86%A8F%A86%A8F)B86%A86(*8F%A86%A86%B86)B8F)B86%B8F)B8F%B""F)B",
                @"M86)B8F%B86)A8F)A86)B86%A8F%B80IB8F)B86)A8F%B86%A86%B86)B86)B",
                @"M8F%B86)B86)A86%B8F%A8F%B86)B86)A8F%A86%A8F)A8@IA86)B8F)B86)A",
                @"M8F)A8F%A86)A8F%B86%A86%B86%B86)B8F%B8F%B""F)A8F)B8F%A8F%A8F)B",
                @"M8F%B8F)B8F%B8@IA86%B8F)A8F)A8F%A8F)B86)A86%B86)B86%A8F%A8@IA",
                @"M8F)A86%B8F)B86%A8F)B8F%B8F)B8F)B8F)B86)A80IB8F%B8F%B86%A86)B",
                @"M86)B8F)B86)A8F%B86)B86%A8F)A8F%A86%A8F%B86%A8F$*8F)A86)A86%A",
                @"M86)A86%B86)A86)A8F)B""F)A86)B86%A86%A8F%B8F%B86)B86%B86%B86)A",
                @"M8F)B86)A86%B8F)B8F)A86%B8F)B86)A8F%A8F%B86%B8F)B8F%B86%A8F%B",
                @"M8F%A86%B8F)A86%A86$*86%A8F%A86)B8F)B86%A86)B8F)A8F)A""F%B8F)A",
                @"M86)B8F%B8F)A86%A86)A86)A8@IA86%B8F)A86)B86%B8F%B8F%A8F)B8F)B",
                @"M8F%B8F%A86%A86%B8F)A86%A86%B86(*86%A86%A86%A86)B86%B86%A8F)B",
                @"M8F%A8F)A86%A86)A86%B8F%A8F%B8F)B8F%B""F)B8F)A8F%B8F%B86)A8F)B",
                @"M8F%B86)B80IA8F%A86%B86%B8F)B86%A86)B8F)B8F)B86%B86)B86)B8F)A",
                @"M86)B86%B8F)B8F%B86%A8F)B86%A86%A8F%B""F)B8F)B8F%A8F%A8F%A86%A",
                @"M86%A86)B86%A86%A86)A8F)A8F)A8F%A8F)A8F)A8@IA8F)B8F)B8F)A86%A",
                @"M8F%A86%B86)B86)B8F)B86%B8@IB86)A8F%A8F%A8F%B8F)A86)B86%B86(*",
                @"M86)A86%A8F%A8F%A8F)A8F%A86)B8F)B8F)A86%A86$*86%A86%A8F%A8F%B",
                @"M86)A8F)B86%B8F)A8F)A86%A8F$*86)A86)A86)B8F%B86)B86)A8F)A86)B",
                @"M""F)A86%B8F%A8F)B86%B8F)B86)B86)B8@IB86%B86)A86)A86%B86%A86)B",
                @"M86)B8F%B86)A8F)A86)B8F)B8F)A""F)B8F%A8F)A8F)B86)A86)B86%A8F)A",
                @"M86%A8F%B86)A86%B8F)B86%A8F%B8F%A8@IA8F%A8F)B8F%B8F%B8F)B86%A",
                @"M86%B86(*8F)B86)A86)A8F%A8F)B8F)B8F%A86%B""F%B8F%A86)A86%A86%A",
                @"M8F%A8F%A86%B86%B8F%A86)B86)B86)B8F)A86)A86)A8@IA86)A86%A86)A",
                @"M8F)B86%A86%A86)A8F(*86%A8F)B86%A8F%A8F)B86)B8F)A8F%A""F%A86%A",
                @"M8F%A8F%B86%B8F%B86%A86)A86%B8F%A86%A""F%A86%B86%B86)A8F)B8F)A",
                @"M86%A86%A86%A8F)B8F)B8F)B8F)B86)A8F)B8F%B8F)A86%B86%B""F)B86)B",
                @"M8F%B8F%A8F)B8F%A86%B86%B86%B86%A8F)B86%A86%A86)A8F)B86%A8@IA",
                @"M86)A86%B86%A8F)A8F%B8F%B86)A8F$*8F%B8F)A86%A86)B8F%A8F)B86)B",
                @"M86)A8F)B8F)B8F%A8F)A8F%B80IA8F)A86)A86)A86)B86%A86)A86%A86%A",
                @"M8F%B8F%A8@IA8F%A86%B86)B86%B86)A8F%A8F)B86)A8F)A8F%A8F%A86)A",
                @"M8F)B8F)B8F%B8F$*8F)A86%A8F%B86)B86)A8F%B8F%B86%B8F)A86%B8F)B",
                @"M8F)A8F)A80IA86)B86%B8F%A86)B8F%A8F%A86%A86(*8F)A86)B86)A86%A",
                @"M8F)B86)B86)B86)B""F%B8F%A86)B86)B8F%A86%B8F)B8F%A86)B86)B86)A",
                @"M8F%B8F)B8F)A8F%A8F)B8F)A8F)A86%A86)A86)A8F(*86)A8F)A86)B86)B",
                @"M8F)B8F)B86)A86%A8F)B8F%B86)B86%A8F)B86)A86)A86)B""F%A86)B86)A",
                @"M86%B8F)A8F%A86%A8F%A8F%A86)A8F)A86)B8F%B8F%B86)B8F)A8F%A8F)A",
                @"M8F)B""F%B8F%B8F%A86)A8F%B86)A8F)B86)A86%A86%B86%B8F%B86%B86(*",
                @"M8F%B86%B86%A8F%B8F%A86%A8F)A86%B""F%A86%A86)A8F%B86)A86)A8F)A",
                @"M86%A8@IA8F%B8F%B86%A8F%B8F%A86)B8F%A8F%B86%A86%B8@IB8F%A86)B",
                @"M86)A86%A8F%A8F)A8F%A86%A86%A8F%B8F)B8F%B86%A""F)A8F%B8F)A8F)A",
                @"M86)B86)B8F)B86)B80IB8F%A86)B86%A8F)B8F%A8F%B86)A86)B86)B86%A",
                @"M80IA86%A8F%A8F%A86%A8F)A86)A8F)A86)A8F%B8F%A80IA8F%B8F%B86%B",
                @"M8F%B8F)B8F)A86)A8F(*86%B8F)B8F)B86%A8F)B86)A8F%B86)A""F)A8F%B",
                @"M8F)A86)B86)B86%B86%A86)A8@IB8F%A86)B8F%A8F)B8F)A86%B86%B8F$*",
                @"M86%B8F)B86%A8F%B8F)A8F)B86%B8F)B""F)A86%A8F%A86)A86%B8F)A8F%B",
                @"M8F)A8F%A8F)B86)B86%B8F)A86)B8F)B8F)A8F%A86%B8F%A8F%B8F%A8F%A",
                @"M86)A8F)B8@IB86)B8F)A8F)B8F%B86)B86)A86%B8F$*8F%B8F)B86%A8F%B",
                @"M8F)B8F)A8F)B86%A8F%A8F)A86(*8F)B8F)B86%A86)B8F%B8F%A86)A86%A",
                @"M8F)B86)A86%A86)A86)A8@IB86)B8F)B86)B86)A86%A86%A86%B8F(*86)A",
                @"M8F)B86)B86)A86)B86%A86)B86)B86%A86)B86$*8F)B86)B8F%B86)A8F)B",
                @"M86)B86%A8F)B8F)B8F%A8F$*86)B86)B86%A8F%A86)A8F)A86%A86)B""F)B",
                @"M86)A8F)A8F%B86)A86%A86)A8F)B8F)A8F)B86%B86)A8F)A86)A86)B8F%A",
                @"M8F%B8F%A86)A""F)A8F)A8F%B86%B8F)A86%A8F)A86%A8@IA8F)A86%B8F)A",
                @"M86%A86%A8F)A8F%B86(*8F)B86)B8F%B8F%B8F%B86)A8F)B8F%B""F)A8F)B",
                @"M86%A8F%B86)A86)A86)A8F)B86)A8F)B8F)A86)B8F)A8F$*8F)B86)A8F%A",
                @"M8F%A8F%A8F%B86)B8F)B86)A86%A8F%B8F%B8F)A8F)B86%A8F%A8F%B8F%A",
                @"M86%A8F%A86%B8F%A86%B8F%B""F)A8F%B86)B86)B86)B8F%A86%A8F)A8@IB",
                @"M86%B8F%B8F%B86%B8F%A86)A8F)B8F(*86%B8F%B86%A86%A86)B86%B8F%B",
                @"M8F)A86)A8F)A86)A8F%B8F)B8F)A8F)B86)A8F)B86%A8F$*86%B86)A8F%B",
                @"M8F)A8F)B86%B8F%A86%A""F%A8F%B86)A86%B86%A8F%A86)B86%B86)B8F%B",
                @"M8F%A8F)A86%B86)B8F)B8F)A8F%B86)A8F)A86)B8F)B86(*86)B8F%A8F)B",
                @"M8F%B8F)B86%B8F%B8F%B""F%A86%B8F)B86%B8F%A8F)B86)A86%A80IA86)A",
                @"M8F)A8F%B86%B8F)A86%B86%B8F$*8F%A86%A8F%A86%A86)B86)A8F%A8F)B",
                @"M86)A86%A8F)A8F%A8F)B86%B86%A8F)A86)A86)A8F%A86%B8F%A80IA8F%B",
                @"M8F%A86)A86)A8F%A8F)B8F)A8F%B86%A8F)B8@IB86)B86)A8F%B8F)A86%A",
                @"M8F)B86%B86$*8F%A8F)A8F)B86%B8F%B86%A8F)B8F%A8F)B86%B8F%A8F)A",
                @"M8F%A8F%B86%A8F%A8F)A86)A8F)B86%A86)B8@IA8F%A8F)B8F%A86%B86%B",
                @"M8F)B8F)B8F$*8F%A8F)A8F%A86%B86)A86%B8F%A8F)B8F)B8F)B8F(*86)B",
                @"M86%A86)A8F%B8F)B86)A8F%B86%B8F)A86%B8F%A8F%B86%B8F)A86%A86%A",
                @"M86%B86%A86(*8F)B86)B86)A86%A8F)A8F%B8F%A8F%B86)A86%A8F%A86)B",
                @"M86%A86)B8F%B86)A""F)B8F%B86)A8F%B8F)B8F)A8F%B8F)B80IB8F)B8F)A",
                @"M86%A86)B8F%A8F%A8F%B86(*86%A86)B8F%A8F)A86%B86)A86%B86)A""F)B",
                @"M86%A8F)A8F)A8F%A8F%A86%B86%A86%B86%A8F)A8F%A86)A8F(*86)A8F)A",
                @"M8F%A8F%A8F)A86)A8F%A86%A""F)B8F%A8F)A86%A8F%B8F%A8F)B8F%B86%A",
                @"M8F%A86%B""F%B8F)A8F)B8F)B86)B86%A8F)A86)B8F%B86)B8F)A86%B86)A",
                @"M8F(*8F)B8F)A86%B86%A8F%A8F%A8F)A86%B""F)B86%B8F%B86)A86%B86)A",
                @"M86%B8F)A8F%A86%B86)A86)B86%A8F%B86%B86%A8@IA8F)B86)B8F%A8F)B",
                @"M8F)A8F)A8F%B8F(*8F)B86%B8F%B8F%B8F)A8F)A86%A8F)A""F)B86)A86)A",
                @"M86)A8F)B86%B86)A8F%B86%A8F%A8F%B86)A86%A86%B86%A8F%B8@IB86)A",
                @"M86)A86%A86%A8F%A86%B86%B8F$*8F%B8F)B8F%A86)B8F%A86%A8F)A8F%B",
                @"M8F%A8F%B8F$*86%B86)B86%A8F%B8F)B8F)A8F)A8F)A""F)B86)B8F%B86%B",
                @"M8F%A8F)B8F)B86)A80IA8F%B8F%B86)B8F%B86)A86)A8F)B86$*86%A8F)B",
                @"M86%B8F%B86%B86%B86)B8F)A""F)B86%B8F%B8F)A8F)A86%B86%B8F)A8F%B",
                @"M86%A8F%A8F)B8F)A8F)B8F%A86)A86%B86)A86)A""F)A86)A8F%A8F)A86%B",
                @"M8F%B86%A8F%B8@IA8F)A86)B8F%B86)A8F%B86%A8F%B8F)B86%B86%B8@IB",
                @"M86%B8F)B8F%A86)A86)A8F%A8F%B8F$*8F%B86%B86%B86)A86)B8F)A86)A",
                @"M86)A86%A8F%B86%B86)B86)B80IB8F%A86%A8F%A8F%B8F%A86%B8F%A8F%A",
                @"M86)B86)B8F)A8F%B8F%A""F%B8F%A86)B86%A8F)B8F%A86)B8F)A86%B8F%A",
                @"M86%B86%B8F%A86)B86%B86)B8F%B8F%B8F%B86%A86)A8F(*86%A8F)A86)A",
                @"M8F%B86%A86)A86)A86%B""F)B86%B8F%A8F)B86)A86%B8F%B8F)B8F)B8F%B",
                @"M86%B8F%B86%A8F%B86)B8F)A8F)A86)B86)B8F)B86)B86$*8F)B86)B8F)B",
                @"M8F%B8F)A86)A86)A8F%B""F)B86)B8F)A8F)A86)B8F%B86)B86)B80IA86%B",
                @"M8F)A86)A86)A86)A8F%A8F)A8F%B86)B86%A86)B8F)B8F)A""F)A8F)A86)A",
                @"M8F%B8F%B86)A8F)B8F)B86%B86)A86)B8F%A8F)B8F%B86)A86%A8F)B86%A",
                @"M86%B86)B86)A86%B8F)B86%A86%B86%A8F%B8F)B86%B8F$*8F%B8F)A8F)B",
                @"M86%A86%A86)B86%B8F)B86)B8F)A8F)A86%B86)A8F%A8F)B8F%B""F)B86%A",
                @"M86%B86)A86%B8F%A8F)B86%A86%A8F%B8F%B8F)A86)A86)A86%B86%A8F)A",
                @"M8F%A8F%B""F)A86)B8F)B86)B86%A8F%B8F)B86%A8F)B8F)B86%B8F)B8F)A",
                @"M86)B86%A86%B86)B86%A86%A86%B8F%B8F$*8F)A8F)B86%A8F%A86)B8F%B",
                @"M8F)A8F%A86%B86)B86%A86)B8F%A8F%B86)B8F)A8F)A8F%B86%A86%A8F%B",
                @"M8@IB86%A8F%A86%A8F)A8F%B8F)A8F)B8F%A8F%A8F)B86%A8F)B86%B8F%A",
                @"M86)B86)B86%A8F%A8@IA86%A86%B86%A86%B8F)A8F)B86%B86$*8F)A86%B",
                @"M8F)B86)A86%A8F)A8F%A86%B86%B86%A86%B86)A86)A8F%A86%B86%A86%B",
                @"M86)B8F(*8F%B8F%A86)A8F)B86%B86%B8F)B86%B""F%A86)B86%B86)B8F)B",
                @"M86)A86%B8F%A86%A8F)B8F)A86)A86)A86)A8F%B86)A8F%B8F%B8F)B""F)A",
                @"M8F%B86)B8F%A8F%A86%B86%A8F)B8@IB86)B86)A86%A86)B8F%B8F)B8F)B",
                @"M86%B8F)A86%A80IA86)B86)A86)A86%B8F)A86%A86%B86(*8F)B86)B86%A",
                @"M8F)B8F%B8F)A8F%B8F%B86%A8F%B86)A86)A8F%A8@IB8F%B86%A86)A86)B",
                @"M86)B8F)B86)A86)A86%B86)B8@IB86%B86)B8F)A86%A8F)A8F)A86)B8F)B",
                @"M8F)B8F%A86)B8F)A86)A""F%A8F)A86)A8F%A86%B86%B86%B8F%B80IB8F)A",
                @"M8F)A86)A8F%A8F%A86)B8F%A86%A8F%A86%B86%A8F%A86)A8F%B86)A86%B",
                @"M8F%B86)B8F)B8F)A8F)A""F)B86)A86)A86)A86%B86%B8F%B8F%A8@IA86)A",
                @"M86%A86%A86)A8F)B86%A8F%B8F)B8F)A86)A8@IB86%A86)A86%B8F)A8F)B",
                @"M86)A86%B86)B86%B8F%A80IB86%B8F)B86)A8F%B8F)A86%B86)B8F%B8F%B",
                @"M8F)B86)B86%B8F)A86)B86)A8F%B86%A8F%B86)A86)A86)B8F%B8F%B8F$*",
                @"M8F%A8F%A8F%A8F%B86)A86)A86%A8F)B""F%B8F%A8F)B8F%B86%B86%A8F%B",
                @"M8F%B86)A86)B86)B8F%B8F)B86)B8F)B86%B86)A8F)A86)B""F%B8F)A8F)B",
                @"M8F)B86)A8F%A8F)B86)B86)B8F)B86%B""F%B86%A8F)B8F)B86%B8F)A86)B",
                @"M86%A8@IA8F%B8F)A8F)B86)B8F%A86)A86%B86%B86)A8F%B80IB8F)B8F)A",
                @"M86%B8F)A86%A86%A8F)A8F%A8F)B8F%A8F)B8F%A86%B""F)A8F%B8F)B8F%B",
                @"M8F)B8F)B86%B8F)B8F)B86)A8F)B8F%B8F%B8F)A8F)B8F%A8F)A86%A8F)A",
                @"M""F)A86%B8F%A86%A86%A8F%B86%A8F)B86%B86%B86%A8F%A8F%B86)A86%B",
                @"M8F%A86%B8F%A8F%A""F%A8F)A86)B8F)B86)A86)A8F%A8F%A86%B86)B86%A",
                @"M8F)A8F)A8F%B8F)B86%B8@IA8F)B8F)A86)B8F%B8F)B8F)B8F%A8F$*86%A",
                @"M8F)A8F)B8F)A8F)B86)A8F%A86)B""F%B86%B86%A86%B8F%A86%B86)B8F%A",
                @"M8@IA86%A8F%A8F)B8F)A86)A8F%B86%A86%A86%A86%B8@IB8F)A8F%B86%B",
                @"M8F)A8F%A8F%A8F%B8F$*86)B8F%A8F)A8F%A86)A8F)B8F)B86)B""F)A8F)A",
                @"M8F)B86%A86%B8F)A86)A8F)A8F)A86)B8F)B8F%A86)B86%A86)B8F)B86%B",
                @"M86%B86)B8F)A86%A8F$*86%A86%A8F%B8F)A8F%B86)A8F%A8F%B""F)B86%B",
                @"M86%B8F)A86%A8F)A8F)A8F%B86%A86%A8F%B86%B86%A8F(*86%B8F%B86%B",
                @"M86)A86%A8F%B8F)A8F%B""F%B86)B8F%B86)A86)B8F)B86%A86)B8F)B8F)B",
                @"M86%B86)B8F)A86%B8F%B8F)A86%B8F)A8F)B8F%A86%B8F)A86%A86%A86%B",
                @"M86)A86%B""F)B8F%B86%B86%A86%B8F%A86%B86%B8@IB86)B86%A8F)A86)A",
                @"M86)A8F)B8F%A8F$*8F)A8F%A8F%B86)B8F)B86%B86%B86%A8F)A86%B8F%B",
                @"M8F)A8F%A80IA8F)A8F%A8F)A86%A8F%A8F)B86%A8F$*86%B8F%B86%B86%A",
                @"M8F)B86%A86)B8F%B8F%B86)A8F)B8F)A86)B8@IA86)B8F)B8F%B86)A8F%B",
                @"M86)B8F)B86(*86)B86)B8F%B8F%B86%B86)A86%B8F)B""F)A86%B8F%A86)A",
                @"M8F)A86%B86%B86%B8@IB8F)A8F)B86%A86)A86%A86)A86%B86)A86%A8F)B",
                @"M8F%A8F)A86%A86)B8F%B86(*86%B8F)A8F%A86%B86)A86)A86%A86)A""F%B",
                @"M8F)A8F)B86)A8F)A8F)B8F%A8F)A80IA8F)B8F)A8F%A8F%B86)B8F%B86)A",
                @"M8F$*8F)A86)A86)A86)A8F)A86)A8F%B86%A""F)B86)A86%B86%B86)B8F%A",
                @"M86)A8F)B86%A86)A8F)A""F%B8F%A8F%A8F%B8F%B86)A86%A8F)B86%B8F%B",
                @"M86%B86)B8F%A8F%A86%B86%A8F%A8F)B8F%B""F)A8F)B86%A8F)A8F)B86%B",
                @"M86)B8F)A86%A8F%A8F%B86%A86)A86$*8F%B86)A8F)A8F%A86%B86%A8F)B",
                @"M86)A86%B8F)A8F%B86)A86%A8F)B86)B86%B""F%A8F)B86%B86)B86%A8F%A",
                @"M8F%B8F%A8F%B86%A8F)B86%A86%A8F%A8F%B8F%A86%A8F%A86)B8F)A8F%B",
                @"M86$*86)B8F%B8F)A86%B8F)B86%A8F%A8F%B""F%B86%B8F%A86%B8F%A8F)B",
                @"M8F)A86%A80IB8F%B86%A8F%A86%B8F)B86%B8F)A86%A86)B8F)B8F%B8F)B",
                @"M8F)A8F)B86)A86$*8F)B86)B86%B86)B8F)B86)B86%A86%B8F%B86%B86%A",
                @"M8F%B86%B86)A86%A86)B""F%B8F)A8F)B86)A8F)A86%B8F%B86%A86%B8F%B",
                @"M8F)A8F)A8F%A8F)B86%A86%B8F%B8F%B86%A8F)B8F)B8F(*8F%B86)B8F%A",
                @"M86%B86%B86%B8F%B86)B""F%B8F)B8F)B86)A8F%B86%A8F)A86)A8F)A8F%A",
                @"M86)A8F)A86%A86$*86)B86%B8F)A8F%A86%A8F%A86%A8F)A86)A86%A86)A",
                @"M8F%B8F)A8F%B8F)A8F%B""F%B8F%B8F)B8F)A8F%A86%B8F)A8F)B86)B8F)A",
                @"M86)A""F%B8F%A8F)B8F%A8F%A8F%B86%B86)B80IB8F%B86%A8F%B86%B8F)A",
                @"M86%A86%B8F(*8F%A8F)A8F%A86%A8F)A8F%A8F)B8F%B8F%B8F%B8F%B8F%A",
                @"M86%A80IB86)B8F)B8F%B86)B86)A8F)A8F)B86)A86)B86%A8@IA86%B86%A",
                @"M8F)B8F%B8F)B86%B8F%B8F)B86%A86%A8F%A8F)B86%B8F%A8F%B86$*8F%A",
                @"M8F)B8F)A86%B86%B86)A8F%B8F%B""F)A8F)A86%B86%A86)A86)A8F)A8F)A",
                @"M86%A8F%A8F%A""F%B86%B8F)B8F)A8F%A86%A86)A86)A8@IA86%A86)B86%B",
                @"M86)A8F%A8F)B8F)A8F%B8F)A8F%B8F)B86%B86)B""F%B86)A8F%B86)A86)A",
                @"M86%B8F%A86)A8F)A8F)A8F)B""F%B86%A86%B8F)B8F)A8F%A86%A8F)A80IA",
                @"M86%A8F)B8F)B8F)A8F%B8F)A8F%A8F(*8F)A8F)A8F%A8F%A86)A86%A86)A",
                @"M8F%B""F%A86)B8F)B86)B86)B8F)B86)A86)A8F)B86%B86%B86)B86)A8F(*",
                @"M8F)A8F%A8F%A8F)A8F)A86%A8F%A8F)A""F%B8F%B86%A8F%B8F%A8F%A86%A",
                @"M8F)B86)B86%A86%B8F)A86)B86)B86)A8F%A86)A86)B86%B8F)B86%A8F%A",
                @"M86%B8F)A86)B8F)A8F)A""F%B86)B8F%B86%A8F)A8F)A86%B8F%B86%A8F%A",
                @"M8F)A""F)B8F%B8F)B8F%B8F)B8F)A8F%A86)A86%A86)A8F)B8F%B86)A86$*",
                @"M8F%B8F%B86%A8F)A86%B8F%B8F%B86%A""F)A8F)B8F%A86)B8F)B86%A8F%A",
                @"M86)A86)B8F)A8F%B8F%A86)A8F(*86)B86)B8F)A8F%B86)B8F)B86)B86%A",
                @"M8F%A86)A8F(*8F%B8F%B86)B8F%A8F%B86%B8F%B8F%B""F)B86%A8F%B8F)B",
                @"M8F%A86)A8F)B8F%B8@IB86%A86)A86)A8F%A8F)B86)A86)B8F%A86)B8F%A",
                @"M8F%A86%B8F%B""F%B8F%A8F)B8F)A86%A86)B8F%A8F)A8F)A86)B86%B""F%A",
                @"M86%A86)A8F)A86)A8F%A86)A86%B86)A8F)B86)B""F)A86%B8F%A8F)B86)A",
                @"M8F%A86)A8F)B86%A86%A8F)A""F)B8F)A8F%A86%A8F%A86%A86%B86)B86%A",
                @"M86)A8F)B8F)A86)A86%A86)A86%A8F%A86%B8F%A8F)B8F)B8F(*86)A86%B",
                @"M8F)B86%A8F%A86)A8F)A8F)A""F%A86%A8F%A86%A8F)B86%B8F%B86%A86%B",
                @"M86)A8F%A86)B8F)B86%B8F%A86%B80IA8F%B8F%B86)A8F)B86%A86%A86%B",
                @"M8F(*86%A8F%B86%A8F%A8F)A86)A8F)A8F)B""F%B86)A8F%B86%B8F)A8F)B",
                @"M86%A8F%A8@IB86%B8F)A8F)A86%B86%A8F%A86)B8F%B8F%B8F%B8@IB8F)A",
                @"M8F)A86)B86)B86)A8F%A8F)B8F%A8F%A8F)A8F%A8F%A86)B8F%A86)B8F(*",
                @"M86%A8F)B86)A86%B8F)B8F%B8F%B8F)B8F)B86%A86$*86%A8F)A8F%B8F%A",
                @"M86)A8F%A86%B8F%A""F)B8F%B8F%A86)A8F)B86)A86%B86%B8@IB86%B86)B",
                @"M86)B8F%B86%A8F%B86%A8F%B86)A8F)A86%A8F%B86%B8F)B86%A86)B86)A",
                @"M86%B86)B8F%B86%B86)B86)B8F)B86%A8F)A8@IB8F)A8F)A86)A8F%A8F)A",
                @"M8F)B8F)A86$*86)A8F%B86%B86%A86)A86%B86)A8F)B8F%A8F%B8F)B8F%B",
                @"M8F%A86%A86)B86%B8F)B86)A8F%B8F%B86%B8@IB86)B8F%B86)A86%B8F)A",
                @"M8F%A8F%B8F)A86%B86)A8F%A86%B86)B8F%B8F%A8F)A8F%A8F)B80IB8F)A",
                @"M8F)A86)A86)B8F)A86%A86%B86%B86%A8F)A8@IB8F)A8F)B8F%A8F)A86)A",
                @"M86%A86)B8F)B86%B8F%B8F%B8F%A8F%A8F%B8F%A8F)A86%B8F%A80IA86%B",
                @"M86)B8F)A86%A8F%A86)B86)B8F)A8F)B8F%B80IA86%A86)B86)A8F%A8F)A",
                @"M8F%A86%A86%A86%A86%B86)B8F)B8F%A86)A8F)A86%A86)A86)A8@IB86)B",
                @"F86)A8F)A86%B8F%B8F%B8F%A86%B8F%A8F%A8F)A86%B8F%B""@H`",
                @"`"
            };
    }
}
