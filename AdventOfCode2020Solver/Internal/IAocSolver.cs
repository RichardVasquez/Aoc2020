namespace AdventOfCode2020Solver.Internal
{
    public interface IAocSolver
    {
        public void AddData(IData data);
        public string SolvePart1();
        public string SolvePart2();
        public void Solve();
    }
}
