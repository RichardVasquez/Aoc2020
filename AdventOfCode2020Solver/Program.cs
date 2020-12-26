using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventOfCode2020Solver.Data;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers;

namespace AdventOfCode2020Solver
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var numbers = args.ToInts();
            if (numbers.Count == 0)
            {
                numbers = Enumerable.Range(SolverLookup.ProblemMin, SolverLookup.ProblemCount).ToList();
            }

            var s4 = SolverLookup.GetSolver(15);
            s4.Solve();

            var d1 = new Data01();
            
            Banner(numbers);
            Solve(numbers);
        }

        private static void Solve(List<int> numbers)
        {

            var s = SolverLookup.GetSolver(1);
            var k = 0;
        }

        /// <summary>
        /// Generate a basic header for any valid problems that have a solver.
        /// </summary>
        /// <param name="numbers">Numeric list of problems to solve.</param>
        private static void Banner(List<int> numbers)
        {
            var valid = numbers.Where(SolverLookup.HasSolver).ToList();

            if (valid.Count == 0)
            {
                Console.WriteLine("No matching values between input and available solvers.");
                Console.WriteLine($"\t({string.Join(',', numbers.Select(n => n.ToString()))})");
                return;
            }

            string problemTextEnd = (valid.Count == 1)
                                        ? string.Empty
                                        : "s";

            var sb = new StringBuilder();
            foreach (int i in valid)
            {
                sb.Append($"{i, 2}, ");
            }

            sb.Remove(sb.Length - 2, 2);
            var numberLists= new List<string>();
            while (sb.Length > 60)
            {
                numberLists.Add(sb.ToString().Substring(0, 60));
                sb.Remove(0, 60);
            }

            if (sb.Length > 0)
            {
                numberLists.Add(sb.ToString());
            }

            var text = new List<string>
                                {
                                    $"Solving {valid.Count} problem{problemTextEnd}"
                                };
            text.AddRange(numberLists);
            int bannerWidth = text.Select(t => t.Length).Max() + 10;
            Console.WriteLine(new string('-',bannerWidth));
            foreach (string s in text)
            {
                Console.WriteLine($"     {s}");
            }
            Console.WriteLine(new string('-',bannerWidth));
        }
    }
}
