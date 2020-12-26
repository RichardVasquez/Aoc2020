using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Library;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver04 : AbstractAocSolver
    {
        private List<string> _passportData;

        private static readonly List<string> Fields =
            new List<string> {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid", "cid"};

        private static readonly List<string> EyeColors =
            new List<string> {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};
        
        public Solver04(int i) : base(i) { }
        public override void Solve()
        {
            _passportData = ProblemData.Get().ToBlobs();
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
            var validFields = new List<string>(Fields).Where(f => f != "cid");

            var total = 0;
            foreach (string line in _passportData)
            {
                var tempFields = new List<string>(validFields);
                var data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string key in data
                                      .Select(s => new string(s.Take(3).ToArray()))
                                      .Where(key => tempFields.Contains(key)))
                {
                    tempFields.Remove(key);
                }

                total += tempFields.Count == 0
                             ? 1
                             : 0;

            }
            return $"{total}";
        }

        private string SolvePart2()
        {
            var validFields = new List<string>(Fields).Where(f => f != "cid");

            var total = 0;
            foreach (string passport in _passportData)
            {
                var data = passport.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .ToList().Where(s => !s.StartsWith("cid")).ToList();

                var fieldCheck = new List<string>(validFields);

                foreach (string s in data)
                {
                    string[] checkParts = s.Split(':');
                    bool passCheck = checkParts[0] switch
                    {
                        "byr" => CheckByr(checkParts[1]),
                        "iyr" => CheckIyr(checkParts[1]),
                        "eyr" => CheckEyr(checkParts[1]),
                        "hgt" => CheckHgt(checkParts[1]),
                        "hcl" => CheckHcl(checkParts[1]),
                        "ecl" => CheckEcl(checkParts[1]),
                        "pid" => CheckPid(checkParts[1]),
                        _ => false
                    };
                    if (passCheck)
                    {
                        fieldCheck.Remove(checkParts[0]);
                    }
                }

                if (fieldCheck.Count == 0)
                {
                    total++;
                }
            }
            
            return $"{total}";
        }
        
        private static bool CheckByr(string s)
        {
            bool goodLength1 = s.Length == 4;
            bool goodYear1 = int.TryParse(s, out int testInt1);
            return goodLength1 && goodYear1 && testInt1 >= 1902 && testInt1 <= 2002;
        }

        private static bool CheckIyr(string s)
        {
            bool goodLength2 = s.Length == 4;
            bool goodYear2 = int.TryParse(s, out int testInt2);
            return goodLength2 && goodYear2 && testInt2 >= 2010 && testInt2 <= 2020;
        }

        private static bool CheckEyr(string s)
        {
            bool goodLength3 = s.Length == 4;
            bool goodYear3 = int.TryParse(s, out int testInt3);
            return goodLength3 && goodYear3 && testInt3 >= 2020 && testInt3 <= 2030;
        }

        private static bool CheckHgt(string s)
        {
            if (!s.EndsWith("cm") && !s.EndsWith("in"))
            {
                return false;
            }

            string meas = s.Substring(s.Length - 2);
            string num = s.Substring(0, s.Length - 2);
            switch (meas)
            {
                case "in":
                    bool goodMeas1 = int.TryParse(num, out int testInt4);
                    if (goodMeas1 && testInt4 >= 59 && testInt4 <= 76)
                    {
                        return true;
                    }
                    break;
                case "cm":
                    bool goodMeas2 = int.TryParse(num, out int testInt5);
                    if (goodMeas2 && testInt5 >= 150 && testInt5 <= 193)
                    {
                        return true;
                    }
                    break;
            }

            return false;
        }

        private static bool CheckHcl(string s)
        {
            if (string.IsNullOrEmpty(s) || s[0] != '#')
            {
                return false;
            }

            const string hex = "0123456789abcdef";
            int hc = s.Skip(1).Take(6).Count(c => hex.Contains(c));
            return hc == 6;
        }

        private static bool CheckEcl(string s)
        {
            return EyeColors.Contains(s);
        }

        private static bool CheckPid(string s)
        {
            const string digits = "0123456789";
            int dc = s.Count(c => digits.Contains(c));
            return dc == 9;
        }
    }
}
