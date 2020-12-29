using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver19 : AbstractAocSolver
    {
        public Solver19(int n) : base(n) { }
        private List<string> _rules;
        private List<string> _messages;
        private readonly Dictionary<string, string> _lookup = new Dictionary<string, string>();
       
        public override void Solve()
        {
            var data = ProblemData.Get().ToBlobs(false);
            _rules = data[0].ToLines();
            _messages = data[1].ToLines();
            ParseRules();
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            return CountMatches().ToString();
        }

        public override string SolvePart2()
        {
            _lookup["8"] = "( 42 | 42 8 )";
            _lookup["11"] = "( 42 31 | 42 11 31 )";

            return CountMatches().ToString();
        }

        private int CountMatches()
        {
            var regex = $"^{GenerateRegex()}$";
            return  _messages.Count(m => Regex.IsMatch(m, regex));
        }

        private string GenerateRegex()
        {
            var current = _lookup["0"].Split(" ").ToList();
            while (current.Any(c => c.Any(char.IsDigit)) && current.Count() < 100000)
            {
                current = current.Select(l => _lookup.ContainsKey(l) ? _lookup[l] : l)
                                 .SelectMany(s => s.Split(" ")).ToList();
            }

            return string.Join("", current);
        }

        private void ParseRules()
        {
            foreach (string rule in _rules)
            {
                string newRule;
                string[] parts = rule.Split(':');
                if (parts[1].Contains('|'))
                {
                    string[] tempRules = parts[1].Split('|');
                    newRule = $"( {tempRules[0]} | {tempRules[1]} )";
                }
                else
                {
                    newRule = parts[1].Replace(@"""", "").Trim();
                }

                _lookup[parts[0].Trim()] = newRule;
            }
        }
    }
}
