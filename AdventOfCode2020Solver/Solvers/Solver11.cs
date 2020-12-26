using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventOfCode.Library;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver11 : AbstractAocSolver, IAocSolver
    {
        
        private static readonly List<Coordinate> Offsets =
            new List<Coordinate>
            {
                new Coordinate(-1, -1),
                new Coordinate(-1, 0),
                new Coordinate(-1, 1),
                new Coordinate(0, -1),
                new Coordinate(0, 1),
                new Coordinate(1, -1),
                new Coordinate(1, 0),
                new Coordinate(1, 1)
            };

        public List<string> BaseSeats;

        public Solver11(int n) : base(n) { }

        public override void Solve()
        {
            var data = ProblemData.Get().ToLines(true);

            //  Pad the initial data with empty seats around the perimeter
            int width = data[0].Length;
            data.Insert(0, new string('.', width));
            data.Add(new string('.', width));
            for (var i = 0; i < data.Count; i++)
            {
                data[i] = $".{data[i]}.";
            }

            BaseSeats = new List<string>(data);
            
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
	        int oldCount;
	        var newCount = 0;

	        var solverBaseSeats = new List<string>(BaseSeats);
	        do
	        {
		        oldCount = newCount;
		        var nextGen = ProcessSeats(solverBaseSeats);
		        newCount = CountOccupied(nextGen);
		        solverBaseSeats = nextGen.ToList();
	        } while (oldCount != newCount);
	        
	        return $"{newCount}";

        }

        private string SolvePart2()
        {
	        int oldCount;
	        var newCount = 0;

	        var solverBaseSeats = new List<string>(BaseSeats);
	        do
	        {
		        oldCount = newCount;
		        var nextGen = ProcessSeats2(solverBaseSeats);
		        newCount = CountOccupied(nextGen);
		        solverBaseSeats = nextGen.ToList();
	        } while (oldCount != newCount);
	        
	        return $"{newCount}";
        }
        
        private static int CountOccupied(List<string> seats)
        {
	        return seats.Sum(seat => seat.Count(s => s == '#'));
        }

        private static List<string> ProcessSeats(IReadOnlyList<string> seats)
        {
	        var result = seats.ToList();

	        int width = seats[0].Length - 1;
	        int height = seats.Count - 1;

	        for (var y = 1; y <= height; y++)
	        {
		        var sbRow = new StringBuilder(result[y]);
		        for (var x = 1; x <= width; x++)
		        {
			        sbRow[x] = seats[y][x] switch
			        {
				        'L' => Offsets.Select
				                       (
				                        o => seats[y + o.Y][x + o.X] == '#'
					                             ? 1
					                             : 0
				                       )
				                      .Sum() == 0
					               ? '#'
					               : 'L',
				        '#' => Offsets.Select
				                       (
				                        o => seats[y + o.Y][x + o.X] == '#'
					                             ? 1
					                             : 0
				                       )
				                      .Sum() >= 4
					               ? 'L'
					               : '#',
				        _ => sbRow[x]
			        };
		        }

		        result[y] = sbRow.ToString();
	        }

	        return result;
        }

        private static char FindSeat(List<string> seats, int x, int y, Coordinate direction)
        {
	        if (seats == null)
	        {
		        throw new ArgumentNullException(nameof(seats));
	        }
	        int width = seats[0].Length - 1;
	        int height = seats.Count - 1;

	        while (true)
	        {
		        x += direction.X;
		        y += direction.Y;
		        if (x == 0 || y == 0 || x > width || y > height)
		        {
			        return '.';	// we moved out of seats
		        }

		        char here = seats[y][x];
		        if (here == '#' || here == 'L')
		        {
			        return here;
		        }
	        }
        }

        private static List<string> ProcessSeats2(List<string> seats)
        {
	        var result = seats.ToList();

	        int width = seats[0].Length - 1;
	        int height = seats.Count - 1;

	        for (var y = 1; y <= height; y++)
	        {
		        var sbRow = new StringBuilder(result[y]);
		        for (var x = 1; x <= width; x++)
		        {
			        sbRow[x] = seats[y][x] switch
			        {
				        'L' => Offsets.Select
				                       (
				                        o => FindSeat(seats, x, y, o) == '#'
					                             ? 1
					                             : 0
				                       )
				                      .Sum() == 0
					               ? '#'
					               : 'L',
				        '#' => Offsets.Select
				                       (
				                        o => FindSeat(seats, x, y, o) == '#'
					                             ? 1
					                             : 0
				                       )
				                      .Sum() >= 5
					               ? 'L'
					               : '#',
				        _ => sbRow[x]
			        };
		        }

		        result[y] = sbRow.ToString();
	        }

	        return result;
        }

    }
}
