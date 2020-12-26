using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data16 : AbstractData, IData
    {
        public Data16() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                @"M9&5P87)T=7)E(&QO8V%T:6]N.B`R-RTV-S(@;W(@-C@P+3DU-`ID97!A<G1U",
                @"M<F4@<W1A=&EO;CH@,C4M-#,P(&]R(#0S.2TY-C8*9&5P87)T=7)E('!L871F",
                @"M;W)M.B`S,2TR.3,@;W(@,CDY+3DU,PID97!A<G1U<F4@=')A8VLZ(#(Y+3<T",
                @"M.2!O<B`W-S4M.34U""F1E<&%R='5R92!D871E.B`T,RTY,R!O<B`Q,#<M.34S",
                @"M""F1E<&%R='5R92!T:6UE.B`U,""TY,38@;W(@.30Q+3DV,PIA<G)I=F%L(&QO",
                @"M8V%T:6]N.B`S,2TV.#(@;W(@-S`R+3DU-`IA<G)I=F%L('-T871I;VXZ(#,X",
                @"M+38V,R!O<B`V-S(M.38P""F%R<FEV86P@<&QA=&9O<FTZ(#,Q+38R.2!O<B`V",
                @"M,S4M.38Y""F%R<FEV86P@=')A8VLZ(#0R+3,V-2!O<B`S-S$M.38W""F-L87-S",
                @"M.B`S,""TQ-#<@;W(@,38W+3DV-@ID=7)A=&EO;CH@,SDM-3(U(&]R(#4T-2TY",
                @"M-C<*<')I8V4Z(#,P+3@P,R!O<B`X,C(M.34P""G)O=71E.B`S.2TR,S4@;W(@",
                @"M,C4W+3DU-PIR;W<Z(#,S+3(P-B!O<B`R,S$M.3<Q""G-E870Z(#(Y+3<X-""!O",
                @"M<B`W.3@M.34Q""G1R86EN.B`S.""TS,#(@;W(@,S$V+3DU-PIT>7!E.B`U,""TV",
                @"M,S4@;W(@-C0R+3DV-@IW86=O;CH@,C4M-3`R(&]R(#4Q,""TY-S,*>F]N93H@",
                @"M-#(M.#0S(&]R(#@V,2TY-C4*""GEO=7(@=&EC:V5T.@HW,RPU,RPQ-S,L,3`W",
                @"M+#$Q,RPX.2PU.2PQ-C<L,3,W+#$S.2PW,2PQ-SDL,3,Q+#$X,2PV-RPX,RPQ",
                @"M,#DL,3(W+#8Q+#<Y""@IN96%R8GD@=&EC:V5T<SH*-#`Q+#4P,BPR-S8L-#DU",
                @"M+#DL,3<W+#8R-RPS,S`L-C(Q+#0W.""PU.#DL-C(P+#8U-RPQ,S@L-38S+#(V",
                @"M,""PQ-C<L.#,W+#,U,2PY-#,*-#DR+#<Q-""PT-3$L,30V+#DQ-""PU-C4L,CDP",
                @"M+#@X,BPR.#`L-#`U+#8R-BPV-C8L-3DW+#,T.2PT-C$L,S0P+#,T,BPS-#@L",
                @"M-#@R+#@X-0HY,#0L-C(U+#0W,""PY-""PR-CDL.#8S+#<Q,""PW-#<L,C@T+#0R",
                @"M.2PS-S$L.#8V+#0P,2PS-3$L,C4Y+#,W-RPV.2PQ.#DL.#`Q+#<R,PHV-""PR",
                @"M,S@L-S`L.#$L-#<X+#(X,""PT,C8L-C`Y+#0V,""PV,#,L,3,W+#8T-RPU.#DL",
                @"M-S8L,30P+#4X.""PT-S(L.#DQ+#8V+#,W-@HT-3@L-#(U+#4V+#,R,""PS-#<L",
                @"M-S0R+#@X-RPV-#@L,RPS.#DL,C4W+#$T,RPV-#8L,S8R+#(V.""PQ.34L-3`P",
                @"M+#4X-BPX.34L-S,P""C@P,BPU,""PQ.#$L-S0P+#DP.""PW,S(L-#$V+#0R,RPX",
                @"M.34L,3(X+#0T-2PY,#4L,3$W+#0V,BPX.#$L,C`V+#@S,RPX-BPW,C4L,S8Y",
                @"M""C0W-2PQ,#<L,C`S+#0P-""PV,C<L-#DS+#0W.""PX-S`L,S0V+#<W.""PS.#,L",
                @"M-C`T+#<S-RPV-C@L-S(Q+#,S,2PT-30L-S@P+#DQ,BPW.#0*-#8T+#DP-BPT",
                @"M,#4L,C`V+#@X,BPQ.34L,BPQ.38L.#@X+#,T-""PT.3<L-34R+#@T,2PV,C0L",
                @"M,C8S+#0Q-RPT,#0L.#,Y+#4V,2PW.`HS-#`L,38W+#4V.""PS.3`L-S@L,SDW",
                @"M+#$R,RPS-C8L.#(X+#8U,BPT.34L-#0U+#4W,""PR-S4L,30T+#DT.""PW-BPX",
                @"M.3,L.#,X+#,R.`HW,BPQ-S,L-C0U+#0T,RPV,3`L.30Q+#$S,2PS,S4L-#`P",
                @"M+#4P,""PS-SDL.#`T+#@X-RPX,C0L-#<Y+#@S,2PU.#(L.3$V+#,V,""PX.#0*",
                @"M-#8Y+#,U,BPW,#4L.3$T+#<Q-""PS-C<L-3(P+#8P,RPV.#$L,3,W+#$X-""PS",
                @"M,CDL-S`R+#<V+#<W.2PU,C0L-S(L,S$X+#$V-RPV-3`*,S4Q+#4Q,BPQ,3`L",
                @"M-#(R+#DP-""PX,S(L,S0U+#$P,2PU-2PS.#@L,3DV+#4T-RPT,#$L,S4T+#4W",
                @"M+#4R-""PX-S4L,S@V+#4W,""PR-CD*,3<P+#0X.2PQ,S`L,C4Q+#$X.""PR-C(L",
                @"M-S@T+#4Q-RPY-#$L.#@S+#@W-2PS,S(L-#@T+#@R+#4U-BPV-3,L-C4V+#0Y",
                @"M-2PR.#(L-C$Q""C0P.""PU-#4L,3@P+#,T.2PT,C4L-S(L,3,Y+#<P-RPT,34L",
                @"M-S(R+#<R,RPQ-#`L,S4P+#0R-BPS,#$L.#,Q+#0S-2PU,C$L.#DW+#,U.`HU",
                @"M-S0L,CDR+#0Y,2PW,#@L-C(P+#@Y-2PS,S(L.#,V+#4Y.2PU.3`L.#DQ+#4X",
                @"M.2PS,C0L-#4U+#<S-""PS,S,L-C4R+#8Q+#8R-BPS,3(*,S8P+#4Y-2PX-#,L",
                @"M.3,S+#(X.2PT-S4L-3(S+#0T,2PW,S`L,S(W+#0W,RPX-S8L-S`X+#4Y.2PU",
                @"M-3`L-3(Q+#4U-""PU.30L.#,L.3`Y""C0V-RPW,S<L-S`W+#<Q-RPQ-S<L-3<R",
                @"M+#$Y,2PT,#0L-C@Q+#<P-""PW-#@L-3@P+#0Q.""PU-3`L-C0T+#4X+#DX-RPU",
                @"M,C`L-3DY+#<X-`HT-S$L,S(U+#<S-BPU,C`L-#4X+#<R,""PR,#`L.#8W+#0V",
                @"M.2PV-2PV-34L.#$L-S<L,30X+#8U-""PX,RPX.#@L-S$Q+#0S.2PW,3<*-C`Y",
                @"M+#(X,RPY-#4L,30Q+#0V-2PS-3(L-#4S+#@S,RPU-C$L,3DR+#4X,BPT-3(L",
                @"M-#0W+#0P,""PW,C0L-S(T+#@Y-RPT.#,L-3`T+#4X.`HT,#0L,S@R+#$R-""PS",
                @"M,S<L-3@S+#,U-BPX.3<L-C$T+#<R.""PS-#8L-#<Y+#(Y-BPS,S<L-3<L.3`L",
                @"M-C(V+#0Y,""PR,#(L-#`Q+#0P,@HW-2PV-3@L-#`R+#@X-""PS-3`L-C$U+#4T",
                @"M.""PX,S8L,3<Q+#,X-""PX,CDL.3$P+#,S,BPV,S8L-C8P+#@X-2PX,C8L.#<U",
                @"M+#0R-BPU-#@*,S4T+#@Y,""PW-SDL-#`W+#@R,RPX.#,L,C0Y+#,V,""PQ-#(L",
                @"M-#@V+#,Q-BPQ.30L.3$Q+#<R,BPX-C4L-34P+#@V-RPY,#<L-#`V+#@X,PHQ",
                @"M,S(L,S<S+#0Y,""PX.#8L-#DT+#(W,RPU,3@L.#`S+#(X-2PV,#DL.#<R+#8P",
                @"M+#4T+#8U-""PQ-#0L,S(T+#4Q.2PY-2PX,#(L,S0S""C,W.2PR-C,L-3(T+#8T",
                @"M,RPS-3DL-S(V+#@V-2PQ-#`L-S$R+#DY,RPR-C$L,3<X+#<Q.""PV-C$L,S,X",
                @"M+#0U-""PQ-#0L.#@P+#4Q,2PV,#`*-C$U+#<P,RPX,S8L,3@Q+#(P,BPS-38L",
                @"M.#@X+#$S,BPT,#DL,S,P+#4P-2PR,S0L-S0L-C4V+#,W,RPT.3$L,S4P+#4X",
                @"M,""PS,S`L,S$V""C,U-BPX,S<L,CDW+#$S-RPT-3$L-#$W+#<S-BPU.#8L,C`R",
                @"M+#0W,""PW-RPQ.#$L-S0R+#$S.2PW.#`L,30T+#,T.2PR-S8L,C`R+#,T-PHT",
                @"M-#(L-#8V+#4T-RPX-S(L-#8S+#,R-RPV,C4L-C$V+#DW.2PV,38L,3$Y+#8U",
                @"M,""PR.3,L,S0R+#4W-RPX-S`L,3@R+#$T-2PQ-S4L,S,X""C@W,RPR,#$L,S8P",
                @"M+#8S.2PQ,38L.#,Y+#,U-""PX,C@L.3`U+#4X-""PY,3(L-S@Q+#8V,""PV-#<L",
                @"M.#DS+#(V-BPS,S0L-CDL-S$Q+#4T.0HR,S$L,C@Q+#$U,RPV,38L-#@R+#,X",
                @"M,""PX-S0L-C(R+#0W-RPT.3`L-C0V+#<P.""PY,#(L,S$V+#0Q,RPY,RPX,RPR",
                @"M-CDL-3<T+#$W-`HR,#0L-3(L.#<U+#8Q.2PX-S`L,S@U+#0U,""PU-S,L,3<S",
                @"M+#<S.2PU-""PQ-3`L-38X+#,U-RPW-#$L-S$L-34W+#DP-RPU-SDL-#<Q""C(V",
                @"M.""PV,34L-S(V+#@R-2PS-C`L.#@W+#,W-RPU,C,L.3DS+#0Y-2PR-C@L-3`Q",
                @"M+#$W-2PR,#0L-#@Y+#8Q.2PV-#,L.#<Q+#@V,RPU,@HW,3@L-C`Y+#(P-""PS",
                @"M-3,L,3<X+#,T.2PU.3(L-#`W+#<S-""PW,C$L-#(P+#@Y-""PT-3DL,S`P+#<T",
                @"M,BPW,3(L-C`L,S8V+#<R.2PQ.#D*.#DY+#8U-RPV,S4L,3(V+#4Y,""PU.#$L",
                @"M-C4X+#0Q.""PY-#4L-#@U+#4W,""PY,#$L-#<Q+#8T-""PQ-S4L,3,Q+#$Y-BPQ",
                @"M-3<L,3@V+#@S""C,R-2PW-C(L,S$V+#0W-BPY,BPW.#,L.#DT+#,W-""PV,S4L",
                @"M-S$S+#0W,RPS,C0L,S4S+#<T.2PY,3(L-#4V+#0P,2PT.#`L-C4X+#DQ-0HX",
                @"M-C4L,3`Y+#4P-""PW,C0L,3,S+#8V,RPR-C$L-#$W+#,T,BPY,#<L-S$L,3@P",
                @"M+#$Y,2PU.#<L,C8Y+#4W.""PY,RPR-3<L-C(L,SDW""C@X-""PX,S,L,S,Q+#4X",
                @"M.2PX,S`L.3$Q+#DP,BPV-3,L-#8Y+#4P,2PV,C0L,S$Q+#0U,RPV,3,L.30V",
                @"M+#<W.2PT,#,L-S$Y+#<T.2PU-30*.#(W+#$V-2PU.3(L-S(W+#4W,BPW,30L",
                @"M-#4R+#DT.""PX,RPV.#(L,3<X+#8R-RPX-2PT-#(L-S$Y+#$Y,RPW-#$L-#<U",
                @"M+#,U.""PS,C(*,SDQ+#,S,2PS-3(L-S(U+#@P.2PS.#DL,3<S+#$S.2PU,C,L",
                @"M-S$S+#4T-BPX,""PV,S4L.#<P+#$X-RPX,#$L,SDP+#$Y-RPX,#,L-S`X""C<Q",
                @"M-""PT-S0L,C<V+#0S-""PS,S8L-3(P+#$W,2PT,#<L,S,X+#(V,BPW.3@L-C4W",
                @"M+#$X.2PR-S`L,S(W+#,R-""PU,C0L,C@W+#@V,BPY-#0*.#@Y+#4X,""PX,CDL",
                @"M-C,T+#0S.2PU,3<L-34P+#@W+#(P,BPT.#4L-#@V+#<S.""PV.#$L.#8V+#(Y",
                @"M,BPQ,S8L.#`R+#DP+#(Y,2PQ.#`*-C4P+#,W.2PS-3DL,S8T+#@X-RPQ.3(L",
                @"M,C<U+#,X-BPT,S`L-S0R+#8R.2PY,#,L,S8T+#DR,""PR,S4L,S,V+#,T-2PW",
                @"M,#,L-C0W+#0W-0HQ-3$L-3@S+#@S-2PY,BPU-S@L.#(S+#0R-2PQ,C8L,3DY",
                @"M+#4P,BPW,S$L,3DS+#8X,""PW,S(L.#`P+#0Y,RPX.3,L.#@U+#4R,2PS-S@*",
                @"M-S`W+#,R-""PU.2PQ,#@L-#0X+#(P,BPQ,#<L-38U+#4R-2PY,3(L,S<Q+#@Y",
                @"M+#(V,BPT.#<L,C0W+#@R-2PQ,C0L-S@P+#,R,""PV,C`*,S<W+#8U-BPX,""PS",
                @"M,3`L.#8T+#$Q-2PW-S@L.3`V+#8Q,2PU-2PQ-#(L-3$R+#0P.""PY-#DL,S@Q",
                @"M+#4V,2PT.#DL,3,R+#0W,""PW,3(*.#8W+#@W,""PX,#`L,3<U+#@R-2PT,#$L",
                @"M,C8R+#$U-2PR.#`L-S@R+#DP-""PS.3DL,SDS+#,P,BPU.#8L-3DY+#4Y+#,W",
                @"M-2PR-S0L-SDY""C@Y-RPV,#,L,C8R+#4Y,""PU.#`L,C@Q+#8T-2PV-38L-30Y",
                @"M+#@P,""PR,S(L.3`R+#0R-2PT-S,L-#0Y+#0R,RPQ-S0L-C$Q+#DY.""PQ-S4*",
                @"M,3DY+#0Q-""PX.3$L-#0U+#$Q-""PS,30L.#,S+#0Q,BPY,3`L-3(R+#<R,RPR",
                @"M-C(L-3<S+#0Q.2PW-S8L.3$T+#<R-""PV,3(L-3`R+#,S,`HY,S0L-#<X+#@Y",
                @"M,2PQ.3,L-S4L,3,P+#4U+#<S.2PW,S@L.#<U+#$R,BPX,2PX,S@L-C$Q+#$Q",
                @"M-2PX-S$L.#,S+#0T.""PV-#8L-38X""C4P.""PS.30L-3DU+#(W,2PS-C`L,S<U",
                @"M+#4X-RPS,CDL-38X+#8R-2PW,#8L-C(Y+#8P,BPX-C0L,S,R+#,Y,BPQ,S8L",
                @"M-3<P+#8R,""PT-#@*-#$S+#,X,2PT,C<L,C8T+#(X.""PS-S,L.""PU.#,L.#,T",
                @"M+#4V+#0U,2PS-C$L,S0P+#$Y-2PT-C(L,3@S+#0T.""PV-S(L.3`U+#,U,0HT",
                @"M-#(L-C`Q+#,P-""PQ,SDL,3,T+#0T.2PU-3<L-C4L.#@T+#$T-2PQ,3<L-C$P",
                @"M+#<X,2PU,3<L-#(S+#DT-2PU-S0L-#4X+#,W,RPR-C,*,3$Q+#$X.""PW-#,L",
                @"M-#DU+#8Q,2PS.3`L,3@S+#$T,2PX-S4L-3@W+#@S-RPR.#(L,CDS+#4Y-2PQ",
                @"M.#4L-#<U+#0Y,BPS-S8L.3(L,C4U""C$X-BPV-#(L-S`L-3(S+#$T,""PS,#(L",
                @"M,3DS+#<S,BPV,RPT,CDL,30Y+#0V,2PQ-C@L-S0R+#(X,""PR,S,L,C,T+#0Q",
                @"M.""PR,#0L-3`P""C,U-RPY,BPU-C<L-#0P+#4W,BPU-C4L,C,S+#0V-2PR.3,L",
                @"M.#$P+#@Y-""PX-S`L-#`U+#4Y,BPQ,S$L-S`T+#<R.2PV-#4L,S,X+#<X,`HV",
                @"M,#0L,3@W+#,S.2PQ-S,L.#@V+#DT-""PW,38L,3DR+#8R,BPV-3@L,C<Y+#DT",
                @"M.2PV,#,L.#@U+#@X,RPU-C@L,""PW-#@L-#(T+#,V,@HW,C@L.#<S+#DP-""PT",
                @"M,#4L-#@R+#8U-BPU.3`L,C<P+#4X-RPU,BPV,3DL,S`P+#DX-RPT.#<L.#<Q",
                @"M+#DT,BPT,C$L.#`P+#(P,""PY,3`*,S$U+#4W-RPS-3$L.#,Q+#8S+#@P+#8R",
                @"M+#0Q-RPQ,3DL,38W+#(V.""PQ,S$L,S(X+#0Y,BPT-S$L,S8S+#0P.2PQ.#0L",
                @"M-3<X+#@P,`HS-38L-#`U+#4V-2PV,C0L,3,W+#$T-RPS-#$L-C$W+#<T.""PQ",
                @"M-S0L-#8V+#8R+#$X,2PR-CDL,C<W+#@R-""PV-S0L,C<Y+#,Y-2PT,3$*-S$V",
                @"M+#@P,2PQ.3`L-C$U+#$W-""PU-30L-3@X+#@X-2PQ.#$L-S$U+#8W,BPR-38L",
                @"M-#(P+#<T-2PV-3<L-S<V+#$V.2PS-3(L,3DS+#<R,@HT.3<L,3`W+#8X,""PY",
                @"M,#$L-S,Q+#$S-RPQ,34L,3DU+#,U,RPQ,3`L.#8Q+#0P,2PX,S8L.#,V+#8V",
                @"M,RPU,#DL-#$U+#4Q-2PT,3@L.#DU""C(W-BPT-S$L-38U+#8P-BPW,#0L,3$V",
                @"M+#0V.""PS-3$L-3DS+#,X-2PR.#0L,3@P+#$Q,""PQ-#4L,S8R+#$V-RPV-S$L",
                @"M-C0V+#<T,2PV-#<*-#0P+#,V-""PT-S8L-S(L-S(L,3DR+#$R-RPR.3,L,C@S",
                @"M+#4Y,RPU,#(L-30T+#8R,""PU-#@L-C0T+#<Q.""PT-#<L.3$T+#,S-2PV-#,*",
                @"M.38L.#(R+#,Q-RPS-C0L.#<T+#4W,2PR-S`L,C@X+#,Y.""PQ,C0L-C<L,3`W",
                @"M+#8U,BPT-3,L-S@S+#DQ-2PQ,C<L-3`Q+#,X-2PQ,S@*,C@W+#0R,RPS.3@L",
                @"M,CDU+#4T.""PU-3,L.#<X+#,T.2PU.#(L,S$Y+#4X,RPT-C(L-C`U+#DP-BPU",
                @"M.3@L,3DP+#,Y.""PW,S(L.#@R+#(X-@HQ.3<L-S(S+#(X,2PT.#@L,S(U+#$Y",
                @"M-""PQ,C@L.#@U+#<Y.""PW,3<L,RPR,S(L.3,L,3(W+#@Y,""PT.30L,C`U+#<R",
                @"M+#0P.2PQ.3<*,3,V+#8W-""PS.3,L,C<W+#,R.2PQ.#DL,SDX+#<Q,2PV,""PU",
                @"M.#DL-#4T+#,X.2PX-S,L,3DY+#(W.""PS.#`L.#@X+#4Y,""PR.#`L,S,X""C<W",
                @"M.2PS.3$L,3@V+#@R-2PS.3`L-S,S+#$R,BPU-""PW,C8L.#<L.30V+#8U.""PY",
                @"M-S8L-C(X+#DQ+#(Y,2PX.3DL,3(U+#@S.2PS-#8*-#`S+#,U,RPS.3(L,3(S",
                @"M+#4X,RPW,S`L-#$V+#4U-BPT-3@L-3<W+#$S,RPT,C4L-S`Y+#(S-""PX,S0L",
                @"M.30T+#4X,BPT-34L-C$Q+#$V,0HY-#4L.30V+#DQ,BPQ,S@L-#(Y+#0T,RPQ",
                @"M,3@L,S$Q+#0V-2PY-#(L-#4Q+#@S.""PU,C4L-S(P+#@X-BPU-C$L-C4T+#0Y",
                @"M.""PW-#`L-#4T""C4P,2PW-#<L,SDV+#$Y,2PY.3<L-#0Q+#(P-BPT.38L-34U",
                @"M+#@X-2PT-34L-#$X+#8Q-""PW,BPT,#0L-S(R+#0W.2PX.#`L-38Y+#0Y.`HT",
                @"M-#`L,SDX+#(P-BPV,C,L.#`Q+#$R-""PT-3DL.#(U+#(X,BPY.#4L-#4X+#DQ",
                @"M+#(V-BPV.#$L.#8S+#<Q-RPT,#DL-S0T+#$X,BPX,S4*-S$P+#@V-RPR-3DL",
                @"M-C$X+#4W-""PX.#(L-C(X+#8Q+#@R-2PR-3$L-#4P+#(W-2PW,3<L-#$R+#8P",
                @"M-RPU-S8L-#4R+#8P-BPT,C8L-#`V""C@Y-BPR-S8L,SDW+#,T,RPS.#4L,S@S",
                @"M+#@Y-""PS.#,L,3,S+#<P,RPW-#@L-3<W+#$X,""PV,C0L-S$P+#<Q.""PU,#8L",
                @"M-3@Y+#<S-RPV,#,*-S`V+#<R-""PQ.#$L.#0Q+#0U,BPX,S(L-#<U+#@V,2PR",
                @"M,RPQ-C<L,S$V+#(U.""PW.#(L-#8U+#,U,""PT-#4L,3@U+#(P,RPV.#(L-C(*",
                @"M-C,T+#,S.2PS-#<L.#<T+#,Y,RPR-C8L-3`L,30V+#8T,RPS.#(L.#<Y+#0U",
                @"M-""PQ.#DL-C@R+#,P,2PU,3@L-#(S+#@S.""PX,CDL-C`P""C8U,BPW-#@L.#,T",
                @"M+#4U.2PW,""PS.3`L,38R+#4T-2PS,C(L-S<U+#4W-RPV-#0L,C`V+#0R.2PQ",
                @"M-S8L-#<R+#0Y-2PQ.#,L-3(U+#8U.`HS,C4L-#DY+#(S.2PQ,S4L,C@P+#4Q",
                @"M-BPS,38L-S@Q+#<W-BPR,#0L-30W+#8T-RPT,#`L-3$L-S(V+#@R,BPS,C4L",
                @"M-3$T+#4R,BPW,0HS-S4L,CDP+#DP,""PR.3,L.3`R+#8T,RPR-S$L-S@S+#,X",
                @"M,RPV,#4L,C,R+#<X,""PS,C4L,S0X+#8P.""PX,34L.3`U+#DP.2PU-C(L-#`R",
                @"M""C@V,BPT,C@L,3$Y+#@R+#,V,""PQ.3$L,CDR+#(X,2PQ.3(L-#DV+#0V,BPQ",
                @"M,3,L-3<L-S8Q+#4U-2PT,#`L-3$L-C$P+#4T+#0U-@HT-C`L.#`P+#(V,RPQ",
                @"M-S`L-#DX+#8Q-RPQ-""PU,3DL,S8U+#0W.2PU,3$L-C8P+#$T-""PT,C,L-#$S",
                @"M+#0U-""PU-3<L.#8S+#,P,""PR-3<*,S4Q+#@X-RPT-S@L,30W+#,S-BPV,C<L",
                @"M,3$P+#4U.2PW,C$L,C8P+#,R-2PQ-#$L-#8X+#$S,BPR-S8L,S8V+#(W-RPT",
                @"M-C@L-C$L,CDP""C0U,2PS,3<L,3DT+#<R-BPY-#@L,S@P+#0Q-BPX-#$L.#,T",
                @"M+#0Q-""PT-S@L-S4L-C(X+#4T-RPQ-""PU-S,L,S<W+#DP-2PW.#,L,S(X""C0P",
                @"M-2PX.30L-3<U+#,P,""PU,3(L-#`Y+#8T-2PS,#(L,SDR+#,T-RPS-3(L,C`L",
                @"M-#@W+#8R,BPS,C0L-C@R+#0X,RPV-C,L-#8U+#@V-`HQ,C(L.#`T+#,R,""PS",
                @"M.3,L-#<W+#8W,BPX,S4L-30W+#<Q,2PT-S$L,3(V+#@X,BPQ,C4L-S(L.#@L",
                @"M-#DU+#$Q-RPQ,S`L-3`L-3@P""C0T,BPW-SDL-#`V+#8P,2PY,3(L-#`V+#4W",
                @"M,BPT,S4L,3,T+#$R.2PT,SDL-3`L-3@X+#$Q,""PU-CDL-30V+#<W.2PQ-S<L",
                @"M,3$S+#<T-0HX,S@L-#(X+#4X,RPW,S`L,C@Q+#$Y-BPW.#(L.#,R+#,S-""PV",
                @"M-#,L.#8U+#8S,2PU-C4L,C`R+#,V-""PS.3@L,CDY+#@R-2PT,#0L-3@S""CDT",
                @"M-2PV.#$L-#@T+#,T-RPU-#@L-#,P+#,V.2PT.#DL,3<T+#0X-2PX-C0L.#<T",
                @"M+#$Q,BPR,#$L-3`Q+#,U-RPS,C@L-S@Q+#$T,BPW,S4*,C@W+#<P,BPS,C`L",
                @"M,34W+#4Y,BPX-SDL-3<X+#4Y-RPT.3`L,C`V+#<W+#DP,""PX,S`L-S<L-38P",
                @"M+#DP.2PW,3`L.#8R+#@Y.2PS-#D*-#0X+#,S-2PU-C`L.3`X+#$X-2PW-#(L",
                @"M,3,T+#,Y.""PU-C8L-3$L,C<X+#,Y,""PU,C$L.3$V+#(X-2PR,S8L,3(S+#<X",
                @"M-""PR-C(L,S8P""C<V+#,Q.""PY,S@L-34W+#<Y+#$W,2PY,30L-#@Q+#(S,2PR",
                @"M-C$L.#(Y+#@Y-BPV-3<L-S`V+#0Y,2PS,S$L.#(T+#,V,BPX,C(L.#8Q""C0S",
                @"M,RPX,#,L-3<W+#,R-BPR-C<L.#0Q+#$S.""PQ,S$L,S,X+#$Y.2PQ.3$L.#0R",
                @"M+#0V-""PQ.3,L,38W+#0U-RPX.#@L-C(L-3(T+#0V,`HS,S(L.30Q+#,V,RPT",
                @"M.#$L,3<Y+#,V,2PQ,3@L.3$U+#<S-RPQ,S$L-34Y+#8Y,""PV,C$L,3DY+#8Y",
                @"M+#,U.2PW,S$L-S$T+#DP-BPX,#$*.#(U+#<W.2PV.#$L,S8W+#DP+#@W-RPQ",
                @"M-#,L,C<S+#$X-""PS,3<L-S<L-#<S+#8U,""PU-C0L,S8Q+#DQ,""PX.#4L-38X",
                @"M+#4W-2PW,C(*-C$X+#$P.2PQ-S0L.#(V+#4U,BPW,RPU,3$L,S<S+#4U-RPW",
                @"M-2PY,2PS.3$L-C4V+#(U.2PT,#<L-S0Q+#,P,""PX,C8L,34Y+#$W.0HR.#,L",
                @"M-#4X+#DP,2PT-C8L-C`Y+#DW-BPT-S,L-#$U+#<Y+#8W+#4V-BPS.#<L-C,U",
                @"M+#@X,BPR,#,L-C0Y+#<Y.2PW,S8L-C`S+#$Q-@HT,34L-#0W+#8X,2PW,3`L",
                @"M-34P+#<R-RPR.#DL,C@T+#4T+#(X-RPY-#4L,S@U+#0Q-BPV-#8L,C@P+#4X",
                @"M,2PW-C8L-#DX+#4Y.""PR.3,*-#0W+#0P-RPX.3`L-#@R+#@P,RPT,#4L,S`P",
                @"M+#4X.""PU-S$L,C`S+#$Q,BPR,S$L.#<T+#(V-BPX,S(L,S,X+#,T,""PT,S@L",
                @"M-#`V+#<Q,`HV,C0L.#4L-#8W+#0X-RPT-#,L-#`T+#<W.2PW-BPT-34L,S4S",
                @"M+#$L-C(X+#(X.""PU-3<L,S4V+#8P,2PW-#DL,3(Y+#$S-BPS-#`*,3<S+#4T",
                @"M.""PT,3,L-S`Y+#$X-2PS-#DL-#<P+#8S-2PS,C@L,C<Y+#<T,2PX,S,L-#$R",
                @"M+#8S,BPQ,C4L-#@X+#,W-""PR.#0L,3,S+#4W.`HV,3,L-3(U+#<R-2PX.3@L",
                @"M,SDY+#8V,""PV-#0L,C`Q+#$Q-""PV,#<L-#4U+#,U,""PQ.#8L.#,S+#$R,RPR",
                @"M.#DL-C,R+#0R-BPV-#<L-C0*,S4X+#4V+#4L-S<X+#4X-RPW,3`L-#<Y+#$X",
                @"M-""PT,#@L,C@V+#<T,RPR-S`L-S$Q+#0V.""PS.3<L,3$R+#8R,BPQ.#$L,S@U",
                @"M+#@P""C@X.2PS-#`L,38X+#0Y-BPW-BPU-SDL.3DP+#4V+#,Y-2PT-#8L-C`W",
                @"M+#(X,""PU,3(L,S4Y+#8P-""PR.#(L,S@T+#8T-RPT.#8L-3@T""C0X,2PT-38L",
                @"M-S,U+#0Q.""PU.#4L-S(S+#DR-BPQ,CDL-C(W+#4U,RPT.34L-S<X+#$T,""PU",
                @"M,2PV,C0L-C(X+#@R-BPT-3,L-C4U+#@X-0HW-S@L-C`R+#0T-BPW,C8L,SDV",
                @"M+#8R.2PV,S(L,C`P+#0V-2PU,3<L,S@R+#0W-BPR.#4L,C4Y+#<P.""PQ,C,L",
                @"M.#@L-#`T+#0R-2PV,C`*,C,S+#@Y-2PX,#(L.#<X+#4X-2PQ,3<L.#(L-3`X",
                @"M+#0P.""PT-#4L,3<W+#@W+#DQ+#4X-2PS.3DL-38W+#0P-RPS.#4L,3`X+#(W",
                @"M-`HT-S4L.#DR+#4X-""PY,#4L-S0X+#,U.2PQ.#(L,C@P+#0X-""PR.3,L-C(P",
                @"M+#<S-""PW,CDL-3`S+#8P,2PR-S4L-SDY+#0Q.""PS-S,L,S<X""C(V-BPU-3(L",
                @"M.3`X+#4Y,2PW,C`L.#$T+#$W,""PU.3,L-S$T+#,U-RPQ,38L-34P+#$W-RPT",
                @"M-#$L,3@Y+#$S-""PW,C`L-S`U+#0Y-""PQ-CD*,3$R+#DT-2PW,30L,SDQ+#,W",
                @"M-RPX,2PT-C<L,S@Y+#(W.2PR.3DL,S8Q+#DQ-BPQ.34L,3`Q+#$Q,2PQ,3`L",
                @"M-#0Y+#4Q-RPX-BPW,3D*,C0R+#0T.2PT-38L,C<R+#<X,RPS,S@L,SDV+#,U",
                @"M,RPW,34L,3@S+#4W,2PV-#,L.#@R+#0Q-RPS.#4L.#8Q+#<X+#$T,2PQ-S<L",
                @"M-S0Q""C,P,""PQ.38L,S4Y+#$Q.2PV,#0L.#,V+#0Y,""PV-#8L-C(R+#8V,BPU",
                @"M,#$L-C4U+#<W.""PQ.3`L-3<X+#<S,RPS-#,L,3(X+#0Y,2PU,#,*-#DV+#4Y",
                @"M-BPW,3$L-C(Q+#<R,""PS,C`L,S,S+#@R,RPQ.#,L-38R+#0V.""PR.3$L-#(Q",
                @"M+#,Q-2PS,S@L-S,Y+#(Y,BPW-#4L-30L.#$*-#@X+#,W,""PX,S`L,3@U+#0U",
                @"M.""PS.#8L-C(X+#(W,BPQ-#,L-3$S+#,W,RPV-30L.#`R+#,U.2PT-S<L,S$V",
                @"M+#8R.2PS-C(L-C4U+#0R,@HY-#0L-3,X+#8R.""PU,30L-S$P+#$Q,""PW,30L",
                @"M-S(Q+#$R,BPV-30L-#$Q+#0Y,2PV,C8L-C`R+#,X-RPR,#8L-3<L,SDW+#8U",
                @"M,RPT,#0*-S`Y+#(X.""PR,BPW,#8L-S@S+#(W.""PS.#@L,S(Y+#$W-""PT-#4L",
                @"M-#4R+#$T-""PQ.30L-SDL-3DX+#,P,""PX.34L-3(S+#,X-BPR,#(*,S@Q+#(Y",
                @"M-""PX-C,L-3@L.#,S+#@P+#<P-RPV-#,L,S(Y+#@W-2PX,S0L.#(W+#0W.2PX",
                @"M,S@L,3(X+#,X-""PT-C<L-#4T+#(P-""PX,S0*,C@T+#4W-2PU.38L-S<T+#4P",
                @"M,BPU.3,L-S`T+#0T,BPQ,S8L-3@L-S0Q+#<Q+#4Q,RPS-S@L,SDQ+#0X.2PQ",
                @"M.30L,S`R+#(X.2PX,S$*,SDU+#8Y+#$R-RPW,#4L-3(L-S0S+#,W-BPV,CDL",
                @"M-C`Y+#0T,BPS,S0L,3DS+#$T,BPX-CDL,3,W+#,R,""PV,CDL,C0V+#(P,BPQ",
                @"M.#8*-#$P+#,V-""PR-C$L-#@Y+#$X,BPQ,SDL,S4P+#<P,BPS-#`L,3,R+#$T",
                @"M,""PT.#DL,CDY+#0X,""PX,2PR.#`L.#(Q+#@W,2PY-#0L-S,S""C4U,2PT-30L",
                @"M-3DR+#0T,""PW,C<L-34R+#8Q-RPX,CDL-#$S+#<S.""PQ.#,L.3(X+#0X,""PW",
                @"M,3<L,3$V+#,T-BPU-C(L,C@S+#8V,2PU.3@*.30S+#DQ,2PQ,3DL-3@Y+#4Y",
                @"M,RPU-C@L-#8R+#4Q-""PR.#<L-#@V+#(W.""PU-S<L-C0V+#,X,BPV-3,L-SDL",
                @"M-S`U+#4V,2PX,#@L,SDT""C@P,""PX-#<L,C8Y+#@S.2PR.3DL,C4Y+#0V.""PS",
                @"M-3@L-S<L-#(X+#<Q,BPS.#(L,C<R+#$R,""PW,C$L-C(T+#$S-BPV,C4L-30V",
                @"M+#0V,@HV.""PW,3$L,C<U+#0Q-2PQ,S(L-C`U+#0P-2PQ,S<L,SDT+#4W-RPU",
                @"M-3@L-34S+#4W,BPU,#$L-S<X+#(W,BPR.3@L-#@Y+#$T-""PV.#`*,C4Y+#8P",
                @"M,2PV,BPU.3,L-C$U+#$X-RPW,SDL.#@Y+#4R+#<W+#8R,BPX-S$L-#$S+#4U",
                @"M-2PY-S4L,3(X+#DT.""PW-#`L,SDQ+#@R.0HW,S(L-C8R+#0T-BPX,CDL,C0U",
                @"M+#0U-""PU-C<L-#,Y+#0Y-BPS-S@L,3,U+#@T+#4W+#0R,BPV,C@L,S4R+#(X",
                @"M,BPX,S0L,C8S+#(V.0HT-S8L-S0Q+#$P-2PS.#8L-#<P+#@W+#4Q,BPX,CDL",
                @"M,S<X+#4W-""PU.#@L,3(V+#,W-""PU-S,L.#8U+#,X.""PY-#,L-C`S+#0V-RPR",
                @"M-S8*.3$S+#0X.""PS,S8L,S(V+#(Y,RPQ,C(L.30W+#8U.""PW-#4L-C0Y+#8R",
                @"M,RPS,C$L-S,V+#$Q,RPS.3,L,S8U+#DR,""PR.#8L,C8S+#DP,@HR.34L-3DU",
                @"M+#8T-2PY-#,L-C`W+#8P,""PT-S@L,3<S+#0R-2PT,C(L-#<X+#,T-""PT.3@L",
                @"M-#DP+#,W-RPS-S0L,S0S+#(X,2PX-C0L-38T""C,Y,2PS,3(L-C(Y+#8X+#$W",
                @"M.""PT.#8L-S$S+#4T-BPU-3$L-C4P+#8P.2PT.3@L-C@Q+#(V-BPR,S4L,38W",
                @"M+#8T,RPV-3$L,S`Q+#,R,PHV,C0L-#0V+#8P,""PV,C8L,3@P+#,T-2PU.#@L",
                @"M-C0X+#8T,BPW,C,L.3$P+#DQ-BPT-#(L,3@R+#DT-RPS-3@L-S<X+#4P-BPT",
                @"M.#<L.#(V""C$S-""PW,C,L-S<U+#(W-2PT,38L-3<V+#(S,2PS,C<L,C,X+#(X",
                @"M-2PS.38L,S<X+#@W,BPU-SDL-#`R+#(Y.2PU.3$L-3$Q+#(V-BPW,C$*-34T",
                @"M+#DQ+#<R-""PV,34L,3DS+#@V-BPT,S`L-#DU+#8U-2PV-""PX-S(L-#@U+#8R",
                @"M,""PU.38L,3$L,3,S+#0Q,""PW,C$L-#4V+#8T-@HX.""PX,C0L-#,X+#@T,2PQ",
                @"M-#0L,3(Q+#,Y-""PU,C4L.#$L-3$T+#,X,RPT.38L,C`R+#0X,BPX-BPT-CDL",
                @"M-#@Y+#0X-RPW,C8L,C`S""C8W-BPY-#,L.#8R+#4W.""PV,3`L.#@W+#0V,""PW",
                @"M,#,L-S$V+#<P-RPX.#$L-S,Q+#,S.""PS-3$L-C$L.#DU+#8T.""PX,S$L-3<P",
                @"M+#<Y.0HU-S@L-S$U+#$Y,2PQ.#DL,S<Y+#DQ,""PT,#8L.30Q+#$X,BPX,#$L",
                @"M,S8Y+#8P-RPR.3$L,S4S+#@X-BPW-#$L-#(P+#8U,RPS,S$L-#8Y""C@P.2PX",
                @"M.#,L.#DX+#4X,2PQ,C4L.#(U+#$S,""PV-3@L-#DU+#,Y,RPT,#`L,S4U+#4X",
                @"M.""PT,#4L-#4X+#8P-""PW.#$L-#(T+#0R-BPX-#$*-3DL,3,W+#(X.2PW,S8L",
                @"M-S@S+#0U.2PQ.3$L-38Q+#,Y,2PY,#@L-#$P+#4P,2PT-C<L-3@S+#,V,""PS",
                @"M-S<L,34U+#$Q,""PX,CDL,3`Y""C0R,BPQ,34L-#<T+#@X-2PU-S$L-#0W+#,R",
                @"M-""PY,C8L,SDP+#4Y,2PX,C,L-3@S+#(P-2PQ,S@L-S<X+#4Q,""PX-S8L-S(S",
                @"M+#(V.2PX,SD*-3$Q+#4W.""PQ.3<L.30W+#@W.""PS-3`L,S`R+#$S,RPX,RPU",
                @"M.3<L-C0U+#$X,BPV-2PS,S<L-SDX+#@S,BPW,C4L-S<R+#$Q-2PX-C$*-C(R",
                @"M+#@V,RPW-#@L,C`P+#@S,BPS,CDL-S(Y+#<P+#8U,2PU-C4L-3$L,C@Y+#,X",
                @"M,2PS,C(L,S(Y+#$X.""PS.3DL,S`Y+#0Q-""PU,3D*-#`U+#0Y-BPS-34L-3$Q",
                @"M+#0R.""PS,3@L-C8T+#$S-""PX-C0L,S$V+#4R,""PX,CDL-C8P+#$Q,BPU.3@L",
                @"M-38T+#8V,""PR.3`L-30Y+#,X,0HW-#(L.#@U+#(X-2PV-#DL,S,X+#0Q,RPX",
                @"M,C8L-S4X+#$W.""PX.3`L,3,S+#,T,BPT-S(L-C4S+#(P,2PY-#8L,C<Y+#8T",
                @"M+#<R-RPR,#4*,3DP+#@T,2PT,CDL-#4V+#0P,""PU-S4L-3@L-34S+#4Q,""PS",
                @"M.#0L-#$V+#4Y-BPY,38L.30Q+#0Q.""PQ,34L,C,U+#$W-2PR-#8L-C$W""C,S",
                @"M,2PS,#`L,C`V+#,Y,RPT-#(L,S4R+#4W.2PU,3`L,S@S+#4Q.2PT-3`L-""PS",
                @"M-S8L-S`T+#8U+#4U-2PT-#(L-S,P+#@P,BPV,C8*-S(S+#8U,BPT,3@L.#DV",
                @"M+#$Y,RPU,#@L.#(L,SDR+#$X-2PT-#@L-#DT+#8P.""PQ,C`L,3<R+#,P,""PX",
                @"M-C,L.#@W+#$Y.2PR-C8L-#<W""C,S-""PY,C(L-C4U+#0W-RPQ-S4L-S(P+#$S",
                @"M,BPT-30L-3DX+#8T-RPR,#4L-S<W+#,T-BPS,C`L-C0V+#,X.""PU-CDL-3DV",
                @"M+#<T-2PV-#(*-S<Y+#4W-BPT.3,L-C$S+#4Q-RPS-C$L,S<U+#<X,RPY.#0L",
                @"M-#(Q+#$W-BPR,S$L-C(W+#,V-""PX,C,L-#8X+#,X,2PY,#$L-#4P+#4X-0HX",
                @"M-2PV-3@L-S0U+#(P.2PQ-#(L-S,T+#0Q-2PR.#$L-S,Q+#0P-2PQ.#DL-S(P",
                @"M+#@W-RPU-3DL-3<Y+#$X.""PT.3(L.30Q+#,U-BPX.`HW,S,L-#`P+#,X-RPU",
                @"M.#,L,S,Q+#$Y,BPX,3,L-3DS+#8U.2PT-S$L,3<Q+#4T-2PS,3<L-C0Y+#@S",
                @"M-""PS.3DL-C$Q+#@W-BPV-#,L,3(V""C<Q-RPV,S0L,C@Y+#$S-""PR.#,L,3<T",
                @"M+#@R,RPT-#4L-C$R+#(P,2PU,C`L,C8V+#$S,""PS-C$L,3(Y+#(V-RPS,S<L",
                @"M-#(T+#8V,2PU-S`*,S@P+#@T,2PT-S(L.3`U+#@X,2PX-2PR.34L.#(U+#,Q",
                @"M-RPS-3$L,3(R+#(Y,2PS-34L,3DU+#<W-BPQ-#,L,S8P+#,R,2PW-#DL,3<U",
                @"M""CDT-RPT,S`L.#@X+#$T-BPT-SDL,3@V+#4Q-2PW-#<L-C(R+#,W-""PX-S,L",
                @"M-C4X+#8Q,2PY.3`L-S@L,S0V+#$R.""PR-CDL.30W+#,U,@HX.3@L.#<V+#8R",
                @"M.""PY,38L,30R+#(U,""PS-3<L.3`X+#,R-RPW-#4L,38W+#@Y-RPQ,3DL,3@R",
                @"M+#<X,""PX-S(L,S(Q+#,Y,RPV,#@L.#8W""C0P-BPW-S<L-C4V+#<W+#,V-RPR",
                @"M.#@L-3<U+#4R-2PT-C,L,S,X+#,S,RPW,CDL,3DV+#4V.""PY,BPU.#$L,S4X",
                @"M+#,V,BPT-3DL.#@X""C4V,RPV-BPT,3(L-3<Q+#0T,BPV,BPR.3,L,CDV+#,T",
                @"M-""PW,RPQ-#<L-38L,S$V+#4V.2PT.#@L-S,S+#@T+#4Y+#$T-2PQ,3(*-S0Q",
                @"M+#@P,BPU,30L-30V+#@Q+#<S,""PT,S0L.#8X+#@R-RPT-C,L,S0Q+#<P-BPQ",
                @"M.#0L-C(R+#(P,RPX-C,L,3$W+#4R,BPQ-#,L,S4V""C<S,BPW,CDL,3(Y+#<R",
                @"M.""PW-S4L-C$Y+#,W,2PV-3,L,C<Y+#4V.""PR-3(L-#`X+#4V-RPQ.3(L.#,W",
                @"M+#@W,BPV-#4L.3`X+#4V-2PR.#0*-38S+#0Y,BPQ-S8L-C8P+#@W,BPU-C(L",
                @"M-C<U+#8R,RPW,30L,3DV+#<R-RPS.3,L-#@T+#0P-2PR-CDL,SDS+#<R,2PY",
                @"M,#0L,C<Y+#8P,@HS-C8L.#`R+#0X-RPY-#DL-38R+#@R-2PV.2PR,#(L.#<W",
                @"M+#0T,BPR.#@L.#8V+#4Y,RPT-#,L,3$T+#@V.""PS-#,L,3,Q+#4Q-RPS-SD*",
                @"M,S(Y+#8U.2PW-#0L-3DL-3DY+#0T-2PU-S8L-#$P+#8L.3`W+#(X.""PU,C0L",
                @"M.#,Y+#DQ+#4U+#$X-2PU,C,L,3<Y+#(X-RPW,#,*.#(L,3`T+#$S-2PR.3(L",
                @"M-#(U+#8V,BPX.#$L-C4Y+#0U.""PU.#`L-#4S+#$Y.2PW,C(L-S0W+#,Y-""PV",
                @"M.#`L-34R+#(X,2PX.#`L-3DU""C,W-""PV-C<L-#(T+#0V,2PR-CDL-#<S+#,U",
                @"M-2PQ,CDL.#8W+#,U-""PV,RPV,CDL-#8Y+#,S,BPX,CDL-C`R+#DP,""PX-CDL",
                @"M-S`V+#0X,`HW-#,L,S<U+#,W,""PX.#$L-#0R+#(W-""PX.#8L-#`X+#0Q.""PT",
                @"M-#0L.#<X+#8T-BPR-C@L-#@R+#$S,RPQ,S0L-C8Q+#4V,2PS.3<L,SDV""C@V",
                @"M-""PV-38L.#(L-3,Q+#8R-2PT-#@L,3@Q+#<Q-""PT.#$L-#DT+#@Y.2PY,3,L",
                @"M-#<U+#(W-2PT.#DL-S0R+#,U.2PT-S0L,S@U+#0W-`HU-SDL-C`T+#4Y,2PS",
                @"M-#,L,C8V+#4W-BPR,""PQ,#<L,S4W+#DP-2PX,S,L,3$U+#,Y-RPS-S@L-S@Q",
                @"M+#@R.2PT-C0L.30S+#4V,BPS-#4*-S`T+#$Q-2PY,#(L,S,Q+#DX.""PR-CDL",
                @"M.3$L-C(X+#0U.2PT-S0L-38S+#DP,BPX.3,L-C(P+#8Q,""PX-CDL-#(R+#<Q",
                @"M,2PT,3@L,S4U""C0R.""PR,#@L.#<W+#8Q,RPW-#0L-S,Y+#DQ+#$Y-RPQ-S<L",
                @"M,3`X+#@W-""PX-S(L-#DS+#4T+#0P-RPS,S@L-3(Q+#@X-RPR.#0L,C@X""C(U",
                @"M.2PS,S0L-C4R+#(V,2PU,#(L-#`U+#0Q,2PU-C,L.#@L.#DQ+#0R,2PV-RPW",
                @"M,SDL-C(S+#@S,BPS.#@L.3@W+#8P-RPS,SDL,3(Q""C<X,2PT-38L,S<V+#,X",
                @"M-""PV,C4L,3`Y+#8S-BPW-#0L-#0V+#<V+#,V,2PQ,C0L,S(T+#$Y-BPU.#DL",
                @"M-S,V+#$Y-RPW,#,L-C0W+#0X,`HT-SDL-3<R+#,X-RPX-CDL-3<Y+#DP+#,S",
                @"M-BPU.#0L-C`R+#0Q.2PV,#`L-3<R+#$X,""PS.30L,C,T+#,Q,RPQ,C<L,C@Y",
                @"M+#$Q,BPW,38*,S4Y+#(S-""PR-C0L-S(P+#<S-2PT-#8L-S0R+#$Q,2PW-""PW",
                @"M,C@L.3`U+#,T,""PX,RPW,RPW,C4L-#$R+#0P,2PV,#8L.#8U+#0S-@HQ-#$L",
                @"M-3@P+#,V-2PQ.30L-C4T+#<S.2PW,S8L-C4L.#<P+#,P,2PY-#0L,3,V+#<Q",
                @"M-2PT.#0L-C`Y+#,T,BPU-SDL.#$P+#$S.2PS.3`*.#(L,C@U+#,V-""PT,C$L",
                @"M,SDS+#@S,2PS,34L-#$Q+#8Q,2PY,3,L-#8P+#$R-BPS.#@L-#<Y+#0Q,RPX",
                @"M.#8L.#(L.#@X+#@Y-2PW,S`*-3<L.#,P+#@S-2PT-S(L-#4W+#0Q,2PT,S`L",
                @"M.#(V+#0Q.2PS.#,L,S8R+#@U-BPV,2PW,S<L.#,Q+#@S,2PQ,3(L,C`V+#(S",
                @"M,BPQ-SD*,C8U+#@X,BPY,""PV-S<L-C$W+#4T.""PX.2PW-BPQ,S,L-3<Q+#<P",
                @"M-""PT-S(L-30L,3`W+#4U-""PT.3<L,S(S+#<Q,RPT-3(L,3@W""C8V,BPQ,C0L",
                @"M-#4R+#<R-RPU-3,L-3@X+#(P+#<R,RPV-34L.#@T+#0R.2PW,3,L.#8R+#@T",
                @"M,RPU-3(L-C(V+#0Q-RPX-S`L,SDU+#4T.0HS,CDL,3(V+#@P-RPX-S8L-S,X",
                @"M+#0T,2PR,S$L,CDR+#4X,""PS.#@L.#DR+#<R.2PQ-#$L,S(R+#0Q-BPS-C4L",
                @"M-3<S+#,W.2PV,3DL-#`W""C@W-2PT-C$L,3<P+#4U.2PU-#@L.#<T+#$W-2PU",
                @"M,38L,30V+#,S-RPV-C$L-3$Q+#@S+#8R,2PQ.#DL-#DW+#,Y.""PV-30L.30W",
                @"M+#@P.0HQ.#8L.3`R+#$X,RPS-S8L.#`P+#0Y,""PY,3$L-#(T+#8T+#0X-BPS",
                @"M-38L,SDP+#8R,RPV-SDL-#4P+#DP-RPX,CDL-S,X+#(X,""PS-C$*.#,Y+#$X",
                @"M-2PS.30L,3DV+#4W-2PX,S$L-S$V+#@R-""PQ-#8L-3$L,S@S+#4V,2PR.#,L",
                @"M.3$V+#<W.""PY,3,L.#,V+#,Q-BPS-C8L-#`P""C0R,BPV-3,L-34Q+#8P.""PV",
                @"M,CDL.#DS+#4T-RPT-C`L.#DT+#0X,""PW,#4L,S8W+#$Y,""PV,#DL-C@L,S(T",
                @"M+#DT-RPQ-S(L.#(L-3D*-C4V+#$V.2PX-C0L-38U+#@P+#0Y-BPS-3@L-#DS",
                @"M+#@T,2PT.#,L.3`T+#0S.2PQ.3DL-#0X+#8T-2PY-#(L,C0X+#4R,RPR,S$L",
                @"M,C@R""C0U,""PX.#`L.3$L,3<V+#4Q+#@Y,RPW-S`L.#,R+#8X+#$Q-2PX-C8L",
                @"M,C@R+#8V,BPW.#0L-34L.#<U+#,W-BPU,C(L-#$V+#<S,@HV,C,L-S`U+#(X",
                @"M-""PV,#(L,3<X+#@X,2PT-C<L.#,R+#,Q.""PU-#@L,SDQ+#0P-RPT.#8L,S8S",
                @"M+#4Y.""PV,3,L,3`S+#4U,BPU,C$L.#`S""C@Q+#0S,2PT-C(L,C`Q+#8T.2PQ",
                @"M.#DL.3$Q+#8R,2PU.#(L,3@S+#4R,RPR.3`L-3<V+#<T.2PS.3DL-S,U+#DQ",
                @"M-""PX,C,L-C(Q+#<R-0HX,C@L,S0W+#0V,""PV-S(L,C@Y+#8P,RPW,3DL,S(U",
                @"M+#<R.""PX-S,L-3$W+#@X.2PU-S4L-C$R+#$U.2PW,C8L-#`U+#<Y.2PW-#@L",
                @"M-SD*,C4W+#$R-2PS.#$L-3DS+#@Y,2PT,38L-#0T+#$R-BPX.3@L,3DY+#@W",
                @"M-RPW-S4L-C<L.#8R+#$W-""PU-S0L,S`S+#,R-RPT-CDL.3$Q""C8X,BPT,3`L",
                @"M-S`U+#8R,RPX,#,L,3$Q+#@V,BPT-#<L-#$W+#(W,2PW,""PV-S@L-#<U+#4T",
                @"M.""PS.#,L.#8Q+#DP-RPT-#<L-38Q+#8U.`HQ.2PU-38L-#`X+#4X.2PW,3,L",
                @"M,C8Q+#$R-BPS,S4L-S0L.#DT+#4Y-2PV,3$L,38Y+#0Q.2PR.#`L-3DR+#@W",
                @"M,BPU.#8L-38Q+#,R.0HU.3DL,C8T+#8T-RPS-3`L.#4L-S@P+#4U,""PS-C`L",
                @"M,3DW+#4U,BPT.30L.#<T+#,U,2PX,38L,S`R+#,R,""PT-C@L-S0T+#(X,BPW",
                @"M,CD*,3DU+#4V-""PQ-S,L-C`T+#0U,2PW,2PX-RPW-#8L.#DL,34Q+#0T-BPQ",
                @"M-#0L,3(V+#,Y,2PX-C,L,S4R+#,V,2PQ,C$L-#@S+#,S-0HW,C4L-3<T+#0T",
                @"M.""PT,SDL-#(V+#(V.""PQ,C@L,C0S+#@W.2PX,C,L-C4Q+#@W-RPT.#$L-34Q",
                @"M+#(V-RPV,#$L.30Y+#@P,2PS-3@L-#4V""CDP-""PQ,C$L-3(U+#<Q,""PR.#(L",
                @"M,3DQ+#4P.""PS,S$L-3@V+#0U,2PV-2PS.#<L-S$X+#@R-""PQ,#<L,3,R+#0Y",
                @"M,2PR-S0L-3`P+#,W,PHW,S0L-#4Y+#@S-RPT,3<L.#(V+#8V,""PU,C(L,3`X",
                @"M+#$W-2PW-#@L-S,S+#DT-RPT-#8L.#(V+#@V-RPQ-C8L.#,P+#(V-BPU.#8L",
                @"M-C$S""C<X-""PY.#DL-S`X+#4W-""PW,S,L-C(Y+#8P,BPQ,3<L.#8S+#4Q.""PS",
                @"M.#@L-3(T+#,V,2PU-C`L,C`U+#8P-RPR-3<L-3@R+#<Q,RPX,0HU-#4L-38U",
                @"M+#4Y+#,P,BPV,C$L-C$V+#<R,BPY-#4L-3@T+#4Q-BPR-C<L.#@R+#DX-RPV",
                @"M,#$L,C@S+#8U-BPV,#0L-38S+#$Q,RPW-S<*.#DY+#,T.2PW-#(L.#`P+#(Y",
                @"M.2PT-#DL,S@Q+#0Y,""PU.#,L,S0S+#4W,2PQ.34L,S(T+#(T-2PQ-S@L,S0Q",
                @"M+#$X.2PW,S`L-S(R+#4W.`HQ.#(L,C4W+#@V,BPV-3DL-S(Y+#@W+#4Q,2PT",
                @"M,#DL,3,P+#@S-BPX,3$L,SDX+#8T.""PR-3DL,SDW+#@W-RPT-34L-S$W+#0X",
                @"M-RPT-C(*,38X+#,X,RPQ-SDL-#(Y+#4X-RPT,#8L-34U+#,Y,BPQ-S<L-3(R",
                @"M+#,T,2PT,S8L,S,Q+#0W-RPQ-#(L.#8Y+#$Y-""PS-#<L,30W+#8T,@HV,3,L",
                @"M,3<T+#8P.2PS,C<L,C@T+#DT.2PV,#0L-C0W+#0U-RPT.#0L-S0R+#@W,""PQ",
                @"M,S<L-""PV,38L-#0P+#4Y,""PQ,CDL.3`Y+#4U,`HT.3DL-34V+#(Q+#(Y,BPS",
                @"M,S0L-38Y+#,W.2PW,C,L-#$T+#<T-BPR.#<L.3$V+#0R,""PU-S,L,S@R+#8X",
                @"M,BPX-S$L,C@P+#<R-RPT.30*,S4X+#@W.""PW,3<L,3@U+#,Q.""PV,""PU-""PV",
                @"M,2PR-C0L-C4X+#4Y+#<Q-RPQ.3(L,C$P+#8Q-2PV,C<L-CDL-#4S+#0U,2PX",
                @"M,S<*,3`Y+#4P+#<W-2PU-#@L.3`Q+#8P-""PQ,CDL-34V+#0Y,RPQ.#DL-S,T",
                @"M+#8S.""PU-3(L.#4L.#<X+#DQ-BPX-S@L.#@Q+#(X,BPX-C,*,S<U+#0V.2PW",
                @"M-#,L.#8U+#0X,2PS.#,L.#DS+#8W-2PS,CDL-3<Q+#4P,BPU-S8L,S8U+#0U",
                @"M,2PV,38L-C0X+#,S,""PQ-S<L.3$R+#DP.`HW-3,L-#8T+#@V-RPT-#4L-#0T",
                @"M+#0V.""PV,38L-C$X+#@Y-""PY,38L-38S+#,U-2PV,#(L.3$P+#@S,BPT.3,L",
                @"M,3DQ+#,V,RPX-C4L-#0R""C$Q,BPS-C,L.3$S+#$T,2PW,2PW-#`L-#0R+#,R",
                @"M-RPR-S0L-C$W+#,W-RPV,S4L,S4S+#,P,2PV,#4L,3`W+#4Y-BPY,S(L-S<U",
                @"M+#$T-@HU.3$L,3DQ+#,R,BPT.#0L-C$V+#,S.""PS.#`L.#$R+#$R-RPQ,S<L",
                @"M,C4W+#8U-RPX.#0L,S`Q+#8P,""PT,C,L,3$R+#4X,2PT,34L.#<W""C4P,2PV",
                @"M,SDL,S(T+#8T.""PS-#0L-#DY+#,W-RPU.""PY,#$L-3<W+#,U.2PT.3,L,3@W",
                @"M+#$Q,BPV.2PT-S<L,30V+#<R,""PR.3(L-C`Y""C@S-2PU,3,L,SDX+#$W,2PV",
                @"M,C(L-C4Y+#,U.2PS,C4L-C4T+#0Q.2PT,S(L.#8Y+#8Q+#0P-2PS.3@L-#<X",
                @"M+#8U-""PV-3DL.30S+#8P,`HX,BPV.#$L-3<U+#4Y-""PQ,38L-#@T+#@Y,""PS",
                @"M.#,L-S8L-C4U+#<P-2PT-#8L-#4T+#(V,2PU-C(L,SDV+#<R.2PW-#$L,S0S",
                @"M+#DQ.0HX.#0L.#@Y+#(V.""PX,S,L,S8P+#@W,""PW,C(L-3<Y+#4R+#,X.2PT",
                @"M,#(L-3@R+#0Q-""PS-S`L-S@S+#8R,RPS-SDL-C,U+#<R,2PX.#D*-#DQ+#0V",
                @"M-BPU-S<L-#<U+#@T,2PT,C@L.#`P+#@T,RPS-C4L,3$V+#,P-RPY,""PV,#4L",
                @"M-S(P+#@W-RPV-3@L-C@R+#@V-BPX.#(L,C,T""C,T.2PX-S<L-S4T+#,T-BPT",
                @"M,#DL.3,L,3<V+#<S-BPS.#<L,S<W+#$V.""PW.#(L,C`U+#0P.2PT-C`L.#8W",
                @"M+#@Y-BPT,S`L.#(V+#<T.0HV-#<L,C@Q+#4W-""PW,3@L.#8L.3(X+#,T,""PX",
                @"M-#,L-S`X+#4U+#,V-2PT-S`L-S`T+#4U+#<R-2PS-#,L,S<X+#@R,BPU,C`L",
                @"M,S0W""C<X,""PX,C8L-#<P+#@W,RPU-3<L-S`Y+#$Q,""PU-3<L-#<V+#$Y,2PX",
                @"M,RPQ,CDL,C@Q+#(Y-RPY,3$L-3<P+#$R.""PV-#4L.#(S+#,W-@HS,SDL.3$V",
                @"M+#0W-RPV.""PR-S@L,C,S+#DT-2PT.3(L-C(P+#<T+#DS,RPW,S8L-C$W+#$X",
                @"M,BPX.#$L,S,W+#@S-BPS.3,L,C`T+#DP,0HV-C`L.#DQ+#4V,RPT,#,L,34R",
                @"M+#@X.""PQ-S`L-C$U+#,S,RPS-C(L-3DQ+#8W,BPX-C$L-CDL,S(T+#4Y.2PW",
                @"M,30L-#$P+#$W,RPX.#(*,S4T+#@V-""PS-3DL-C0R+#8Q,RPV-#,L-#0W+#<P",
                @"M.2PW,S$L,3<P+#4P,BPY,#DL-3DR+#@P,""PU,BPQ-#0L.3$T+#4U-""PX+#DT",
                @"M-`HU.2PT-#4L,SDR+#4P.2PV,C0L,S<T+#4X-BPV,2PR-S0L,SDV+#4U-BPQ",
                @"M,3<L,3(X+#8P,2PV,#$L,3(S+#8U,RPR-C0L,C<P+#8Q,0HT-C@L-#<P+#,U",
                @"M,""PU,C`L-#@S+#<S.2PW,S4L-S0S+#4U,""PU-S@L.3$Q+#DX-""PS-3$L.#DV",
                @"M+#4R,RPU.""PS,S4L-S`X+#DQ+#0V,`HR-S$L,S<R+#$X-2PU.3,L-C4P+#,S",
                @"M,2PR.3$L-3DX+#8V,RPT,30L-3DQ+#4P.""PS-3DL-S<Y+#,R-2PQ-#,L-3(P",
                @"M+#DT,BPT-S`L-S0P""C4X,BPQ,S@L,3DT+#,W,RPW,S0L,3DR+#$S.2PQ.#@L",
                @"M,SDR+#4R,""PT-S<L,38W+#8T.""PT,S,L,3<T+#@W.""PW-""PY,3,L-3$U+#@T",
                @"M,`HV,C<L,3@V+#,R-2PR,S,L,S<R+#$U,BPY,3$L-#(U+#<X,2PS.34L.#0Q",
                @"M+#4V,2PU-30L-#$S+#<S.2PT,3@L-#4T+#,Y.""PS,38L,CDQ""C<Q,BPW,C@L",
                @"M-S$R+#4S+#<T-BPX.3<L-3$S+#0U,RPQ-#(L.#8U+#(L,38W+#<Q-RPQ,S,L",
                @"M-C4V+#4V,""PS-30L-C4P+#(P,RPV-C$*.3`U+#8P-BPV,""PQ.#,L-C4S+#@W",
                @"M-""PS,C4L.30T+#0Y-""PU-S8L-S(X+#4V-2PS,S$L.3`W+#$Q,2PW,#@L,C<T",
                @"M+#0Q,""PQ,C(L,3`R""C,P,2PQ,C0L-S$Q+#<T.2PS.30L-S`Y+#<Y.2PV-38L",
                @"M-3`L,38W+#4W-""PW-BPQ,3,L.#<L-S,U+#8R-RPT,#@L-3DR+#$U+#0Y-0HS",
                @"M.#<L-S$R+#,U-BPW.#,L-#DX+#DX,BPS-C,L-C0T+#,S-2PW.#$L,SDU+#4Q",
                @"M-""PQ.#,L-#4X+#@X-""PX.30L,3DT+#0Y,RPX-#(L-S0*,C`T+#8P,""PT,C@L",
                @"M-#4X+#,U,2PU,3(L,3$S+#$Q.2PR-3@L-C4S+#0W,BPR,C8L-#(R+#8P.""PT",
                @"M,S`L.#<L-3DU+#0U-BPX-SDL,S4V""C(X,2PR,#8L.#DU+#0P.""PU,""PV,3`L",
                @"M.3@L.#@R+#0T,RPX.3@L-C`X+#<S-RPX-#(L-#`U+#4X,""PT.#$L,C<Y+#<T",
                @"M-BPQ-S@L-S,Q""C4T-BPQ,""PR-C(L,C<P+#,S,RPY,3`L-#8V+#,S-RPU-C<L",
                @"M,C4X+#<R.2PQ-S@L-S0S+#,W.2PX-BPU,C4L-#8P+#DR+#8U,BPW.3D*.3`Q",
                @"M+#0X-RPS,S8L.#(Q+#<W+#,S,""PX.#DL-C`Q+#,P,BPT,C$L,3(Q+#(X.2PX",
                @"M-SDL-C@P+#<Q.2PT.38L.#,L-#`Y+#8Q,RPT.#`*.#DL,3(T+#8Q-BPV-C@L",
                @"M-C$S+#0Q-""PW,#@L.#0R+#,R,RPT-3@L-C`R+#@R-BPT-S(L,S<S+#4Y.2PR",
                @"M-S@L,C8X+#$R,""PV,34L.#8T""C<R-""PU,#8L,S4P+#,W,2PX-S`L-#$W+#4X",
                @"M.""PT-S,L,S0R+#@Y-BPU.2PU-S8L-3$U+#8X,""PY-#4L-3<S+#,Y-RPW,38L",
                @"M,3@R+#0Y-`HV,2PX.#@L,C<W+#(U.2PX.""PU,C,L-3<L-C4R+#$W,""PQ-S4L",
                @"M-C`W+#<U-RPY,2PR-S8L-S,R+#0R-RPS-C$L-3DS+#<X,2PQ-CD*-#4R+#4Q",
                @"M-RPW,SDL,3@P+#8T-BPT-S$L,C8Y+#(Y,""PV,3`L,S,U+#4W.2PY.#0L-#0S",
                @"M+#0R.2PW,#0L-3DW+#0W-2PU,C4L-3@Q+#(Y,PHS-C,L-C<R+#0U-BPX.#<L",
                @"M.#DX+#4X-BPU-S(L,30R+#@V,2PV,#0L-#4W+#DT+#$S,2PW-RPQ-S4L,S0S",
                @"M+#@X-""PT-C0L,C<T+#,Y-@HU.#$L-C,L,C,R+#$S,""PU.#DL.#`L-S<U+#0Y",
                @"M.2PY,3`L-C`S+#8Q.""PU-S$L.#@P+#(X,""PT-34L-#DQ+#,W,""PQ,3@L,C@S",
                @"&+#8Q,0H*",
                @"`"
            };
    }
}
