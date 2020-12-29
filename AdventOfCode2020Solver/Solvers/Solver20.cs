using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver20 : AbstractAocSolver
    {
        private List<Tile> _tiles;
        private Tile[][] _assembled;

        public Solver20(int n) : base(n) { }

        public override void Solve()
        {
            var data = ProblemData.Get().ToBlobs(false);
            _tiles = data.Select(d => new Tile(d)).ToList();
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            _assembled = AssemblePuzzle();
            
            long result = _assembled[0][0].Id *
                          _assembled[0].Last().Id *
                          _assembled.Last()[0].Id *
                          _assembled.Last().Last().Id;
            
            return $"{result}";
        }

        public override string SolvePart2()
        {
            var image = MergeTiles();
            var monster = new[]
                          {
                              "                  # ",
                              "#    ##    ##    ###",
                              " #  #  #  #  #  #   "
                          };

            while (true)
            {
                int monsterCount = MatchCount(image, monster);
                if (monsterCount > 0) 
                {
                    int hashCountInImage = image.ToString().Count(ch => ch == '#');
                    int hashCountInMonster = string.Join("\n", monster).Count(ch => ch == '#');
                    return (hashCountInImage - monsterCount * hashCountInMonster).ToString();
                }
                image.Rotate();
            }
        }
        
        private Tile[][] AssemblePuzzle()
        {
            var pairs = new Dictionary<string, List<Tile>>();
            foreach (var tile in _tiles)
            {
                for (var i = 0; i < 8; i++)
                {
                    string pattern = tile.Top();
                    if (!pairs.ContainsKey(pattern))
                    {
                        pairs[pattern] = new List<Tile>();
                    }
                    pairs[pattern].Add(tile);
                    tile.Rotate();
                }
            }

            var size = (int) Math.Sqrt(_tiles.Count);
            var puzzle = new Tile[size][];
            for (var row = 0; row < size; row++)
            {
                puzzle[row] = new Tile[size];
                for (var col = 0; col < size; col++)
                {
                    var above = row == 0
                                    ? null
                                    : puzzle[row - 1][col];
                    var left = col == 0
                                   ? null
                                   : puzzle[row][col - 1];
                    puzzle[row][col] = PutTileInPlace(above, left, pairs);
                }
            }
            return puzzle;
        }

        private Tile PutTileInPlace(Tile above, Tile left, Dictionary<string, List<Tile>> pairs)
        {
            if (above == null && left == null)
            {
                foreach (var tile in _tiles)
                {
                    for (var i = 0; i < 8; i++)
                    {
                        if (IsEdge(tile.Top(), pairs) && IsEdge(tile.Left(), pairs))
                        {
                            return tile;
                        }

                        tile.Rotate();
                    }
                }
            }
            else
            {
                var tile = above != null
                               ? GetNeighbour(above, above.Bottom(), pairs)
                               : GetNeighbour(left, left.Right(), pairs);
                while (true)
                {
                    bool topMatch = above == null
                                        ? IsEdge(tile.Top(), pairs)
                                        : tile.Top() == above.Bottom();
                    bool leftMatch = left == null
                                         ? IsEdge(tile.Left(), pairs)
                                         : tile.Left() == left.Right();

                    if (topMatch && leftMatch)
                    {
                        return tile;
                    }

                    tile.Rotate();
                }
            }

            return null;
        }

        private static Tile GetNeighbour(Tile tile, string pattern, Dictionary<string, List<Tile>> pairs)
        {
            return pairs[pattern].SingleOrDefault(other => other != tile);
        }

        private static bool IsEdge(string pattern, Dictionary<string, List<Tile>> pairs) =>
            pairs[pattern].Count == 1;

        private Tile MergeTiles()
        {
            // create a big tile leaving out the borders
            var image = new List<string>();
            int tileSize = _assembled[0][0].Size;
            int tileCount = _assembled.Length;
            for (var row = 0; row < tileCount; row++)
            {
                for (var i = 1; i < tileSize - 1; i++)
                {
                    var st = "";
                    for (var col = 0; col < tileCount; col++)
                    {
                        st += _assembled[row][col].Row(i).Substring(1, tileSize - 2);
                    }
                    image.Add(st);
                }
            }
            return new Tile(42, image);
        }

        private static int MatchCount(Tile image, params string[] pattern)
        {
            var res = 0;
            (int col, int row) = (pattern[0].Length, pattern.Length);
            for (var imageRow = 0; imageRow < image.Size - row; imageRow++)
            {
                for (var imageCol = 0; imageCol < image.Size - col; imageCol++)
                {
                    bool Match()
                    {
                        for (var colP = 0; colP < col; colP++)
                            for (var rowP = 0; rowP < row; rowP++)
                            {
                                if (pattern[rowP][colP] == '#' && image[imageRow + rowP, imageCol + colP] != '#')
                                {
                                    {
                                        return false;
                                    }
                                }
                            }

                        return true;
                    }

                    if (Match())
                    {
                        res++;
                    }
                }
            }

            return res;
        }

        private class Tile
        {
            public readonly long Id;
            public readonly int Size;
            private readonly List<string> _grid;
            private int _orientation;

            public Tile(string info)
            {
                var lines = info.ToLines();
                int len = lines[0].Length;
                Id = Convert.ToInt32(new string(lines[0].Skip(5).Take(len - 6).ToArray()));
                _grid = new List<string>(lines.Skip(1).Take(lines.Count - 1).ToList());
                Size = _grid.Count;
            }
            
            public Tile(long id, IReadOnlyCollection<string> grid)
            {
                Id = id;
                _grid = new List<string>(grid);
                Size = grid.Count;
                _orientation = 0;
            }

            public void Rotate() {
                _orientation++;
            }

            public char this[int y, int x] {
                get
                {
                    for (var i = 0; i < _orientation % 4; i++)
                    {
                        (y, x) = (x, Size - 1 - y); // rotate
                    }

                    if (_orientation % 8 >= 4)
                    {
                        x = Size - 1 - x; // flip vertical axis
                    }

                    return _grid[y][x];
                }
            }

            public string Row(int y) => GetSlice(y, 0, 0, 1);
            private string Column(int x) => GetSlice(0, x, 1, 0);
            public string Top() => Row(0);
            public string Bottom() => Row(Size - 1);
            public string Left() => Column(0);
            public string Right() => Column(Size - 1);

            public override string ToString()
            {
                return $"Tile {Id}:\n" + string.Join("\n", Enumerable.Range(0, Size).Select(Row));
            }

            private string GetSlice(int y1, int x1, int y2, int x2)
            {
                var result = "";
                for (var i = 0; i < Size; i++) {
                    result += this[y1, x1];
                    y1 += y2;
                    x1 += x2;
                }
                return result;
            }
        }
    }
}
