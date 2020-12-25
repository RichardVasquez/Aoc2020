using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Solvers
{
    public static class SolverLookup
    {
        private static readonly Dictionary<int, Type> Lookup =
            new Dictionary<int, Type>
            {
                {1, typeof(Solver01)},
                {2, typeof(Solver02)}
            };

        public static int Min => Lookup.Keys.Min();
        public static int Max => Lookup.Keys.Min();
        public static int Count => Lookup.Keys.Count;
        
        public static bool HasSolver(int index)
        {
            if (!Lookup.ContainsKey(index))
            {
                return false;
            }

            return Lookup[index] != null;
        }
        
        public static IAocSolver GetSolver(int index)
        {
            return HasSolver(index)
                       ? (IAocSolver) Activator.CreateInstance(Lookup[index], index) 
                       : null;
        }
    }
}
