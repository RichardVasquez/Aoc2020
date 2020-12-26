using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver06 : AbstractAocSolver, IAocSolver
    {
        private List<CustomsForm> _forms;
        
        public Solver06(int n) : base(n) { }

        public override void Solve()
        {
            _forms = ProblemData.Get().ToBlobs().Select(cf => new CustomsForm(cf)).ToList();
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
            return _forms.Select(c => c.DistinctQuestions).Sum().ToString();
        }

        private string SolvePart2()
        {
            return _forms.Select(c => c.AllMatchedQuestions).Sum().ToString();
        }

        private class CustomsForm
        {
            private readonly int People;
            private readonly Dictionary<char, int> _tally;
            public int DistinctQuestions => _tally.Keys.Count;
            public int AllMatchedQuestions => _tally.Values.Count(c => c == People);

            public CustomsForm(string s)
            {
                string[] answers = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                People = answers.Length;

                _tally = new Dictionary<char, int>();
                foreach (string answer in answers)
                {
                    foreach (char c in answer)
                    {
                        if (!_tally.ContainsKey(c))
                        {
                            _tally[c] = 0;
                        }

                        _tally[c]++;
                    }
                }
            }
        }

    }
}
