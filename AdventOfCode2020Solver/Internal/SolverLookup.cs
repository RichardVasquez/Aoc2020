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
                {17, typeof(Solver17)},
                {18, typeof(Solver18)},
                {19, typeof(Solver19)},
                {20, typeof(Solver20)},
                {21, typeof(Solver21)},
                {22, typeof(Solver22)},
                {23, typeof(Solver23)},
                {24, typeof(Solver24)},
                {25, typeof(Solver25)},
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
                {17, typeof(Data17)},
                {18, typeof(Data18)},
                {19, typeof(Data19)},
                {20, typeof(Data20)},
                {21, typeof(Data21)},
                {22, typeof(Data22)},
                {23, typeof(Data23)},
                {24, typeof(Data24)},
                {25, typeof(Data25)},
            };

        private static readonly Dictionary<int, string> Title =
            new Dictionary<int, string>
            {
                {1, "Report Repair"},
                {2, "Password Philosophy"},
                {3, "Toboggan Trajectory"},
                {4, "Passport Processing"},
                {5, "Binary Boarding"},
                {6, "Custom Customs"},
                {7, "Handy Haversacks"},
                {8, "Handheld Halting"},
                {9, "Encoding Error"},
                {10, "Adapter Array"},
                {11, "Seating System"},
                {12, "Rain Risk"},
                {13, "Shuttle Search"},
                {14, "Docking Data"},
                {15, "Rambunctious Recitation"},
                {16, "Ticket Translation"},
                {17, "Conway Cubes"},
                {18, "Operation Order"},
                {19, "Monster Messages"},
                {20, "Jurassic Jigsaw"},
                {21, "Allergen Assessment"},
                {22, "Crab Combat"},
                {23, "Crab Cups"},
                {24, "Lobby Layout"},
                {25, "Combo Breaker"}
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
            solver.SetTitle(Title[index]);
            return solver;
        }
    }
}
