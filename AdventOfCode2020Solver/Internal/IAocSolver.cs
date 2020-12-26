using System;

namespace AdventOfCode2020Solver.Internal
{
    public interface IAocSolver
    {
        public void AddData(IData data);
        public void Solve();
        public void SolveOnce(Func<string> solver);
    }
}
