using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver09 : AbstractAocSolver
    {
        private List<long> _numbers;
        private long _xmasKey;

        public Solver09(int n) : base(n) { }

        public override void Solve()
        {
            _numbers = ProblemData.Get().ToLines(true).Select(a => Convert.ToInt64(a)).ToList();

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            for (var i = 25; i < _numbers.Count; i++)
            {
                var slice = _numbers.Skip(i - 25).Take(25).ToList();
                var valid = GetKeys(slice);

                if (valid.Contains(_numbers[i]))
                {
                    continue;
                }
                _xmasKey = _numbers[i];
                return _numbers[i].ToString();
            }

            return "Not Found";
        }

        public override string SolvePart2()
        {
            for (var i = 0; i < _numbers.Count; i++)
            {
                for (var k = 0; k < _numbers.Count - i-2; k++)
                {
                    var subset = _numbers.Skip(k).Take(i).ToList();
                    if (_xmasKey != subset.Sum() || subset.Count() <= 1)
                    {
                        continue;
                    }
                    long result = subset.Min() + subset.Max();
                    return $"{result}";
                }
            }

            return "Not Found";
        }
        private static HashSet<long> GetKeys(IEnumerable<long> keys)
        {
            var values = keys.ToList();
            var result = new HashSet<long>();

            for (var i = 0; i < values.Count; i++)
            {
                for (var k = 0; k < values.Count; k++)
                {
                    if (i != k)
                    {
                        result.Add(values[i] + values[k]);
                    }
                }
            }

            return result;
        }

    }
}
