using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver05 : AbstractAocSolver
    {
        private List<int> _seats;

        public Solver05(int n) : base(n) { }

        public override void Solve()
        {

            var data = ProblemData.Get().ToLines(true);
            _seats = 
                (
                    from s in data
                    let bin = s.Replace('F', '0').Replace('B', '1').Replace('R', '1').Replace('L', '0')
                    select Convert.ToInt32(bin, 2)
                )
               .ToList();
            _seats.Sort();

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            return _seats.Max().ToString();
        }

        public override string SolvePart2()
        {
            long pyramid = _seats.Last() * (_seats.Last() + 1) / 2 -
                           (_seats.First() - 1) * _seats.First() / 2;
            long total = _seats.Sum();

            return (pyramid - total).ToString();
        }

    }
}
