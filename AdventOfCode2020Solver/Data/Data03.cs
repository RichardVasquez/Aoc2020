using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Data
{
    public class Data03 : AbstractData, IData
    {
        public Data03() : base(MyData) { }

        private static readonly List<string> MyData =
            new List<string>
            {
                @"M+BXC+BXN+BXN(R,C+BXN+B,N+BXC(RXN(RXC+BXN+@T*+B,N(RXN+BXN(RXC",
                @"M(RXN+BXN(R,C+BXN(R,N+BXC(PT*+BXC+B,N+B,N+BXN+BXN+BXN+B,N(RXN",
                @"M(RXN+BXN+@T*+BXC+BXN+BXN(RXN+BXN+BXN+BXC(R,N+BXN+BXN+@T*+BXN",
                @"M(RXN(R,C+BXC(RXC+BXC+BXN+BXN+B,C+BXC(PT*+BXN+BXN(RXC+B,C+BXN",
                @"M(RXN+B,N+BXN(R,C+BXN+@T*+BXN+BXN+BXN+B,C+BXN+BXC(RXN(R,N+BXN",
                @"M+BXC+@T*+BXN+BXN(RXN+BXN+BXN+BXN(RXN+BXN+BXN+BXN+@T*(RXN+BXC",
                @"M+BXN+BXN+BXN+B,N+BXN+BXN+BXN+BXN+@T*+B,N+BXN+BXN+B,C+BXN+BXN",
                @"M+BXN+BXN+B,C(RXC(PT*+BXN+B,N+BXN+BXN+BXC+BXN+BXN+B,N(RXN+BXC",
                @"M(PT*(RXC+BXC+BXC+BXC+BXN+BXN+B,N+BXC+BXN+B,C+@T*+B,N+BXN+BXN",
                @"M+B,N+BXN+BXC+B,C+BXN+BXN+B,N+@T*+BXC+BXN+BXC(R,C(RXN+BXN(RXN",
                @"M+BXC+BXC+BXC(PT*+BXN+BXN+B,N+B,C+BXN+BXN+B,N+BXN+BXC+B,C(PT*",
                @"M+BXC+B,N+BXC+BXN+BXN(RXC(RXN+B,N+BXN+BXN+@T*(R,N+BXN+BXN+BXN",
                @"M+BXN+BXN+BXN(RXN+B,C+BXC+@T*+BXN+BXN(RXN+B,N(R,N+BXC(RXC+BXN",
                @"M+BXN(RXN(PT*+B,N+BXN+BXN+BXN+BXN+BXN+B,N+B,C+BXN(RXN+@T*+BXN",
                @"M(RXN+BXN(RXN+BXN+BXC(RXN+BXN(RXC+BXN+@T*+BXN+BXN+B,N(RXN+BXN",
                @"M+B,N+BXN+B,N+B,N+B,C+@T*+BXN+BXN+BXN+B,N+BXN+BXN+B,N+BXN+BXN",
                @"M+BXN+@T*+BXC+B,N+BXN+BXN+BXN+BXN+BXN+BXN+BXN+BXN+@T*+B,N(R,N",
                @"M+B,N(RXN+B,N+BXC+BXN+BXN+BXN(RXN+@T*+BXN+BXC+BXN+B,N+BXN+B,N",
                @"M+B,N+BXN+B,N+BXN+@T*+BXN(RXC+B,N+BXN+B,N(RXN(RXN+BXN+BXC+BXC",
                @"M+@T*+BXN+BXC+BXN(R,C+BXN(R,N+BXC+BXN+BXN(R,N+@T*(RXC(R,N+BXN",
                @"M+BXC+B,N+BXC+B,N(RXN(R,C+BXN+@T*(RXN+BXN(RXN(R,N+BXN+BXC+BXN",
                @"M+BXN+BXN+B,N(PT*(RXN+BXN+BXN+BXN+BXN+B,N+BXN+BXN+B,N(RXN(PT*",
                @"M+BXN+BXC+BXC+BXN+BXN+BXN(RXN+BXN+B,C+B,N+@T*+BXN+BXC+B,C+B,C",
                @"M+BXC+BXC(RXN+BXN+BXN+BXN+@T*+BXN(RXN+BXN+B,C+BXN+BXN+BXN+BXN",
                @"M+BXN(RXC+@T*+B,N+B,N(RXN+BXN+BXN+BXN+B,C+B,N+BXN+BXN+@T*(RXN",
                @"M+BXN(RXN(R,C+BXN+BXN+BXN+BXN+B,C+B,N+@T*+BXN(R,N+B,N(RXN(RXN",
                @"M+BXN+BXN+BXN(RXN(RXN+@T*(RXN+BXC+BXN+BXN+BXN(RXC+BXN+BXN+BXN",
                @"M+BXN+@T*(R,N(RXN+BXN+BXN+B,N+B,C(RXN+BXN+B,N(RXN(PT*+BXN(RXN",
                @"M+B,N+BXN+BXC+B,N(RXC(RXN(RXC(RXN+@T*+BXN+BXC(RXN+BXN+BXN+BXN",
                @"M+B,N(R,N(R,N+B,N+@T*+BXN+B,N+BXN+BXN+BXN+BXN+BXN(RXC(RXN(RXN",
                @"M(PT*+BXN(RXN(RXN+BXN+BXC+BXN(RXN(RXN+BXN+BXN(PT*+BXN+B,N+BXC",
                @"M+BXN(RXN+BXN+BXN+BXN+BXN+BXC+@T*+BXN+B,C+BXN+BXN+BXN+BXN+BXN",
                @"M(RXC+BXN(RXN+@T*+B,N+BXN+B,C(RXN+B,N+BXN+BXN(RXC(RXN+BXN+@T*",
                @"M+BXN+B,C(R,C(RXC+BXN+BXN+BXN+BXN+BXC(R,N(PT*+B,N+B,N+BXN+BXN",
                @"M+BXC(RXN+BXN+BXN+BXN+BXN+@T*+BXN+BXN+BXN+BXN+BXN+B,C+B,N+B,N",
                @"M+BXN(R,C+@T*+BXN+BXN+B,N+BXN+BXN+BXN+BXC+B,N+B,N+B,N+@T*+BXN",
                @"M+BXN(RXC+BXN+BXN+BXN+BXN+BXN(R,N(RXN+@T*+BXN(RXN(R,C(RXC+BXN",
                @"M(RXN(RXN(RXN+BXN+B,N+@T*+BXN+B,N(RXN+B,N+BXN+B,N+BXN+BXN+BXC",
                @"M+BXC(PT*+B,C+BXC+BXN(RXN+BXN+B,C+BXN+B,C+B,N(RXN+@T*+B,C+B,N",
                @"M+BXN+BXN+BXC(RXN+B,N+BXN(RXN+BXN+@T*+BXC+B,N+B,N+BXC+B,N+B,N",
                @"M+BXN+BXN(RXN+B,N(PT*+BXN+BXN+BXN(RXN(RXN+BXN(R,N+B,N+BXN+BXN",
                @"M+@T*+BXC+BXN+BXN(RXN(R,N+BXN+B,N+B,N+BXC(R,N+@T*+BXC+BXN(RXN",
                @"M+BXC+B,N+B,N+B,N(RXC+BXC+B,N+@T*+BXN(RXN(R,C(R,N+BXN+B,N+BXN",
                @"M+BXC+BXN+BXN+@T*(RXC+BXN+BXN+BXN+BXN(RXN+BXN+B,N+B,N+BXC+@T*",
                @"M+BXN+BXN+BXN(RXN+BXN+BXN+BXC(R,N+BXN+BXN(PT*+BXN+BXN(RXN+BXC",
                @"M+BXC+B,C+B,N+BXN+BXC+BXC+@T*+BXN+BXN+BXN+BXC(RXC+BXN+B,N(RXN",
                @"M(RXN+BXN+@T*+BXC+BXN+BXN+BXN+BXN+BXN+BXN+B,N+B,N(RXN+@T*(RXN",
                @"M+BXC(RXN+BXN+BXN+BXN+BXC(RXN+BXC+BXN(PT*(R,N+B,N+BXN(RXN+BXN",
                @"M+BXN+B,N+BXN+BXN+BXN(PT*+BXN+B,N(RXC+BXN(RXN(RXN+BXN+BXN(RXC",
                @"M(RXN(PT*+BXN+BXN+BXN+BXN+BXN(RXN+B,N+B,C+BXC+BXN+@T*+B,C+BXN",
                @"M+BXN+B,N+BXN+BXN(RXN+BXN+BXN+BXN(PT*(RXN+BXN+BXN+BXN+BXN+BXN",
                @"M+BXN+BXN+BXC(RXN+@T*(RXN+BXN+BXN(RXC+BXC+BXC(RXN(R,C(RXC+BXN",
                @"M+@T*+BXN+BXN+BXN+BXN+BXN+BXN+B,C+BXN+BXC(R,N+@T*+B,N+BXN+BXN",
                @"M(RXN(RXN+BXN+B,N+BXN+BXC+BXN(PT*+BXC+BXN+BXN+BXN(RXN+B,N+BXN",
                @"M+BXN+BXN(RXN+@T*+BXN+BXN+BXN+B,N+BXN+BXC+BXN+B,N+BXN+BXN+@T*",
                @"M+B,N+BXN+BXC+BXC+BXN(RXN(RXN+B,C+BXN+B,C+@T*+BXN(RXC+BXC+BXC",
                @"M+BXN+BXN(RXN+BXN(R,N(R,C(PT*+BXN+BXN+B,N(RXN+BXC+BXN+BXN+B,N",
                @"M+BXN+BXN+@T*(RXN+B,N(RXN+B,C+BXC(RXC+BXN+BXN(RXN+BXN+@T*+B,N",
                @"M+BXN+BXN+BXC+BXN+BXN+BXN+BXN+BXN+BXN+@T*+BXN(RXN+BXN+BXN+BXC",
                @"M+B,N+BXN+BXC+BXN+BXN+@T*+BXN(RXN+BXN(R,N+BXN(RXN+BXN+BXN+BXC",
                @"M+BXN+@T*+B,N+BXN+BXN+BXN(R,N+B,N+B,N+B,C+BXN+B,N(PT*+B,C+B,N",
                @"M+BXN+BXN+BXN(RXN+B,N(R,N+BXN+BXN(PT*(RXN+B,C(RXN+BXC+BXC+B,N",
                @"M+BXC+BXC+BXN+BXN+@T*+BXN+BXN+BXN+BXN+BXN+BXN(R,N+BXN+BXN+BXN",
                @"M+@T*+BXC+BXN(R,N(RXN+BXN+BXN+BXN(RXN+BXC+B,C+@T*+BXC+BXN+BXN",
                @"M(RXN(R,N+B,N+BXN(R,N+B,N+BXC+@T*+BXC+BXN+B,N+BXN+B,N(R,N+B,N",
                @"M+BXN+BXN(RXN(PT*(RXN+B,N+BXN(RXN(RXC+BXN+B,N+BXN+BXC(RXN+@T*",
                @"M+BXN+BXN+B,C+BXC+BXN+BXN+BXN+B,N+BXN+BXN+@T*+BXC+BXN+BXN+BXN",
                @"M+BXN+B,C+B,N+BXN+B,N+BXC+@T*+BXN+BXN+BXN+BXN+BXN(RXN+BXC+BXN",
                @"M(RXN+B,C+@T*(R,N+BXN+BXN+BXN+B,N+BXN+BXN(RXC(RXN+BXN+@T*(RXN",
                @"M(RXN+BXN+BXN+BXN(RXN+BXN+BXN+B,N+BXN+@T*+BXN+B,C(RXN+BXN+BXN",
                @"M+BXN+BXC(R,N(R,N+B,C+@T*+BXN+BXN+BXN(RXC+BXN+BXC(R,N+BXN+BXN",
                @"M(RXN+@T*+BXC+B,C+BXN+B,N(RXN+BXN+BXN+BXC+BXN+B,N+@T*(RXN+BXN",
                @"M+BXN(RXN+BXC(RXN+B,N+B,N+BXN+BXN+@T*+BXN+BXN(RXN+BXN+BXN+BXC",
                @"M(R,N+B,N(RXN+BXN+@T*+BXN+BXC+B,N+BXN+BXC(RXN+BXN(RXN(R,N+BXC",
                @"M+@T*+B,N+BXN+BXN(RXN+BXN+B,N+BXC+BXN(RXN+B,N(PT*+B,N+BXN+BXN",
                @"M+BXN(R,N+BXN+BXN(RXN+BXN(R,N(PT*(R,C+B,N+BXC+BXN+B,N+BXN+B,N",
                @"M+BXC+BXN+BXN(PT*+BXC+B,N(RXN(RXC(RXC+BXC+BXN+BXN+BXN+BXN+@T*",
                @"M+BXN+BXC+BXN+BXN+BXN+BXN+BXN+BXN+BXN+BXN+@T*+B,N+B,C(RXN(RXN",
                @"M+B,N+BXC+BXC+BXC+BXN(RXC+@T*(RXN+BXN+BXN+BXN+BXN+BXC(RXN+B,C",
                @"M+B,C+BXN+@T*+BXN+BXN(RXN+B,N+BXC+BXN+BXN+BXN+B,N+BXC+@T*+BXN",
                @"M+BXN+BXN+B,N+BXN+B,C+BXN+BXN+BXN+BXN+@T*+BXC+B,N+BXN+BXC+BXN",
                @"M+BXN+BXC+BXN+BXN+B,N+@T*+BXN+BXN+BXC(RXN+BXN+BXN+BXN+BXC+BXN",
                @"M+BXN+@T*+BXN+BXN+B,N+BXN+BXC+B,C+B,N+B,N+BXN+BXN+@T*(RXC+B,N",
                @"M+BXN(RXN+BXN+BXN(RXN+BXN+BXN+BXC+@T*(R,N+B,C+BXN+BXN(RXN(RXN",
                @"M(RXN+BXN(RXC+BXC(PT*(R,N+B,N+BXN+BXN+BXN(RXN+BXN+BXN+BXN+BXN",
                @"M+@T*(RXN+BXN(R,N+BXC+B,N+BXN+BXC+BXN+BXN+B,N(PT*(RXN+BXN(RXN",
                @"M+B,N+BXN(RXN(RXN+BXN(R,N+BXN+@T*(R,N+BXN+BXN+BXN(RXC+BXN+BXC",
                @"M+BXN+B,N+BXC(PT*+BXC(RXC(R,N+B,N+BXN+B,N+BXN+BXN(RXN+B,N+@T*",
                @"M+B,N(RXN+BXN+BXC+BXN+BXN(R,C+BXN+BXN+BXC+@T*+B,N+BXN+BXN+BXN",
                @"M+BXN+B,N(RXN(R,C+BXN+BXN+@T*+B,N+BXN(RXN(R,N+BXN+BXN+BXC+BXC",
                @"M+B,N+BXN+@T*+BXN+B,N+BXN(RXC+BXN+B,N+B,N+BXN+BXN(R,N(PT*(RXN",
                @"M+BXN+BXC+BXN+BXN+B,N+BXN+BXN+BXC+BXN+@T*+BXN(RXN+BXC+BXN+B,N",
                @"M+BXN+B,C+BXC+BXC+B,N(PT*+BXN+BXN+BXC+BXN+B,N+BXN+BXN+BXN+B,N",
                @"M+BXN+@T*+B,N+BXN+BXC(RXC+B,N(R,N+BXN+BXN+BXN+BXN+@T*(RXN(RXC",
                @"M+BXN+BXC(RXN+BXN+BXN(RXN+BXN+BXN(PT*(R,N+BXC+B,N+BXN+BXN(R,N",
                @"M+BXN+BXN(RXN+B,N+@T*(RXN+B,N+BXN+B,N(R,N+BXC(RXC+BXN+BXC+BXN",
                @"M+@T*+BXN+B,N+B,C+BXN(RXN+BXN+BXN(RXC+BXN(RXN+@T*+BXN(RXN+BXC",
                @"M+B,N(RXN(R,C+BXN(R,N(RXN+BXN(PT*+BXN+BXN(RXN(RXN+BXN(RXN(RXN",
                @"M+BXN+BXN(R,N+@T*+BXN+BXN+B,N+BXN+B,N(RXN+BXN+BXN+B,N(RXN(PT*",
                @"M+BXC+BXN+BXN+B,N(RXC+B,N(RXN+BXC+B,C+BXN(PT*+B,N+BXC+BXN+BXN",
                @"M+BXC+BXC(RXN(RXN+BXN+B,N+@T*+B,N+B,N+BXN+BXN+BXN+BXC+BXN(RXN",
                @"M(RXC+BXN+@T*+BXN(R,N+BXN+BXC+BXN+BXN(RXN+BXN+BXN+BXN+@T*+BXC",
                @"M+BXN(RXC+BXN+BXC+BXN+BXC+BXC(RXC+BXN+@T*+B,N+BXN+BXC+B,N+BXN",
                @"M+BXC+BXC+B,N+BXN+BXN+@T*+BXC+BXN+BXN+BXN+B,C+BXN(RXC+BXN+BXC",
                @"M+BXC+@T*(RXN+B,N+BXN+B,N+B,N+BXC+BXN+BXN+BXN+BXN+@T*+BXC(RXN",
                @"M+BXN+BXN+BXN+BXN+BXN(RXN+BXC+BXN+@T*+B,N+BXN(RXN+BXN+BXC+BXC",
                @"M(RXN+BXC+BXN+BXN(PT*+B,N+BXN(R,C+BXN+BXN+BXN+BXN(R,N+BXN(R,N",
                @"M(PT*(R,N+B,N+BXN+BXN+B,N+B,N+BXC+BXN+BXN+B,N+@T*+BXN+BXC+BXN",
                @"M+BXC+B,N(RXC(RXN+BXN+BXN+B,N+@T*+BXN+BXN+B,N+B,N+BXN(RXN+B,N",
                @"M+BXC+BXN+BXN+@T*+BXN(RXN+B,N+BXC+B,N(RXN(RXC+BXN+BXC+BXN+@T*",
                @"M(RXC+BXN+BXN+BXC+BXC+B,C+BXC+BXC(R,N+BXN+@T*+BXN+BXN+BXN+BXN",
                @"M+BXN+BXN(RXN(RXN+BXN+BXN+@T*(RXC+BXN+BXC+BXC(RXN+BXN+BXN+B,N",
                @"M+BXN+BXN(PT*(R,C+BXC+BXN+BXN+B,N+BXN+BXN+BXN+BXN+B,N+@T*+BXN",
                @"M+BXN(RXN(RXN+BXN(R,C+BXN+BXN+BXN+B,N+@T*+BXN+B,N(RXN+B,N+B,N",
                @"M+BXN+BXN+BXN+B,N(RXN+@T*+BXN(RXN+BXN(RXN+BXN+BXC+BXN+BXC+B,N",
                @"M+BXN+@T*(RXN+BXN(R,N+B,N+BXN+BXC(RXN+BXN+BXN+BXN(PT*(RXN+B,C",
                @"M(RXN+BXN+BXN+BXN(R,N+B,N+BXC+B,C+@T*+BXN+BXN(R,N(R,N(RXN+B,N",
                @"M+B,N+BXN(RXN+BXN+@T*+BXN(RXC+BXN+BXN(R,N(RXN+BXN+B,C+BXN+B,N",
                @"M(PT*+BXN+BXN+BXN+BXN+BXC+B,N(R,C+BXN+BXN+B,N+@T*+BXN+BXN+BXC",
                @"M+BXN+B,N+BXN+BXN(R,N+B,N+B,C(PT*+BXN(RXN+BXN(R,N(RXN+BXC+BXN",
                @"M+BXN(R,N+B,N(PT*+BXC(RXN+BXN+BXN(RXN+BXN(RXC+BXC+BXN(RXN+@T*",
                @"M+B,N+B,N(R,N+BXN+BXN+BXC+BXN+BXC+BXN(RXN(PT*+BXC+BXC+BXN+B,N",
                @"M+BXN+BXN+BXN+B,N+BXN+BXN+@T*+B,N+BXC+BXN+BXN+BXN+BXN+BXN+BXN",
                @"M+BXC+BXN+@T*(R,N+BXN+B,C+BXN+B,N+BXN+BXN+BXN+BXN(RXC+@T*+BXN",
                @"M+B,N(RXN(RXC+BXC+B,N(RXN+BXN+BXN+BXC(PT*+BXN+BXN+BXN+BXN+B,C",
                @"M+B,N+BXN+B,N+B,N+B,N+@T*+B,N+BXN(RXN+BXN(R,N+BXC+B,C(RXN+BXN",
                @"M+BXN+@T*+BXC+BXN+BXN+BXC+BXN+BXN+BXC+B,N+B,C(RXN+@T*+B,C+BXN",
                @"M+B,N+BXC+BXN(RXN+BXN+BXC+BXN(RXC+@T*+BXC+BXN(RXN+B,N+B,C+BXN",
                @"M+BXN+BXC+BXC+BXN+@T*+BXC(RXC+BXC+BXC+BXN+BXC+BXN+BXN(RXC+BXC",
                @"M+@T*+B,N+BXN+BXN+B,N+B,N+BXN(RXN(RXN+BXN+BXN+@T*+BXC+B,N+BXN",
                @"M+B,N(R,N+B,N+BXN+BXN+B,C(RXC+@T*+BXN+BXC+B,C+BXN+BXC(RXC+BXN",
                @"M+BXN+BXN+BXN+@T*(RXN+BXN+BXN+B,N+BXN+BXN(RXN+B,C+BXN(RXN+@T*",
                @"M+BXC+B,C+B,N+B,N+B,N+BXN+BXN+BXN+BXC+BXN+@T*+B,C+BXN+B,N+B,N",
                @"M+BXN+BXN+BXN+BXC+BXN+BXC+@T*(R,C+BXN+BXN+BXC(RXN+BXN(R,N(RXN",
                @"M+B,N+BXN+@T*(RXN+BXN+B,C+BXC(RXC+B,N(RXC+B,N(RXN(R,N+@T*+BXN",
                @"M+BXC(R,N+BXN+B,N+BXN(RXN+BXN+B,N+BXN(PT*+BXN+BXN+BXC+BXN+BXN",
                @"M+BXN(R,N+BXC+BXN+B,N(PT*+B,N(RXN+BXN(RXC+BXC+BXC(RXN+BXN+B,N",
                @"M+BXC+@T*+BXN(RXC(RXN+BXC+BXC+B,C(RXN(RXN(R,N+BXN+@T*+BXN+B,N",
                @"M+BXN+BXN+BXN(R,N+B,N+B,N+B,N+B,N+@T*+BXN(RXN(RXC(RXN(RXN(RXN",
                @"M+BXC+BXN+BXN+BXN(PT*+BXN+BXC+BXC(R,N(RXN+BXN(RXN+BXN(RXN(RXN",
                @"M+@T*+BXN+BXN(RXN+B,N+BXN(RXC(RXN+B,N(RXN+BXN+@T*+B,N(R,C+BXC",
                @"M(RXN+BXN(R,N(R,N+BXN+BXC(RXN+@T*+BXN+BXC+B,N+BXN+BXN+BXN+B,N",
                @"M(RXN+BXN+BXN+@T*(RXN+BXN+BXN(RXN+B,N+B,N+BXN+BXC(RXC+BXN+@T*",
                @"M+BXC+BXN+BXN+B,C+BXN+B,C+BXN+B,N(R,N(RXN(PT*+BXN(R,C+B,N+BXN",
                @"M+BXN+BXC+BXN+BXN(RXN+BXN(PT*+BXC+B,C+BXC+BXN+B,N+BXN+B,C+BXN",
                @"M(RXC(RXN+@T*+BXN+B,C+B,C+BXN+BXN+BXN+BXN+B,N+BXC+BXN+@T*(R,N",
                @"M+B,N+BXC+BXC+BXC+BXC+BXN+BXN+BXN+BXN+@T*+BXN+BXC+BXN+BXC+BXN",
                @"M+BXC+BXN+BXN+BXN+BXN+@T*+BXN(RXC(RXN+BXN+BXC+BXC+B,N+BXN+B,N",
                @"M+BXN(PT*(RXN+BXN(R,N+BXN+BXN+BXC+BXN+BXN(R,N+BXN+@T*+BXN+BXC",
                @"M(RXN+BXN+BXN+BXC+BXC+BXN(RXN(RXN+@T*(RXN+B,C(RXN+BXC+BXN+BXN",
                @"M+B,N+BXC(RXN+BXN+@T*+B,N+BXN(RXN(RXN+BXN+B,N+BXN+B,N+BXC+B,N",
                @"M+@T*(RXN+BXN+BXN(RXC+B,N+BXC+BXN+BXC(R,N(RXC(PT*(R,N+BXC+BXN",
                @"M(R,N+B,N+B,N+BXN(RXN+BXN+BXN+@T*+BXN+B,N+BXN+BXN+BXN+BXC+BXC",
                @"M+BXN+BXC+BXN+@T*(RXN+BXN+B,N+BXN+BXN+BXC(RXN+BXC+BXN+BXN+@T*",
                @"M+B,N+B,N+B,N+BXN+BXN+B,N+BXN+BXN+BXN+BXN(PT*+B,C+BXN+BXN+BXN",
                @"M+B,N+BXN+BXC+BXN+BXN+B,N+@T*(RXN+BXN+BXN+BXN+B,N+B,N+BXN(RXN",
                @"M+BXN+BXN+@T*+BXN+B,N(RXN+BXN(RXC(RXN+B,N+BXN+B,N(RXN+@T*+BXN",
                @"M(RXC+BXC+BXN(R,N+B,N+BXC+B,N(RXN+BXN+@T*(RXN+BXC+BXC+BXN+BXN",
                @"M+BXN(R,N+B,N(RXC+BXC(PT*+B,N+BXC+BXN+BXN+BXN+BXN+BXC+BXN+BXN",
                @"M+B,N+@T*(RXN+B,N+BXN+B,N(RXN+BXN+BXN(R,N+BXN+BXC(PT*+BXN(RXN",
                @"M+BXC(RXC(R,C+B,N+BXN+BXN+BXC+B,N(PT*+BXN+B,C(RXC+BXC+BXN+BXN",
                @"M+BXN+BXN(RXC+BXC+@T*+BXN+B,N+BXN+BXC+BXN(RXN+BXN+B,C+B,N(RXC",
                @"M+@T*+BXN+BXC+BXC+B,N(R,N(RXN+B,C+BXN+BXN+BXN+@T*(R,N+B,N+BXC",
                @"M+B,N+BXC(R,N+BXN+BXN+BXN+BXN(PT*+BXN+B,N+BXC+BXC+BXN+BXC+B,N",
                @"M+B,N+B,N+B,N+@T*(RXN+BXN+BXN+BXC(R,C+BXN+BXN(RXN+BXN(R,C+@T*",
                @"M+BXN+BXN+BXN(RXN+BXN+BXN(RXC(RXC+BXN(RXN+@T*+BXN+BXN+BXN(RXN",
                @"M+BXN+BXN+BXC+B,N+B,C(RXN+@T*+BXN+BXC(RXN+BXN+BXN(R,N+BXN+BXN",
                @"M+BXC+BXN(PT*+BXC(RXN+BXC+BXN(RXN+BXN+BXC(RXN+BXN+BXN+@T*+BXN",
                @"M+BXC+B,N+BXN+BXC(RXN+BXC+BXN(RXN+B,N+@T*+B,C+BXC+BXC(RXN+BXN",
                @"M+BXN+BXN+BXN+BXN+BXN+@T*+BXN+BXN+B,N+BXC+BXC+BXC+BXN(R,N+BXN",
                @"M(RXN+@T*+B,N+BXC+BXN+BXN+B,C(RXN+B,N+B,N+B,N+BXN+@T*+BXN+BXN",
                @"M+B,N+BXN+B,C+B,C+B,N+BXN+BXN(RXN(PT*+B,C+BXN+BXN(RXN+B,N+BXN",
                @"M(RXN(RXN+BXN+B,C+@T*+B,C+BXN+B,N+B,N+BXN(RXN+B,N+BXC+BXN+BXN",
                @"M+@T*+BXN+BXN+BXN(R,N+B,N+B,N(RXC+BXN+BXC(RXN+@T*+BXN(RXN+BXN",
                @"M+BXN+BXN+BXN(RXN(RXN+BXN(R,C(PT*+B,N(RXC+BXC+BXN+BXN+B,N+BXN",
                @"M+BXN(RXN+BXN+@T*+BXC+B,N+BXN+BXC+BXN+BXN+BXN+B,N+BXN+BXN+@T*",
                @"M+B,N+BXC+B,N+B,N+BXN+BXN(RXN(RXN(RXN(RXN+@T*+BXN+BXN+B,C+B,N",
                @"M+BXC+BXC+BXN+B,N+BXN+B,N+@T*+B,C+BXN(R,N+BXN(R,N+BXC+BXN+BXN",
                @"M+BXC(R,C+@T*+BXN+B,N(RXN(R,N+BXN(RXN+B,N+BXN(RXC+BXN+@T*+BXN",
                @"M+BXC+BXN+BXC+BXC+BXC+B,N(R,N+B,N+BXN+@T*+BXC+BXN+B,N+BXN+BXN",
                @"M+BXN+BXN+B,N+BXN(RXN+@T*+BXC+B,N(RXN+BXN(R,N(RXN+BXN(RXN(R,N",
                @"M+BXN+@T*+BXN+B,N+BXN+B,N+BXN(RXN+B,N+BXC+BXC+B,N+@T*(RXN+B,N",
                @"M+BXN+BXN+BXN+B,N+B,N+B,N+BXN+BXN+@T*+BXN(RXC+BXC+BXN+BXN+BXN",
                @"M(R,N(RXN+B,N+B,C+@T*+BXN+BXN(RXC+BXN+BXN+BXN(RXC+BXN(RXN+BXN",
                @"M+@T*+BXN+BXN(RXN(R,N(R,C+BXN+BXN(R,N(RXN+BXC+@T*+BXN+BXC+BXN",
                @"M(RXN(RXN+BXN+BXC+BXN+BXN+BXN+@T*+B,N+BXC+BXN+BXN+B,N+BXN+B,C",
                @"M(RXN+BXN+B,N+@T*+BXN+BXN+BXN+BXC(RXN+BXN(RXN(RXN(RXN+BXC+@T*",
                @"M+BXC+BXN+B,N+B,N+BXC+BXN+BXN(RXN+BXN+BXC+@T*+BXC+BXN(RXN+B,N",
                @"M(RXN(RXN+BXC+BXN(RXN+BXN+@T*+BXN+BXN+B,N+BXN(R,C+B,C(R,N+BXC",
                @"M(R,N(RXN+@T*(RXC(RXC+BXN+BXN+B,N+BXN+BXN(RXN+BXC+B,N(PT*+B,C",
                @"M+BXN+BXN+BXN+B,N+BXN+B,N+B,C(RXN+BXN+@T*+BXN+BXC+BXN+BXN+BXN",
                @"M+BXC+B,C+BXC+BXN+B,N+@T*+BXN+BXN+BXC(RXN+BXN(RXC+BXN+BXN+BXC",
                @"M(RXN+@T*(RXN(RXN(RXN+BXN+BXN+BXN+BXN+BXN+B,C+BXN+@T*(RXN+B,C",
                @"M(RXN+BXN+BXN+BXC+BXN+BXN+BXN+BXN+@T*+BXN+BXN+B,N(RXN+BXN+BXC",
                @"M+B,N+BXN+BXN(R,N+@T*+BXN+BXC+B,N+BXC+BXN+B,N+BXC(R,C+BXN+BXC",
                @"M+@T*+BXC(RXN+BXN(R,N+BXN+BXN(RXN+BXC+BXN+BXN+@T*(R,N+BXN+BXN",
                @"M+BXN(RXN+B,N+B,C+BXN+B,C+BXN+@T*+BXN+BXN+BXN+B,N+B,N+BXN+BXC",
                @"M+BXN+BXN+BXC+@T*(R,N+B,N+BXN(RXN(RXN+BXC+BXN+BXC(RXN+BXC+@T*",
                @"M(R,N(R,N+BXN+B,N+BXC(RXC(RXN+BXN+BXC+BXN+@T*+BXC+BXC+B,C(RXC",
                @"M+BXC(RXC+BXC+BXC+BXN(RXN+@T*+B,N+B,N+BXN+B,N+BXN+BXN+B,N+BXC",
                @"M(RXC+BXN+@T*+BXC+BXC+BXN+BXC+B,N+BXN+BXC(RXC+B,N+BXN+@T*+B,N",
                @"M+B,C+BXN(RXC+BXN+B,N+BXC+BXN(RXC+B,C+@T*+BXN+BXN+BXN(RXN+B,N",
                @"M+BXN(R,C+B,N+BXN+B,N+@T*+BXN+BXN+BXN+BXC(R,N(RXC+BXC+BXC+BXN",
                @"M(RXC+@T*(R,N+BXC+BXN+BXN(R,N+BXN+BXN+BXN+B,N+B,N+@T*+BXN+BXN",
                @"M+BXN(R,N+B,N+BXC+BXN+BXN+B,N+BXN+@T*(RXN+BXN+B,N(RXN+BXN+BXN",
                @"M+BXC+BXC+BXN+BXN+@T*+BXN(RXN+BXN+BXN+BXN+BXN+BXN(RXN+BXC+BXN",
                @"M+@T*(RXN+BXC+BXN+BXN+BXN+BXN+BXN+BXN+BXN+B,C+@T*(R,N+BXN+BXN",
                @"M(RXN(RXN+BXN+B,N(RXN+B,C(RXC+@T*+BXC+BXN+B,N+B,N(RXN+BXN+B,N",
                @"M+BXN+BXN+BXN+@T*+BXN(RXN+BXN+BXN+BXN(R,C+B,N(RXN+BXN+BXN+@T*",
                @"M+BXC+BXC(RXN+BXN(RXN+BXN(R,N+BXC(RXN+BXN+@T*+BXC+BXC+B,N(RXC",
                @"M+BXC+BXC+BXC(RXN+BXC+BXN(PT*(RXN+BXN+B,C+BXN+BXC(RXN(R,N(R,N",
                @"M+BXC+BXN+@T*(RXN+BXN(RXN+BXN(RXC+BXN+BXN+BXC+BXN+BXN+@T*+B,N",
                @"M+BXN+B,N+BXN+BXN+BXN+BXN+BXN+B,N+BXN(PT*+B,C(RXN+BXC+BXN(RXN",
                @"M+BXN+BXN+BXN+B,N(RXC+@T*+B,N+BXC+B,N+BXN+BXC+B,N+BXN+BXN+BXN",
                @"M+BXN+@T*+BXN+B,N+BXC+BXN+BXN(RXN+BXN(RXN+BXN+BXC+@T*+BXN+BXN",
                @"M+BXC+BXN+BXC+BXN+BXN+BXN+B,N+BXN(PT*(RXN(RXN+BXN+B,N+BXC+BXN",
                @"M(RXN+BXN+BXN+B,N+@T*(RXN+BXC+BXN+BXN(RXN+B,C+B,N+BXC+BXN(RXN",
                @"M+@T*(RXN+B,N+BXN(RXN+BXC+BXC+BXC+BXN+BXC+BXC+@T*(RXN+BXN+B,C",
                @"M+BXC+BXC+B,N(RXN(RXC+BXN+BXN+@T*+BXC+BXC+BXN+BXN+BXN+BXN+BXN",
                @"M(RXN+B,C+BXN(PT*+BXN+BXN+BXN+BXN(RXN+BXN+BXN+BXN+BXN(RXC(PT*",
                @"M+B,N(RXC+BXN+BXN(R,N+BXN+BXN(RXN+BXN+BXC+@T*+BXN+B,N+BXN+BXN",
                @"M+BXC(RXN+BXN+BXC+BXN(R,C+@T*+BXN+BXN+B,N(RXN+B,N(RXC+BXN+BXN",
                @"M+B,N+BXN+@T*+BXN+B,N+B,N+B,N+BXC+BXN+B,N(R,N(RXC(RXN+@T*+BXN",
                @"M(R,N(R,N(RXN+B,N+BXN+BXC+BXN+BXN+BXN+@T*(RXN+BXN(RXN+B,N(RXN",
                @"M+B,N(R,N+B,C+B,N+BXN+@T*+BXN+BXN+B,N+BXN+B,N+BXC+B,N+BXC(RXC",
                @"M+BXN+@T*+B,N+BXN+BXN+BXN+BXN(RXN+BXN(RXN+BXC(RXN(PT*(R,N+BXN",
                @"M+BXC+BXN+BXN+B,N+BXC+BXN+B,N+BXN+@T*+B,C(RXN+BXN+B,N+BXN+BXN",
                @"M+BXN+BXN+BXN+B,N+@T*(RXC+BXN+BXN(R,N+BXN+BXN+BXC(RXN(RXN+BXN",
                @"M+@T*+BXN(RXN+BXC+BXN+BXN+BXN+B,N(RXN+BXN+BXN+@T*+BXC(RXN(RXN",
                @"M+BXN+BXN+B,N+BXN+BXN+BXN+BXN+@T*+BXN+BXC+BXN(RXN+BXN+BXN+BXN",
                @"M+BXN+BXN+B,N(PT*+BXN+BXN+BXN+BXN+B,N+BXN+BXN+BXC+BXN(RXN(PT*",
                @"M+BXN+B,N+BXN(RXN+BXN+B,N(RXN+BXN+BXC+BXN(PT*(RXN(RXN+BXN+BXN",
                @"M+BXN+B,N(RXN+BXN+BXC+BXN(PT*+BXC+BXN+BXC+BXN+BXN+BXN+BXN(RXN",
                @"M+BXN+BXN+@T*+B,N+BXN+BXN+BXN+BXN+BXN+BXN+BXC(R,N+BXN(PT*+BXN",
                @"M+BXN+BXC+B,C(R,N+BXN+BXN+BXC+B,N(RXN+@T*(RXN+BXN+BXN+BXN(R,N",
                @"M+BXC+BXN+BXN+BXN(RXN(PT*+BXN+BXN+BXN+BXC+BXC+BXN+BXN(RXN+B,N",
                @"I(RXN+@T*+BXN+B,C+BXN(R,N+BXN+B,N+BXN+B,N+BXN+BXN+@T*#0H`",
                @"`"
            };
    }
}
