using System;
using System.Collections.Generic;
using System.Diagnostics;
using AdventOfCode2020Solver.Data;

namespace AdventOfCode2020Solver.Internal
{
    public abstract class AbstractAocSolver : IAocSolver
    {
        public int Index;
        public IData ProblemData;
        public string Title;

        public List<string> Answers;
        public List<long> Milliseconds;

        protected AbstractAocSolver(int i)
        {
            Index = i;
            Answers = new List<string>();
            Milliseconds = new List<long>();
        }

        public void AddData(IData data)
        {
            ProblemData = data;
        }

        public void SolveOnce()
        {
            throw new NotImplementedException();
        }

        public virtual void Solve()
        {
        }

        public virtual void SolveOnce(Func<string> solver)
        {
            var sw = new Stopwatch();
            sw.Start();
            Answers.Add(solver());
            sw.Stop();
            Milliseconds.Add(sw.ElapsedMilliseconds);
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string s)
        {
            Title = s;
        }

        public virtual string SolvePart1()
        {
            throw new NotImplementedException();
        }

        public virtual string SolvePart2()
        {
            throw new NotImplementedException();
        }

        public virtual List<string> GetResults()
        {
            var results = new List<string>();
            for (var i = 0; i < Answers.Count; i++)
            {
                results.Add(Answers[i]);
                results.Add(Milliseconds[i].ToString());
            }

            return results;
        }
    }
}
