using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver10 : AbstractAocSolver, IAocSolver
    {

        public List<int> Jolts;
        public Solver10(int n) : base(n) { }

        public override void Solve()
        {
            Jolts = ProblemData.Get().ToLines(true).Select(l => Convert.ToInt32(l)).ToList();
            Jolts.Add(0);
            Jolts.Sort();
            Jolts.Add(Jolts.Last() + 3);
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
            var myJolts = new List<int>(Jolts);
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

        private string SolvePart2()
        {
            var memo = new Dictionary<int, long>
                       {
                           [Jolts.Count - 1] = 1
                       };

            for(int k = Jolts.Count - 2; k >= 0; k--)
            {
                long currentCount = 0;
                for(int connected = k + 1; connected < Jolts.Count() && Jolts[connected] - Jolts[k] <= 3; connected++)
                {
                    currentCount += memo[connected];
                }
                memo[k] = currentCount;
            }

            return memo[0].ToString();
        }

    }
}
