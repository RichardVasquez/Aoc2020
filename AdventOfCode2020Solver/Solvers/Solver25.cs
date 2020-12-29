using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver25 : AbstractAocSolver
    {
        private List<long> _keys;
        private const long Prime = 20201227;
        private const long InitialSubject = 7;

        public Solver25(int n) : base(n) { }

        public override void Solve()
        {
            _keys = ProblemData.Get().ToLines(true).Select(d => Convert.ToInt64(d)).ToList();

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            int doorLoop = GetLoopSize(_keys[1]);

            long initialKey = _keys[0];
            for (var i = 0; i < doorLoop - 1; i++)
            {
                initialKey *= _keys[0];
                initialKey %= Prime;
            }

            return initialKey.ToString();
        }

        public override string SolvePart2()
        {
            return "Start Vacation!";
        }

        private static int GetLoopSize(long key)
        {
            var loop = 1;
            long checkKey = InitialSubject;

            while (checkKey != key)
            {
                checkKey *= InitialSubject;
                checkKey %= Prime;
                loop++;
            }

            return loop;
        }
    }
}
