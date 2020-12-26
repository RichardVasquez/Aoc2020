using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver01 : AbstractAocSolver, IAocSolver
    {
        private List<long> _numbers;
        private const long BaseValue = 2020;
        
        public Solver01(int n) : base(n)
        {
        }

        public override void Solve()
        {
            _numbers = ProblemData.Get().ToLines(true).Select(l => Convert.ToInt64(l)).ToList();
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        public sealed override string SolvePart1()
        {
            foreach (long index in _numbers.Where(idx => _numbers.Contains(BaseValue - idx)))
            {
                return (index * (BaseValue - index)).ToString();
            }

            return "Not Found";
        }
        
        public sealed override string SolvePart2()
        {
            foreach (long index1 in _numbers)
            {
                long temp = BaseValue - index1;
                foreach (long index2 in _numbers.Where(index => index != index1))
                {
                    if (_numbers.Contains(temp - index2))
                    {
                        return (index1 * (temp - index2) * index2).ToString();
                    }
                }
            }

            return "Not Found";
        }

    }
}
