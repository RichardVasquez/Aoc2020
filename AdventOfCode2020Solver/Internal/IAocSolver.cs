using System;
using System.Collections.Generic;

namespace AdventOfCode2020Solver.Internal
{
    public interface IAocSolver
    {
        public void AddData(IData data);
        public void Solve();
        public void SolveOnce(Func<string> solver);
        public string GetTitle();
        public void SetTitle(string s);
        public string SolvePart1();
        public string SolvePart2();
        public List<string> GetResults();
    }
}
