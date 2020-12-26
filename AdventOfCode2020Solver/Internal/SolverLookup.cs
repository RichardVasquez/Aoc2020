using System;
using System.Collections.Generic;
using System.Linq;
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
                {2, typeof(Solver02)},
                {3, typeof(Solver03)},
                {4, typeof(Solver04)},
                {5, typeof(Solver05)},
                {6, typeof(Solver06)},
                {7, typeof(Solver07)},
                {8, typeof(Solver08)},
                {9, typeof(Solver09)},
                {10, typeof(Solver10)},
                {11, typeof(Solver11)},
                {12, typeof(Solver12)},
                {13, typeof(Solver13)},
                {14, typeof(Solver14)},
                {15, typeof(Solver15)},
                {16, typeof(Solver16)},
            };

        private static readonly Dictionary<int, Type> DataLookup =
            new Dictionary<int, Type>
            {
                {1, typeof(Data01)},
                {2, typeof(Data02)},
                {3, typeof(Data03)},
                {4, typeof(Data04)},
                {5, typeof(Data05)},
                {6, typeof(Data06)},
                {7, typeof(Data07)},
                {8, typeof(Data08)},
                {9, typeof(Data09)},
                {10, typeof(Data10)},
                {11, typeof(Data11)},
                {12, typeof(Data12)},
                {13, typeof(Data13)},
                {14, typeof(Data14)},
                {15, typeof(Data15)},
                {16, typeof(Data16)},
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
