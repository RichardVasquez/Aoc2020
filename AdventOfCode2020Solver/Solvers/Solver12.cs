using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Library;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
	public class Solver12 : AbstractAocSolver, IAocSolver
	{
		public List<string> Movements;
		public Solver12(int n) : base(n) { }

		public override void Solve()
		{
			Movements = ProblemData.Get().ToLines(true).ToList();
			
			SolveOnce(SolvePart1);
			SolveOnce(SolvePart2);

			Console.WriteLine(SolvePart1());
			Console.WriteLine(SolvePart2());
		}

		private string SolvePart1()
		{
			var ship = new Ship();
			foreach (string cmd in Movements)
			{
				ship.Move(cmd);
			}
	        
			return $"{ship.Manhattan}";
		}

		private string SolvePart2()
		{
			var ship = new Ship2();
			foreach (string cmd in Movements)
			{
				ship.Move(cmd);
			}
	        
			return $"{ship.Manhattan}";
		}

		public class Ship
		{
			public Headings Heading;
			public int X;
			public int Y;

			public int Manhattan => Math.Abs(X) + Math.Abs(Y);

			public Dictionary<Headings, List<Headings>> LeftRotate =
				new Dictionary<Headings, List<Headings>>
				{
					{Headings.North, new List<Headings> {Headings.North, Headings.West, Headings.South, Headings.East}},
					{Headings.West, new List<Headings> {Headings.West, Headings.South, Headings.East, Headings.North}},
					{Headings.South, new List<Headings> {Headings.South, Headings.East, Headings.North, Headings.West}},
					{Headings.East, new List<Headings> {Headings.East, Headings.North, Headings.West, Headings.South}}
				};

			public Dictionary<Headings, List<Headings>> RightRotate =
				new Dictionary<Headings, List<Headings>>
				{
					{Headings.North, new List<Headings> {Headings.North, Headings.East, Headings.South, Headings.West}},
					{Headings.East, new List<Headings> {Headings.East, Headings.South, Headings.West, Headings.North}},
					{Headings.South, new List<Headings> {Headings.South, Headings.West, Headings.North, Headings.East}},
					{Headings.West, new List<Headings> {Headings.West, Headings.North, Headings.East, Headings.South}}
				};

			public Dictionary<Headings, Coordinate> MyVectors =
				new Dictionary<Headings, Coordinate>
				{
					{Headings.North, new Coordinate(0, 1)},
					{Headings.South, new Coordinate(0, -1)},
					{Headings.East, new Coordinate(1, 0)},
					{Headings.West, new Coordinate(-1, 0)},
				};

			public Ship()
			{
				X = 0;
				Y = 0;
				Heading = Headings.East;
			}

			public void Move(string instruction)
			{
				char operation = instruction[0];
				var number = Convert.ToInt32(instruction.Substring(1));

				switch (operation)
				{
					case 'N':
						Y += number;
						break;
					case 'S':
						Y -= number;
						break;
					case 'E':
						X += number;
						break;
					case 'W':
						X -= number;
						break;
					case 'L':
						Heading = RotateLeft(number);
						break;
					case 'R':
						Heading = RotateRight(number);
						break;
					case 'F':
						MoveForward(number);
						break;
				}
			}

			private void MoveForward(int number)
			{
				var entry = MyVectors[Heading];
				X += number * entry.X;
				Y += number * entry.Y;
			}

			private Headings RotateRight(int number)
			{
				while (number < 0)
				{
					number += 360;
				}

				number %= 360;
				number /= 90;

				return RightRotate[Heading][number];
			}

			private Headings RotateLeft(int number)
			{
				while (number < 0)
				{
					number += 360;
				}

				number %= 360;
				number /= 90;

				return LeftRotate[Heading][number];
			}
		}


		public class Ship2
		{
			private Headings Heading;

			private Coordinate Location;
			private Coordinate Waypoint;

			public int Manhattan => Math.Abs(Location.X) + Math.Abs(Location.Y);

			public Dictionary<Headings, List<Headings>> LeftRotate =
				new Dictionary<Headings, List<Headings>>
				{
					{Headings.North, new List<Headings> {Headings.North, Headings.West, Headings.South, Headings.East}},
					{Headings.West, new List<Headings> {Headings.West, Headings.South, Headings.East, Headings.North}},
					{Headings.South, new List<Headings> {Headings.South, Headings.East, Headings.North, Headings.West}},
					{Headings.East, new List<Headings> {Headings.East, Headings.North, Headings.West, Headings.South}}
				};

			public Dictionary<Headings, List<Headings>> RightRotate =
				new Dictionary<Headings, List<Headings>>
				{
					{Headings.North, new List<Headings> {Headings.North, Headings.East, Headings.South, Headings.West}},
					{Headings.East, new List<Headings> {Headings.East, Headings.South, Headings.West, Headings.North}},
					{Headings.South, new List<Headings> {Headings.South, Headings.West, Headings.North, Headings.East}},
					{Headings.West, new List<Headings> {Headings.West, Headings.North, Headings.East, Headings.South}}
				};

			public Dictionary<Headings, Coordinate> MyVectors =
				new Dictionary<Headings, Coordinate>
				{
					{Headings.North, new Coordinate(0, 1)},
					{Headings.South, new Coordinate(0, -1)},
					{Headings.East, new Coordinate(1, 0)},
					{Headings.West, new Coordinate(-1, 0)},
				};

			public Ship2()
			{
				Location = new Coordinate(0, 0);
				Waypoint = new Coordinate(10, 1);

				Heading = Headings.East;
			}

			public void Move(string instruction)
			{
				char operation = instruction[0];
				var number = Convert.ToInt32(instruction.Substring(1));

				switch (operation)
				{
					case 'N':
						Waypoint = new Coordinate(Waypoint.X, Waypoint.Y + number);
						break;
					case 'S':
						Waypoint = new Coordinate(Waypoint.X, Waypoint.Y - number);
						break;
					case 'E':
						Waypoint = new Coordinate(Waypoint.X+number, Waypoint.Y);
						break;
					case 'W':
						Waypoint = new Coordinate(Waypoint.X-number, Waypoint.Y);
						break;
					case 'L':
						RotateLeft(number);
						break;
					case 'R':
						RotateRight(number);
						break;
					case 'F':
						MoveForward(number);
						break;
					default:
						break;
				}
			}

			private void MoveForward(int number)
			{
				var distX = Waypoint.X - Location.X;
				var distY = Waypoint.Y - Location.Y;

				Location = new Coordinate(Location.X + distX * number, Location.Y + distY * number);
				Waypoint = new Coordinate(Location.X + distX, Location.Y + distY);
			}

			private void RotateRight(int number)
			{
				while (number < 0)
				{
					number += 360;
				}

				number %= 360;
				number /= 90;

				//	offsets from ship as origin
				int distX = Waypoint.X - Location.X;
				int distY = Waypoint.Y - Location.Y;

				Waypoint = number switch
				{
					3 => new Coordinate(Location.X - distY, Location.Y + distX),
					2 => new Coordinate(Location.X - distX, Location.Y - distY),
					1 => new Coordinate(Location.X + distY, Location.Y - distX),
					_ => Waypoint
				};
			}

			private void RotateLeft(int number)
			{
				while (number < 0)
				{
					number += 360;
				}

				number %= 360;
				number /= 90;

				//	offsets from ship as origin
				int distX = Waypoint.X - Location.X;
				int distY = Waypoint.Y - Location.Y;

				Waypoint = number switch
				{
					1 => new Coordinate(Location.X - distY, Location.Y + distX),
					2 => new Coordinate(Location.X - distX, Location.Y - distY),
					3 => new Coordinate(Location.X + distY, Location.Y - distX),
					_ => Waypoint
				};
			}
		}

		public enum Headings
		{
			North,
			East,
			South,
			West
		}
	}
}
