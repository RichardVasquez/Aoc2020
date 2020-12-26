using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver13 : AbstractAocSolver, IAocSolver
    {
        private long _startTime;
        private List<string> _possibles;
        
        public Solver13(int n) : base(n) { }
        
        public override void Solve()
        {
            var data = ProblemData.Get().ToLines(true).ToList();
            _startTime = Convert.ToInt64(data[0]);
            _possibles = data[1].Split(',').ToList();
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
            var validId =
                (from possible in _possibles
                 where possible != "x"
                 select Convert.ToInt32(possible)).ToList();

            var timestamps = new Dictionary<int, int>();
            foreach (int i in validId)
            {
                timestamps[i] = (int) (_startTime / i * i);
            }

            bool allUnder = timestamps.All(timestamp => timestamp.Value < _startTime); 
            while (allUnder)
            {
                var keys = timestamps.Keys.ToList();
                foreach (int key in keys)
                {
                    timestamps[key] += key;
                }
                allUnder = timestamps.All(timestamp => timestamp.Value < _startTime);
            }

            int earliest = timestamps.Values.ToList().Min();
            int bus = timestamps.First(t => t.Value == earliest).Key;
            long minutes = earliest - _startTime;
	        
            return $"{bus*minutes}";
        }

        private string SolvePart2()
        {
            long time = 0;
            var increment = Convert.ToInt64(_possibles[0]);
            
            for (var i = 1; i < _possibles.Count; i++)
            {
                if (_possibles[i] == "x")
                {
                    continue;
                }
                var newTime = Convert.ToInt64(_possibles[i]);
                while (true)
                {
                    time += increment;
                    if ((time + i) % newTime != 0)
                    {
                        continue;
                    }
                    increment *= newTime;
                    break;
                }
            }

            return $"{time}";
        }
    }
}
