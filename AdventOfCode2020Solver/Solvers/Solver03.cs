using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver03 : AbstractAocSolver
    {
        private List<string> _mapData;
        public Solver03(int i) : base(i) { }
        public override void Solve()
        {
            _mapData = ProblemData.Get().ToLines(true);

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
            var x = 0;
            var trees = 0;
            foreach (string line in _mapData)
            {
                if (line[x] == '#')
                {
                    trees++;
                }

                x += 3;
                x %= _mapData[0].Length;
            }

            return $"{trees}";
        }

        private string SolvePart2()
        {
            var xVals = new List<int> {1, 3, 5, 7, 1};
            var yVals = new List<int> {1, 1, 1, 1, 2};
            var treesHit = new List<int> {0, 0, 0, 0, 0};

            for (var i = 0; i < xVals.Count; i++)
            {
                var x = 0;
                for (var y = 0; y < _mapData.Count; y += yVals[i])
                {
                    if (_mapData[y][x] == '#')
                    {
                        treesHit[i]++;
                    }

                    x += xVals[i];
                    x %= _mapData[0].Length;
                }
            }

            long product = treesHit.Aggregate<int, long>(1, (current, i) => current * i);
            return $"{product}";
        }
    }
}
