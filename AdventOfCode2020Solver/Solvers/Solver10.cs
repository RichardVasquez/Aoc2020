using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver10 : AbstractAocSolver, IAocSolver
    {
        private List<int> _jolts;
        public Solver10(int n) : base(n) { }

        public override void Solve()
        {
            _jolts = ProblemData.Get().ToLines(true).Select(l => Convert.ToInt32(l)).ToList();
            _jolts.Add(0);
            _jolts.Sort();
            _jolts.Add(_jolts.Last() + 3);
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            var myJolts = new List<int>(_jolts);
            myJolts.Reverse();

            int count1 = 0;
            int count3 = 0;

            for (int i = 0; i < myJolts.Count - 1; i++)
            {
                // not 2470
                switch (myJolts[i] - myJolts[i + 1])
                {
                    case 1:
                        count1++;
                        break;
                    case 3:
                        count3++;
                        break;
                }
            }

            return $"{count1 * count3}";
        }

        public override string SolvePart2()
        {
            var memo = new Dictionary<int, long>
                       {
                           [_jolts.Count - 1] = 1
                       };

            for(int k = _jolts.Count - 2; k >= 0; k--)
            {
                long currentCount = 0;
                for(int connected = k + 1; connected < _jolts.Count() && _jolts[connected] - _jolts[k] <= 3; connected++)
                {
                    currentCount += memo[connected];
                }
                memo[k] = currentCount;
            }

            return memo[0].ToString();
        }

    }
}
