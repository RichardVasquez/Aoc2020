using System;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver16 : AbstractAocSolver, IAocSolver
    {
        public Solver16(int n) : base(n) { }

        public override void Solve()
        {
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
            return "Not Found";
        }

        private string SolvePart2()
        {
            return "Not Found";
        }

    }
}
