using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver23: AbstractAocSolver
    {
        private string _cupList;
        public const int BigMoves = 1000000;
        
        public Solver23(int n) : base(n) { }

        public override void Solve()
        {
            var data = ProblemData.Get().ToLines();
            _cupList = data[0];

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            var (current, oneCup, map) = MakeCups(_cupList);

            Shuffle(current, 100, map, 9);
            return GetShuffledCups(oneCup);
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Collections.Generic.HashSet`1[System.Int32]")]
        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: Entry[System.Int32,AdventOfCode2020Solver.Solvers.Solver23+Cup][]")]
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Int32[]")]
        public override string SolvePart2()
        {
            var (current, oneCup, map) = MakeCups(_cupList, BigMoves - _cupList.Length);

            Shuffle(current, BigMoves, map, BigMoves);
            long result = Convert.ToInt64(oneCup.Next.Value) * Convert.ToInt64(oneCup.Next.Next.Value);
            return result.ToString();
        }

        private static string GetShuffledCups (Cup start)
        {
            var sb = new StringBuilder();
            var current = start.Next;
            do
            {
                sb.Append(current.Value);
                current = current.Next;
            } while (current != start);

            return sb.ToString();
        }
        
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Collections.Generic.HashSet`1[System.Int32]")]
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: Slot[System.Int32][]")]
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Int32[]")]
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH")]
        [SuppressMessage("ReSharper.DPA", "DPA0001: Memory allocation issues")]
        private static void Shuffle(Cup current, int moves, Dictionary<int, Cup> map, int max)
        {
            for (var i = 0; i < moves; i++)
            {
                var pickupStart = current.Next;
                var pickupEnd = pickupStart.Next.Next;
                var pickUpValues = new HashSet<int>
                                   {
                                       pickupStart.Value,
                                       pickupStart.Next.Value,
                                       pickupStart.Next.Next.Value
                                   };
                current.Next = pickupEnd.Next;

                int cupNextValue = current.Value;
                do
                {
                    cupNextValue--;
                    cupNextValue = cupNextValue == 0 ? max : cupNextValue;
                }
                while (pickUpValues.Contains(cupNextValue));
                
                var destination = map[cupNextValue];

                var tempNext = destination.Next;
                destination.Next = pickupStart;
                pickupEnd.Next = tempNext;

                current = current.Next;
            }
        }

        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: Entry[System.Int32,AdventOfCode2020Solver.Solvers.Solver23+Cup][]")]
        private static (Cup, Cup, Dictionary<int, Cup>) MakeCups(string input, int extras = 0)
        {
            var map = new Dictionary<int, Cup>();
            char[] chars = input.ToCharArray();
            var start = new Cup { Value = int.Parse(chars[0].ToString()) };
            map.Add(start.Value, start);
            var current = start;
            Cup oneCup = null;

            for (var i = 1; i < chars.Length; i++)
            {
                var cup = new Cup { Value = int.Parse(chars[i].ToString()) };
                map.Add(cup.Value, cup);

                if (cup.Value == 1) oneCup = cup;
                current.Next = cup;
                current = cup;
            }

            var value = 10;
            for (var i = 0; i < extras; i++)
            {
                var cup = new Cup { Value = value };
                map.Add(cup.Value, cup);
                current.Next = cup;
                current = cup;
                value++;
            }
            //link end -> start
            current.Next = start;

            //reset current to start to begin
            current = start;
            return (current, oneCup, map);
        }

        private class Cup
        {
            public Cup Next { get; set; }
            public int Value { get; set; }
        }
    }
}
