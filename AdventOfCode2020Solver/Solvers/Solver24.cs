using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver24 : AbstractAocSolver
    {
        private readonly Dictionary<string, HexVector> _directionHexVectors =
            new Dictionary<string, HexVector>
            {
                {"e", new HexVector(1, 0, -1)},
                {"se", new HexVector(0, 1, -1)},
                {"sw", new HexVector(-1, 1, 0)},
                {"w", new HexVector(-1, 0, 1)},
                {"nw", new HexVector(0, -1, 1)},
                {"ne", new HexVector(1, -1, 0)}
            };

        private List<string> _movements;
        private readonly Dictionary<HexVector, int> _baseMap = new Dictionary<HexVector, int>();

        public Solver24(int n) : base(n) { }

        public override void Solve()
        {
            _movements = ProblemData.Get().ToLines(true);
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            MakeBaseMap();
            return _baseMap.Values.Sum().ToString();
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Int32")]
        public override string SolvePart2()
        {
            if (_baseMap.Count == 0)
            {
                MakeBaseMap();
            }

            var localBaseMap = new Dictionary<HexVector, int>();
            foreach (var i in _baseMap.Where(i => i.Value == 1))
            {
                localBaseMap[i.Key] = i.Value;
            }

            var newTotal = 0;
            for (int i = 0; i < 100; i++)
            {
                // find the black tiles that might change state
                var blackTiles = localBaseMap.Keys.Where(k => localBaseMap[k] == 1).ToList();

                // find all white neighbors of existing black tiles.
                var whiteTiles = new HashSet<HexVector>();
                foreach (
                    var newNeighbor in blackTiles
                       .SelectMany
                            (
                             tempTile => _directionHexVectors
                                        .Select(hexVector => tempTile + hexVector.Value)
                                        .Where
                                             (
                                              newNeighbor => !localBaseMap.ContainsKey(newNeighbor) ||
                                                             localBaseMap.ContainsKey(newNeighbor) &&
                                                             localBaseMap[newNeighbor] == 0
                                             )
                            ))
                {
                    whiteTiles.Add(newNeighbor);
                }

                var newTileMap = new Dictionary<HexVector, int>();
                foreach (var hexVector in blackTiles)
                {
                    int result = GetNewCell(1, hexVector, localBaseMap);
                    newTileMap[hexVector] = result;
                }

                foreach (var hexVector in whiteTiles)
                {
                    int result = GetNewCell(0, hexVector, localBaseMap);
                    newTileMap[hexVector] = result;
                }

                localBaseMap.Clear();
                foreach (var ntm in newTileMap)
                {
                    localBaseMap[ntm.Key] = ntm.Value;
                }
				
                newTotal = newTileMap.Values.Sum();
            }

            return $"{newTotal}";
        }
        
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.Int32")]
        private int GetNewCell(int hexState, HexVector hexVector, Dictionary<HexVector, int> checkMap)
        {
	        if (hexState == 0)
	        {
		        int total = _directionHexVectors
                           .Values.Select(neighbor => hexVector + neighbor)
                           .Where(checkMap.ContainsKey)
                           .Sum(newNeighbor => checkMap[newNeighbor]);

                // we're white, check for black
		        bool whiteState = total == 2;
		        return whiteState
			               ? 1	//	now will be black
			               : 0;	// stay white
	        }

	        int totalBlack = _directionHexVectors.Values
                                                .Select(neighbor => hexVector + neighbor)
                                                .Where(checkMap.ContainsKey)
                                                .Sum(newNeighbor => checkMap[newNeighbor]);

            bool flipToWhite = (totalBlack == 0 || totalBlack >= 3);
	        return flipToWhite
		               ? 0	//	stay black
		               : 1;	// flip white
        }

        private void MakeBaseMap()
        {
            _baseMap.Clear();
            foreach (string tile in _movements)
            {
                var idx = 0;
                var baseHex = new HexVector(0, 0, 0);
                var direction = "";

                while (idx < tile.Length)
                {
                    direction += tile[idx++];
                    if (!_directionHexVectors.ContainsKey(direction))
                    {
                        continue;
                    }
                    baseHex += _directionHexVectors[direction];
                    direction = "";
                }

                if (!_baseMap.ContainsKey(baseHex))
                {
                    _baseMap[baseHex] = 0;
                }

                _baseMap[baseHex] = 1 - _baseMap[baseHex];
            }
        }
        
        [DebuggerDisplay("{I} {J} {K}")]
        public readonly struct HexVector
        {
            public readonly int I;
            public readonly int J;
            public readonly int K;

            public HexVector(int i, int j, int k)
            {
                I = i;
                J = j;
                K = k;
            }

            public static HexVector operator +(HexVector hv1, HexVector hv2)
            {
                return new HexVector(hv1.I + hv2.I, hv1.J + hv2.J, hv1.K + hv2.K);
            }

            public override int GetHashCode()
            {
                return Tuple.Create(I, J, K).GetHashCode();
            }

            public override string ToString()
            {
                return $"I: {I}\tJ: {J}\tK: {K}";
            }
        }
    }
}
