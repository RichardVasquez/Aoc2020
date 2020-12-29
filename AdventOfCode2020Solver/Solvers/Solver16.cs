using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver16 : AbstractAocSolver
    {
        private Dictionary<string, List<int>> _fieldRanges;
        private List<int> _myTicket;
        private List<List<int>> _nearby;

        public Solver16(int n) : base(n) { }

        public override void Solve()
        {
            var data = ProblemData.Get().ToBlobs(false);

            var fieldData = data[0].ToLines(true);
            _fieldRanges = new Dictionary<string, List<int>>();
            foreach (string[] parts in fieldData.Select(t => t.Split(':')))
            {
                parts[1] = parts[1].Replace(" or ", "|").Replace("-", "|").Replace(" ", string.Empty);
                var numbers = parts[1]
                             .Split('|', StringSplitOptions.RemoveEmptyEntries)
                             .Select(s => Convert.ToInt32(s)).ToList();
                _fieldRanges[parts[0]] = new List<int>(Enumerable.Range(numbers[0], numbers[1] - numbers[0] + 1));
                _fieldRanges[parts[0]].AddRange(Enumerable.Range(numbers[2], numbers[3] - numbers[2] + 1));
            }

            _myTicket = data[1].ToLines()[1].ToTokens(new[] {','})
                                .Select(t => Convert.ToInt32(t)).ToList();

            _nearby = data[2].ToLines().Skip(1)
                                .Select
                                     (
                                      s => s.ToTokens(new[] {','})
                                            .Select(t => Convert.ToInt32(t)).ToList()
                                     ).ToList();
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            var allNumbers = new HashSet<int>();
            foreach (var rangesValue in _fieldRanges.Values)
            {
                allNumbers.UnionWith(rangesValue);
            }

            return _nearby
                  .Select(n1 => n1.Where(n2 => !allNumbers.Contains(n2)).Sum()).Sum()
                  .ToString();
        }

        public override string SolvePart2()
        {
            var allNumbers = new HashSet<int>();
            foreach (var rangesValue in _fieldRanges.Values)
            {
                allNumbers.UnionWith(rangesValue);
            }

            var fieldIndex = new Dictionary<string, int>();
            var tempFields = new Dictionary<string, List<int>>();
            foreach ((string key, var value) in _fieldRanges)
            {
                tempFields[key] = new List<int>(value);
            }
            
            var goodTickets = _nearby.Where(n1 => n1.All(n2 => allNumbers.Contains(n2))).ToList();

            while (tempFields.Count > 0)
            {
                for (var i = 0; i < _myTicket.Count; i++)
                {
                    if (fieldIndex.Values.Any(v => v == i))
                    {
                        continue;
                    }

                    int innerIndex = i;
                    var location = goodTickets.Select(t => t[innerIndex]);
                    var matches = tempFields.Where(f => location.All(n => f.Value.Contains(n))).ToList();

                    if (matches.Count != 1)
                    {
                        continue;
                    }
                    
                    string key = matches.First().Key;
                    fieldIndex[key] = i;
                    tempFields.Remove(key);
                }
            }

            long result = fieldIndex.Aggregate
                (
                 1L, (current, i) => i.Key.StartsWith("departure")
                                         ? current * _myTicket[i.Value]
                                         : current
                );
            return result.ToString();
        }
    }
}
