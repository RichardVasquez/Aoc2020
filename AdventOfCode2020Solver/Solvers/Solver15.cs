using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver15 : AbstractAocSolver
    {
        private List<long> _numbers;
        
        public Solver15(int n) : base(n) { }

        public override void Solve()
        {
            _numbers = ProblemData.Get().ToTokens().Select(t => Convert.ToInt64(t)).ToList();

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            return ActualSolver(2020);
        }

        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: Entry[System.Int64,System.Int64][]")]
        public override string SolvePart2()
        {
            return ActualSolver(30000000);
        }

        private string ActualSolver(int limit)
        {
            var counters = new Dictionary<long, long>();

            for (var i = 0; i < _numbers.Count -1; i++)
            {
                counters.Add(_numbers[i], i + 1);
            }

            long lastSpoken = _numbers.Last();
            int turn = counters.Count + 1;

            for (int i = turn; i <= limit; i++)
            {
                if (counters.ContainsKey(lastSpoken))
                {
                    long temp = lastSpoken;
                    lastSpoken = i - counters[lastSpoken];
                    counters[temp] = i;
                }
                else
                {
                    counters[lastSpoken] = i;
                    lastSpoken = 0;
                }
            }

            long final = counters.SingleOrDefault(c => c.Value == limit).Key;
	        
            return $"{final}";
        }
    }
}
