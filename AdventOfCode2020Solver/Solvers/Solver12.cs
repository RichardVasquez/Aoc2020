using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Library;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
	public class Solver12 : AbstractAocSolver
	{
		private List<string> _movements;

		public Solver12(int n) : base(n) { }

		public override void Solve()
		{
			_movements = ProblemData.Get().ToLines(true).ToList();
			
			SolveOnce(SolvePart1);
			SolveOnce(SolvePart2);
		}

		public override string SolvePart1()
		{
			var ship = new Ship();
			foreach (string cmd in _movements)
			{
				ship.Move(cmd);
			}
	        
			return $"{ship.Manhattan}";
		}

		public override string SolvePart2()
		{
			var ship = new Ship2();
			foreach (string cmd in _movements)
			{
				ship.Move(cmd);
			}
	        
			return $"{ship.Manhattan}";
		}

		private class Ship
		{
			private Headings _heading;
			private int _x;
			private int _y;

			public int Manhattan => Math.Abs(_x) + Math.Abs(_y);

			private readonly Dictionary<Headings, List<Headings>> _leftRotate =
				new Dictionary<Headings, List<Headings>>
				{
					{Headings.North, new List<Headings> {Headings.North, Headings.West, Headings.South, Headings.East}},
					{Headings.West, new List<Headings> {Headings.West, Headings.South, Headings.East, Headings.North}},
					{Headings.South, new List<Headings> {Headings.South, Headings.East, Headings.North, Headings.West}},
					{Headings.East, new List<Headings> {Headings.East, Headings.North, Headings.West, Headings.South}}
				};

			private readonly Dictionary<Headings, List<Headings>> _rightRotate =
				new Dictionary<Headings, List<Headings>>
				{
					{Headings.North, new List<Headings> {Headings.North, Headings.East, Headings.South, Headings.West}},
					{Headings.East, new List<Headings> {Headings.East, Headings.South, Headings.West, Headings.North}},
					{Headings.South, new List<Headings> {Headings.South, Headings.West, Headings.North, Headings.East}},
					{Headings.West, new List<Headings> {Headings.West, Headings.North, Headings.East, Headings.South}}
				};

			private readonly Dictionary<Headings, Coordinate> _myVectors =
				new Dictionary<Headings, Coordinate>
				{
					{Headings.North, new Coordinate(0, 1)},
					{Headings.South, new Coordinate(0, -1)},
					{Headings.East, new Coordinate(1, 0)},
					{Headings.West, new Coordinate(-1, 0)},
				};

			public Ship()
			{
				_x = 0;
				_y = 0;
				_heading = Headings.East;
			}

			public void Move(string instruction)
			{
				char operation = instruction[0];
				var number = Convert.ToInt32(instruction.Substring(1));

				switch (operation)
				{
					case 'N':
						_y += number;
						break;
					case 'S':
						_y -= number;
						break;
					case 'E':
						_x += number;
						break;
					case 'W':
						_x -= number;
						break;
					case 'L':
						_heading = RotateLeft(number);
						break;
					case 'R':
						_heading = RotateRight(number);
						break;
					case 'F':
						MoveForward(number);
						break;
				}
			}

			private void MoveForward(int number)
			{
				var entry = _myVectors[_heading];
				_x += number * entry.X;
				_y += number * entry.Y;
			}

			private Headings RotateRight(int number)
			{
				while (number < 0)
				{
					number += 360;
				}

				number %= 360;
				number /= 90;

				return _rightRotate[_heading][number];
			}

			private Headings RotateLeft(int number)
			{
				while (number < 0)
				{
					number += 360;
				}

				number %= 360;
				number /= 90;

				return _leftRotate[_heading][number];
			}
		}

		private class Ship2
		{
			private Coordinate _location;
			private Coordinate _waypoint;

			public int Manhattan => Math.Abs(_location.X) + Math.Abs(_location.Y);


			public Ship2()
			{
				_location = new Coordinate(0, 0);
				_waypoint = new Coordinate(10, 1);
			}

			public void Move(string instruction)
			{
				char operation = instruction[0];
				var number = Convert.ToInt32(instruction.Substring(1));

				switch (operation)
				{
					case 'N':
						_waypoint = new Coordinate(_waypoint.X, _waypoint.Y + number);
						break;
					case 'S':
						_waypoint = new Coordinate(_waypoint.X, _waypoint.Y - number);
						break;
					case 'E':
						_waypoint = new Coordinate(_waypoint.X+number, _waypoint.Y);
						break;
					case 'W':
						_waypoint = new Coordinate(_waypoint.X-number, _waypoint.Y);
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
				}
			}

			private void MoveForward(int number)
			{
				int distX = _waypoint.X - _location.X;
				int distY = _waypoint.Y - _location.Y;

				_location = new Coordinate(_location.X + distX * number, _location.Y + distY * number);
				_waypoint = new Coordinate(_location.X + distX, _location.Y + distY);
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
				int distX = _waypoint.X - _location.X;
				int distY = _waypoint.Y - _location.Y;

				_waypoint = number switch
				{
					3 => new Coordinate(_location.X - distY, _location.Y + distX),
					2 => new Coordinate(_location.X - distX, _location.Y - distY),
					1 => new Coordinate(_location.X + distY, _location.Y - distX),
					_ => _waypoint
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
				int distX = _waypoint.X - _location.X;
				int distY = _waypoint.Y - _location.Y;

				_waypoint = number switch
				{
					1 => new Coordinate(_location.X - distY, _location.Y + distX),
					2 => new Coordinate(_location.X - distX, _location.Y - distY),
					3 => new Coordinate(_location.X + distY, _location.Y - distX),
					_ => _waypoint
				};
			}
		}

		private enum Headings
		{
			North,
			East,
			South,
			West
		}
	}
}
