using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver17 : AbstractAocSolver
    {
	    private List<string> _grid;
        
        public Solver17(int n) : base(n) { }

        public override void Solve()
        {
            _grid = ProblemData.Get().ToLines(true).ToList();
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
	        int width = _grid[0].Length;
	        int height = _grid.Count;

	        int dimensions = Math.Max(width, height) + 15;

	        var baseGrid = new char[dimensions, dimensions, dimensions];
	        var newGrid = new char[dimensions, dimensions, dimensions];
	        for (var z = 0; z < dimensions; z++)
	        {
		        for (var y = 0; y < dimensions; y++)
		        {
			        for (var x = 0; x < dimensions; x++)
			        {
				        baseGrid[x, y, z] = '.';
				        newGrid[x, y, z] = '.';
			        }
		        }
	        }

	        int center = dimensions / 2;

	        for (var y = 0; y < _grid.Count; y++)
	        {
		        for (var x = 0; x < _grid[0].Length; x++)
		        {
			        baseGrid[center - width / 2 + x, center - height / 2 + y, center] = _grid[y][x];
		        }
	        }

	        int cube = dimensions * dimensions * dimensions;
	        
	        for (var turn = 1; turn <= 6; turn++)
	        {
		        for (var cubeIdx = 0; cubeIdx < cube; cubeIdx++)
		        {
			        int cubeX = cubeIdx % dimensions;
			        int cubeY = cubeIdx / dimensions % dimensions;
			        int cubeZ = cubeIdx / (dimensions * dimensions) % dimensions;

			        if (cubeX == 0 || cubeY == 0 || cubeZ == 0 ||
			            cubeX == dimensions - 1 ||
			            cubeY == dimensions - 1 ||
			            cubeZ == dimensions - 1)
			        {
				        continue;
			        }

			        var neighbors = 0;
			        char current = baseGrid[cubeX, cubeY, cubeZ];
			        for (var idx = 0; idx < 27; idx++)
			        {
				        int zLoc = idx / 9 % 3 - 1;
				        int yLoc = idx / 3 % 3 - 1;
				        int xLoc = idx % 3 - 1;
				        if (xLoc != 0 || yLoc != 0 || zLoc != 0)
				        {
					        neighbors += baseGrid[cubeX + xLoc, cubeY + yLoc, cubeZ + zLoc] == '#'
						                     ? 1
						                     : 0;
				        }
			        }

			        char newCell = current switch
			        {
				        '#' => (neighbors == 2 || neighbors == 3)
					               ? '#'
					               : '.',
				        '.' => (neighbors == 3)
					               ? '#'
					               : '.',
				        _ => '.'
			        };

			        newGrid[cubeX, cubeY, cubeZ] = newCell;
		        }
		        
		        //copy back to base and loop
		        for (var cubeIdx = 0; cubeIdx < cube; cubeIdx++)
		        {
			        int cubeX = cubeIdx % dimensions;
			        int cubeY = cubeIdx / dimensions % dimensions;
			        int cubeZ = cubeIdx / (dimensions * dimensions) % dimensions;

			        baseGrid[cubeX, cubeY, cubeZ] = newGrid[cubeX, cubeY, cubeZ];
		        }
	        }

	        var total = 0;
	        for (var cubeIdx = 0; cubeIdx < cube; cubeIdx++)
	        {
		        int cubeX = cubeIdx % dimensions;
		        int cubeY = cubeIdx / dimensions % dimensions;
		        int cubeZ = cubeIdx / (dimensions * dimensions) % dimensions;

		        if (baseGrid[cubeX, cubeY, cubeZ] == '#')
		        {
			        total++;
		        }
	        }
	        
			return $"{total}";
        }

        public override string SolvePart2()
        {
	        int width = _grid[0].Length;
	        int height = _grid.Count;

	        int dimensions = Math.Max(width, height) + 15;

	        var baseGrid = new char[dimensions, dimensions, dimensions, dimensions];
	        var newGrid = new char[dimensions, dimensions, dimensions, dimensions];
	        for (var z = 0; z < dimensions; z++)
	        {
		        for (var y = 0; y < dimensions; y++)
		        {
			        for (var x = 0; x < dimensions; x++)
			        {
				        for (var w = 0; w < dimensions; w++)
				        {
					        baseGrid[x, y, z, w] = '.';
					        newGrid[x, y, z, w] = '.';
				        }
			        }
		        }
	        }

	        int center = dimensions / 2;

	        for (var y = 0; y < _grid.Count; y++)
	        {
		        for (var x = 0; x < _grid[0].Length; x++)
		        {
			        baseGrid[center - width / 2 + x, center - height / 2 + y, center, center] = _grid[y][x];
		        }
	        }

	        var hypercube = dimensions * dimensions * dimensions * dimensions;

	        for (var turn = 1; turn <= 6; turn++)
	        {
		        for (var cubeIdx = 0; cubeIdx < hypercube; cubeIdx++)
		        {
			        var cubeX = cubeIdx % dimensions;
			        var cubeY = cubeIdx / dimensions % dimensions;
			        var cubeZ = cubeIdx / (dimensions * dimensions) % dimensions;
			        var cubeW = cubeIdx / (dimensions * dimensions * dimensions) % dimensions;

			        if (cubeX == 0 || cubeY == 0 || cubeZ == 0 || cubeW == 0 ||
			            cubeX == dimensions - 1 ||
			            cubeY == dimensions - 1 ||
			            cubeZ == dimensions - 1 ||
			            cubeW == dimensions - 1)
			        {
				        continue;
			        }

			        var neighbors = 0;
			        var current = baseGrid[cubeX, cubeY, cubeZ, cubeW];
			        for (var idx = 0; idx < 81; idx++)
			        {
				        var wLoc = idx / 27 % 3 - 1;
				        var zLoc = idx / 9 % 3 - 1;
				        var yLoc = idx / 3 % 3 - 1;
				        var xLoc = idx % 3 - 1;
				        if (xLoc != 0 || yLoc != 0 || zLoc != 0 || wLoc != 0)
				        {
					        neighbors += baseGrid[cubeX + xLoc, cubeY + yLoc, cubeZ + zLoc, cubeW + wLoc] == '#'
						                     ? 1
						                     : 0;
				        }
			        }

			        char newCell = current switch
			        {
				        '#' => (neighbors == 2 || neighbors == 3)
					               ? '#'
					               : '.',
				        '.' => (neighbors == 3)
					               ? '#'
					               : '.',
				        _ => '.'
			        };

			        newGrid[cubeX, cubeY, cubeZ, cubeW] = newCell;
		        }

		        //copy back to base and loop
		        for (var cubeIdx = 0; cubeIdx < hypercube; cubeIdx++)
		        {
			        var cubeX = cubeIdx % dimensions;
			        var cubeY = cubeIdx / dimensions % dimensions;
			        var cubeZ = cubeIdx / (dimensions * dimensions) % dimensions;
			        var cubeW = cubeIdx / (dimensions * dimensions * dimensions) % dimensions;

			        baseGrid[cubeX, cubeY, cubeZ, cubeW] = newGrid[cubeX, cubeY, cubeZ, cubeW];
		        }
	        }

	        var total = 0;
	        for (var cubeIdx = 0; cubeIdx < hypercube; cubeIdx++)
	        {
		        var cubeX = cubeIdx % dimensions;
		        var cubeY = cubeIdx / dimensions % dimensions;
		        var cubeZ = cubeIdx / (dimensions * dimensions) % dimensions;
		        var cubeW = cubeIdx / (dimensions * dimensions * dimensions) % dimensions;

		        if (baseGrid[cubeX, cubeY, cubeZ, cubeW] == '#')
		        {
			        total++;
		        }
	        }

	        //3227 too high
	        return $"{total}";
        }

    }
}
