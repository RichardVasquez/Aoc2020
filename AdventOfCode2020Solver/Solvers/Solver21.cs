using System.Collections.Generic;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;
using System.Linq;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver21 : AbstractAocSolver
    {
        private List<string> _allergenData;
        private Dictionary<string, List<string>> _risky; 

        public Solver21(int n) : base(n) { }

        public override void Solve()
        {
            _allergenData = ProblemData.Get().ToLines(true);
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            var seps = new[] {' ', ',', '(', ')'};
            var breakdown = _allergenData.Select(
                                                (f, i) => (
                                                              food: i,
                                                              ingredients: f.Split().TakeWhile(a => a != "(contains").ToArray(),
                                                              alergens:
                                                              f.ToTokens(seps)
                                                               .SkipWhile(c => c != "contains").Skip(1).ToArray())).ToList();

            var byAllergen = breakdown
                            .SelectMany(f => f.alergens.Select(a => (a, f)))
                            .ToLookup(a => a.a, a => a.f);

            _risky = new Dictionary<string, List<string>>();
            foreach (var tuples in byAllergen)
            {
                var value = tuples.Skip(1)
                                  .Aggregate
                                       (
                                        tuples.First().ingredients.AsEnumerable(),
                                        (i, g2) => i.Intersect(g2.ingredients)
                                       );

                _risky[tuples.Key] = value.ToList();
            }

            var allRisky = _risky.SelectMany(r => r.Value).Distinct().ToHashSet();
            var safe = breakdown.SelectMany(f => f.ingredients).Where(i => !allRisky.Contains(i));

            return $"Part 1: {safe.Count()}";
        }

        public override string SolvePart2()
        {
            while (_risky.Any(r => r.Value.Count > 1))
            {
                var visited = new HashSet<string>();
                while (_risky.Any(r => r.Value.Count == 1 && !visited.Contains(r.Key)))
                {
                    var single = _risky.First(g => !visited.Contains(g.Key) && g.Value.Count == 1);
                    foreach (var s in _risky.Where(r => r.Value.Count() > 1))
                    {
                        _risky[s.Key].Remove(single.Key);
                    }
                    visited.Add(single.Key);
                }
                visited.Clear();
                while (_risky.Any(r => r.Value.Count() > 1 && !visited.Contains(r.Key)))
                {
                    (string key, var value) = _risky.First(g => !visited.Contains(g.Key));
                    var ingredients = value.Where(a => _risky.Count(r => r.Value.Contains(a)) == 1).ToList();
                    if (ingredients.Any())
                    {
                        _risky[key] = ingredients.ToList();
                        if (ingredients.Count() == 1)
                        {
                            foreach (var s in _risky.Where(r => r.Value.Count() > 1))
                            {
                                _risky[s.Key].Remove(ingredients.First());
                            }
                        }
                    }

                    visited.Add(key);
                }
            }

            return  string.Join(",", _risky.OrderBy(k => k.Key).Select(a => a.Value.First()));
        }

    }
}
