using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver14 : AbstractAocSolver
    {
        private List<string> _data;
        private readonly Dictionary<long, long> _memory = new Dictionary<long, long>();
        
        public Solver14(int n) : base(n) { }

        public override void Solve()
        {
            _data = ProblemData.Get().ToLines(true).ToList();
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            _memory.Clear();
            var mask = new string('X', 36);
            long maskAnd = MakeAndMask(mask);
            long maskOr = MakeOrMask(mask);

            foreach (var parts in _data.Select
                (s => s.Split('=', StringSplitOptions.RemoveEmptyEntries)
                       .ToList().Select(s2 => s2.Trim()).ToList())
                )
            {
                if (parts[0] == "mask")
                {
                    mask = parts[1];
                    maskAnd = MakeAndMask(mask);
                    maskOr = MakeOrMask(mask);
                }

                if (parts[0].StartsWith("mem"))
                {
                    ModifyMemory(parts[0], parts[1], maskAnd, maskOr);
                }
            }

            long total = _memory.Sum(l => l.Value);

            return $"{total}";        }

        public override string SolvePart2()
        {
            _memory.Clear();
            var mask = new string('0', 36);

            foreach (var parts in _data.Select
                (
                 s => s.Split('=', StringSplitOptions.RemoveEmptyEntries)
                       .ToList().Select(s2 => s2.Trim()).ToList()
                ))
            {
                if (parts[0] == "mask")
                {
                    mask = parts[1];
                }

                if (parts[0].StartsWith("mem"))
                {
                    ModifyAddressedMemory(parts[0], parts[1], mask);
                }
            }

            long total = _memory.Sum(l => l.Value);

            return $"{total}";
        }

        private  void ModifyMemory(string part, string s, in long maskAnd, in long maskOr)
        {
            string[] parts = part.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
            var address = Convert.ToInt64(parts[1]);
            long value = (Convert.ToInt64(s) & maskAnd) | maskOr;

            _memory[address] = value;
        }
        private  void ModifyAddressedMemory(string part, string s, string mask)
        {
	        string[] parts = part.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
	        var address = Convert.ToInt64(parts[1]);
	        var value = Convert.ToInt64(s);

	        var newAddresses = MakeAddresses(mask, address);

	        foreach (long tempAddress in newAddresses.Select(newAddress => Convert.ToInt64(newAddress, 2)))
	        {
		        _memory[tempAddress] = value;
	        }
        }

        private  List<string> MakeAddresses(string mask, long baseAddress)
        {
            int bits = mask.Count(c => c == 'X');
            double max = Math.Pow(2, bits);

            string baseBinary = Make36(baseAddress);
            var results = new List<string>();
				
            for (var i = 0; i < max; i++)
            {
                string bitmask = Convert.ToString(i, 2).PadLeft(bits, '0');
                results.Add(MixAddressMask(mask, bitmask, baseBinary));					
            }

            return results;
        }

        private  string MixAddressMask(string mask, string bitmask, string baseBinary)
        {
            var idx = 0;
            var sb = new StringBuilder();
            for (var i = 0; i < mask.Length; i++)
            {
                switch (mask[i])
                {
                    case '0':
                        sb.Append(baseBinary[i]);
                        break;
                    case '1':
                        sb.Append('1');
                        break;
                    case 'X':
                        sb.Append(bitmask[idx++]);
                        break;
                }
            }

            return sb.ToString();
        }

        private  string Make36(long number)
        {
            return Convert.ToString(number, 2).PadLeft(36, '0');
        }

        private  long MakeOrMask(string s)
        {
            s = s.Replace('X', '0'); // should keep 1s
            return Convert.ToInt64(s, 2);
        }

        private  long MakeAndMask(string s)
        {
            s = s.Replace('X', '1'); // should keep 0s
            return Convert.ToInt64(s, 2);
        }
    }
}
