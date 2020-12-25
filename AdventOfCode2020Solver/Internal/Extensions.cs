using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020Solver.Internal
{
    public static class Extensions
    {
        public static List<int> ToInts(this IEnumerable<string> values, bool unique = true, bool sorted = true)
        {
            var result = new List<int>();

            foreach (string value in values)
            {
                if (int.TryParse(value, out int converted))
                {
                    result.Add(converted);
                }
            }

            if (unique)
            {
                var temp = new HashSet<int>();
                foreach (var value in result)
                {
                    temp.Add(value);
                }

                result = temp.ToList();
            }

            if (sorted)
            {
                result.Sort();
            }

            return result;
        }
    }
}
