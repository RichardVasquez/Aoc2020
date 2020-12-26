using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AdventOfCode2020Solver.Data;
using AdventOfCode2020Solver.Internal;

namespace AdventOfCode2020Solver.Solvers
{
    public static class SolverLookup
    {
        private static readonly Dictionary<int, Type> ProblemLookup =
            new Dictionary<int, Type>
            {
                {1, typeof(Solver01)},
                {2, typeof(Solver02)}
            };

        private static readonly Dictionary<int, Type> DataLookup =
            new Dictionary<int, Type>
            {
                {1, typeof(Data01)}
            };

        public static int ProblemMin => ProblemLookup.Keys.Min();
        public static int ProblemMax => ProblemLookup.Keys.Min();
        public static int ProblemCount => ProblemLookup.Keys.Count;
        
        public static bool HasSolver(int index)
        {
            if (!ProblemLookup.ContainsKey(index))
            {
                return false;
            }

            return (ProblemLookup[index] != null) & HasData(index);
        }

        private static bool HasData(int index)
        {
            if (!DataLookup.ContainsKey(index))
            {
                return false;
            }

            return DataLookup[index] != null;
        }

        private static IData GetData(int index)
        {
            return HasData(index)
                       ? (IData) Activator.CreateInstance(DataLookup[index])
                       : null;
        }
            
        
        public static IAocSolver GetSolver(int index)
        {
            if (!HasSolver(index) || !HasData(index))
            {
                return null;
            }

            var data = GetData(index);
            var solver = (IAocSolver) Activator
               .CreateInstance
                    (
                     ProblemLookup[index],
                     index
                    );
            solver.AddData(data);
            return solver;
        }
    }
}
