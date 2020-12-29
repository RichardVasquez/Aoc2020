using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Library;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver02 : AbstractAocSolver
    {
        private List<List<string>> _passwordData;


        public Solver02(int i) : base(i) { }
        public override void Solve()
        {
            _passwordData = ProblemData.Get()
                                       .ToJaggedLines(TextUtility.SeparatorList(Separators.All, "-:"))
                                       .ToList();

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            return
                (
                    from t in _passwordData
                    let count1 = int.Parse(t[0])
                    let count2 = int.Parse(t[1])
                    let rule = t[2][0]
                    let pass = t[3]
                    let countLetters = pass.Count(x => x == rule)
                    where countLetters >= count1 && countLetters <= count2
                    select count1).Count().ToString();
        }

        public override string SolvePart2()
        {
            return
                (
                    from t in _passwordData
                    let count1 = int.Parse(t[0])
                    let count2 = int.Parse(t[1])
                    let rule = t[2][0]
                    let pass = t[3]
                    where pass[count1 - 1] == rule ^ pass[count2 - 1] == rule
                    select count1).Count().ToString();
        }
    }
}
