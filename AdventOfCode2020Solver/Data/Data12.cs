using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data12 : AbstractData, IData
    {
        public Data12() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                @"M1C0P""DXQ""E<Q""D8Y-0I7,@I.-0I2.3`*3C,*13,*1C(Q""D4S""D8T-`I7,PI2",
                @"M.3`*3C(*3#$X,`I%-0I&.3D*5S$*1C$Q""E(Y,`I.-`I&-#4*4S4*3#$X,`I7",
                @"M,0I2,3@P""D4U""E(Y,`I&-0I3-`I%,PI3-`I,,3@P""E<U""D8R-@I&,0I3,PI,",
                @"M,3@P""D8W.0I2.3`*4S4*4CDP""D4U""DPQ.#`*5S0*1C$R""DXU""D4T""D8S,0I3",
                @"M-0I7,@I&.3,*5S(*1C@*4S(*134*1C$P,`I,.3`*1C$P""E(Y,`I.,0I&,34*",
                @"M4S,*130*3#DP""DPQ.#`*4S,*134*4CDP""D8Q,PI.-`I&,34*3#DP""E<T""DXT",
                @"M""E<Q""E,U""D8T-`I7-`I&-C@*3C(*5S0*1C4X""DPY,`I%-0I&.#$*4S4*3#DP",
                @"M""E,Q""D8Y-0I2.3`*13,*4C$X,`I&.#$*4CDP""E,S""D4S""DPQ.#`*5S0*5S,*",
                @"M3C$*5S4*4C(W,`I7,PI.-`I7,PI.-`I&-#<*13,*4CDP""D8X-@I3-`I.,0I2",
                @"M,3@P""D4R""DXQ""E,U""E(Y,`I.-`I,.3`*13,*4C$X,`I.,0I7,0I.,PI%-0I.",
                @"M,@I&.0I.-`I2.3`*1C,V""D4R""E,Q""E(Y,`I.,@I&-S8*1C@X""D4U""D8W.`I7",
                @"M-`I&-3,*3C$*5S$*4CDP""E(Q.#`*3C0*5S4*4S$*3C(*13,*1C@S""DPY,`I%",
                @"M,PI,.3`*5S(*3#DP""DXQ""E<R""D8R,0I2.3`*1C4X""E,S""D8Q,#`*4S4*1C<X",
                @"M""E,U""E(Y,`I%-0I2.3`*5S4*5S$*3#DP""D8R,PI,.3`*1C4V""E<S""D8X""E<R",
                @"M""DXU""D8S.0I3-0I&.#0*3C0*4CDP""DXT""D8Q.`I3-`I&-3`*4S$*13,*4S4*",
                @"M3#DP""DXR""E<R""DXQ""D8X-@I2.3`*4S$*4CDP""DPY,`I7,@I&,3`P""D4T""DPQ",
                @"M.#`*1C$P,`I%,0I3-0I7,@I,.3`*3C0*130*4CDP""D8Y-`I7-0I3-0I,,3@P",
                @"M""E<U""E,U""DPY,`I3,PI2,3@P""D4R""D8R,@I2.3`*130*1C8U""DXQ""D4U""D8X",
                @"M,@I7,PI&,3`P""D4Q""D8X-PI,.3`*4S0*5S$*1C$P""E<S""E,R""D8Y""D4R""D8T",
                @"M.0I&,S4*13$*4CDP""D8V""E<T""D8V,`I2.3`*4S$*1C0U""E<T""D8T-`I%,PI,",
                @"M.3`*5S(*3C,*3#DP""DXR""E<Q""DXR""E<R""E,T""D4T""E<U""E(Y,`I%-`I,.3`*",
                @"M1C$V""E<U""E,S""DXU""DPY,`I&.#,*5S0*3#DP""D4R""D8R-0I7,PI2,C<P""E<S",
                @"M""DPY,`I.-0I&,S8*4S0*4CDP""D8Q-0I2.3`*4S(*3#DP""D4U""D8R-0I3,PI&",
                @"M,@I.-`I7,0I.,@I&-@I3,PI2.3`*3#DP""E<R""DXR""D4U""E,S""DPY,`I&,S$*",
                @"M5S0*3#DP""DXT""D8S,`I3,PI2.3`*4S,*3#$X,`I7-`I.-`I&-S(*5S,*4S$*",
                @"M4CDP""D8V,`I%-`I2,3@P""E<T""E,Q""E<T""E(Y,`I&,3`*13,*1C4X""D4U""DXR",
                @"M""E<U""DPQ.#`*3C$*13$*4CDP""E<U""DXQ""D4S""DPY,`I.,@I2.3`*13(*4C$X",
                @"M,`I3,0I2.3`*1CDQ""DPY,`I7-`I.,PI,,C<P""D8U,@I7,@I2.3`*1CDR""DXT",
                @"M""D4U""D8T-@I.,@I&,S8*5S,*3#DP""DXU""D8V,`I.,0I3,PI&.30*3#$X,`I3",
                @"M,0I2,C<P""E(Q.#`*1C(V""E,Q""D8R,PI%-0I2.3`*1C(W""E,S""DPY,`I&.`I%",
                @"M-0I&-0I3,0I2.3`*1CDY""E<S""D8T-PI7,PI3,PI7,0I,,3@P""E<S""E(Q.#`*",
                @"M1C0Q""DPQ.#`*13(*3#$X,`I.-0I2.3`*1C$W""E,R""D4R""D8R""E(Y,`I.,@I&",
                @"M-3,*4S0*3#DP""D8X-PI2,3@P""D4Q""E,T""D8T,PI2.3`*1C0U""E<T""D8W""E<U",
                @"M""DPY,`I7-`I,.3`*13,*3#DP""D4S""E(Y,`I&,30*3C$*1C(S""D4T""DXQ""DXQ",
                @"M""E(Y,`I&.3@*3#$X,`I%-0I&.3(*4C$X,`I%-`I3,@I2,C<P""E<S""DPQ.#`*",
                @"M13$*4S4*3C,*134*4CDP""D4S""DPY,`I&,C$*1C@T""DPY,`I3-0I2.3`*1C8X",
                @"M""DPQ.#`*13,*3#DP""E<T""D8Q.`I3-`I7-0I,.3`*4C$X,`I7,0I,,3@P""D8X",
                @"M.`I%,PI.,PI7,PI3,PI,.3`*1C8Y""E(Q.#`*5S0*1CDX""E,S""DPY,`I%,@I.",
                @"M,@I&,C8*13(*13$*3C(*5S4*4CDP""E<Q""D8Q,PI7-`I2,3@P""DXR""D8R-0I7",
                @"M-`I&.#D*5S0*1C<V""E,U""D8W,PI%,0I.,PI,.3`*130*1CDW""DPQ.#`*3C(*",
                @"M4C$X,`I%,0I&.#@*13,*3C4*5S(*1C8R""E,S""D4U""E(Q.#`*3C$*3C,*3C0*",
                @"M1C,*5S(*4C$X,`I&,C@*3#DP""E,T""D4Q""DPY,`I%-`I&-C,*4CDP""DXR""E(Y",
                @"M,`I&,C(*3C,*3#DP""E<T""E,Q""D8V-PI7-0I.-`I&-#0*4S0*1C8T""DPQ.#`*",
                @"M5S,*3C(*5S$*1C8S""DXS""E(Y,`I3-0I2.3`*1C(P""DPQ.#`*3#(W,`I3,0I,",
                @"M.3`*1C8V""E<U""E(Y,`I.,0I,,3@P""E<T""D8Y-`I3,PI2,3@P""D8Q.`I,.3`*",
                @"M1C(Y""E,S""DPY,`I3-`I&-S0*3#DP""D8X-0I&,S4*4CDP""E,T""D8V.`I2.3`*",
                @"M1C0T""E,R""E<T""E,R""D8R-PI2.3`*134*1C,P""D4Q""DPY,`I7-`I&,SD*3C,*",
                @"M3#DP""D4Q""E,T""D8X-PI7,@I,.3`*3C,*5S$*1C4Q""E<Q""DPQ.#`*1C(T""DXR",
                @"M""D4Q""DXR""D8T""E(Y,`I%,PI3,0I&-CD*4CDP""D4T""D8S,0I,.3`*4S,*13,*",
                @"M134*3#DP""D8W-0I%-`I,.3`*1C$T""DPY,`I.,0I2.3`*1C,V""E,T""D8T.0I,",
                @"M.3`*3C4*5S,*4CDP""D8S-0I,,3@P""E(Q.#`*1C(V""E<S""D8Q-@I2.3`*1CDP",
                @"M""D4S""DXS""D8X-PI.-0I,,3@P""D8T""E(Y,`I.,0I%-`I.-0I&.3,*5S$*3C0*",
                @"M3#DP""D8S-0I,.3`*5S$*13,*3C4*5S4*1C4*4S$*5S$*3C$*1C8Q""E,Q""E<R",
                @"M""DXQ""E(Y,`I&,C8*4CDP""DPY,`I7-`I&,3(*4CDP""E<Q""E(Y,`I&,3@*13$*",
                @"M1C$T""DXS""E<S""E,R""D8R-0I%-0I&.#D*5S4*3#DP""E,T""D8S.`I,,3@P""D8Y",
                @"M.`I7,PI3,0I&-S<*4C(W,`I%,@I&.34*5S$*1C4V""DXT""E(Q.#`*13,*3#(W",
                @"M,`I%,0I&-@I3,PI,,3@P""D4U""E(Q.#`*13$*3C(*3#$X,`I%-`I3,PI%,@I,",
                @"M,3@P""D8W,@I.-`I2.3`*3#DP""E<T""D8X,@I3,PI2,C<P""D8S,@I&,SD*3#DP",
                @"M""DXU""E<Q""DPY,`I.,PI&.34*3#$X,`I3-0I,.3`*1C0V""D4Q""DPY,`I7,@I3",
                @"M-0I,.3`*4S4*1C<W""DPY,`I.-`I%,PI.,0I&,SD*4CDP""E(Y,`I&-#`*3#DP",
                @"M""DXT""E<Q""D8W""D4T""E,U""D4U""DXQ""D8Y-@I%-`I&,3`*1C@*4S4*134*1C(V",
                @"M""E,T""E(Y,`I3,@I&-C$*5S0*4S0*4CDP""D4R""D8S.0I3-0I2.3`*4S0*1C@S",
                @"7""E,U""D8Q.`I3,PI%-0I2,3@P""D8W""@H`",
                @"`"
            };
    }
}
