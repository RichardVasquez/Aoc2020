using System;
using AdventOfCode2020Solver.Data;

namespace AdventOfCode2020Solver.Internal
{
    public abstract class AbstractAocSolver : IAocSolver
    {
        public int Index;
        public IData ProblemData;

        protected AbstractAocSolver(int i)
        {
            Index = i;
        }

        public void AddData(IData data)
        {
            ProblemData = data;
        }

        public virtual string SolvePart1()
        {
            throw new NotImplementedException();
        }

        public virtual string SolvePart2()
        {
            throw new NotImplementedException();
        }

        public virtual void Solve()
        {
            throw new NotImplementedException();
        }
    }
}
