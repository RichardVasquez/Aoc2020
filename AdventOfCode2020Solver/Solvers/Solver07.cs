using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    
    public class Solver07 : AbstractAocSolver
    {
        private List<Bag> _bags;

        public Solver07(int n) : base(n) { }

        public override void Solve()
        {
            var data = ProblemData.Get().ToLines(true);
            //	Clean up English to data
            for (var i = 0; i < data.Count; i++)
            {
                string s = data[i].Replace(" bags contain ", "|").Replace("no other ", "0 ")
                                  .Replace(" bag, ", ":").Replace(" bags, ", ":")
                                  .Replace(" bags.", "").Replace(" bag.", "");
                data[i] = s;
            }
            //	Create the list of bags
            _bags = data.Select(s => new Bag(s)).ToList();

            //	Establish the graph
            foreach (var bag in _bags)
            {
                var r = bag.References;
                foreach (string s in r)
                {
                    string[] pieces = s.Split(' ');
                    var total = Convert.ToInt32(pieces[0]);
                    string name = string.Join(" ", pieces.ToList()
                                                         .Skip(1)
                                                         .Take(pieces.Length - 1)
                                                         .ToArray());

                    var targetBag = _bags.Find(b => b.Name == name);
                    if (total != 0)
                    {
                        bag.AddContents(total, targetBag);
                    }

                    targetBag?.AddContainer(bag);
                }
            }
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            var node = _bags.Find(n => n.Name == "shiny gold");

            //	Create pools of bags we're going to examine - prevent duplicates
            //	What we're looking at now
            var examinePool = new HashSet<Bag>();
            //	Unique bags we've already looked at
            var donePool = new HashSet<Bag>();

            //	Fresh set. These are the ones we're going to start with.
            if (node != null)
            {
                foreach (var bag in node.Contained)
                {
                    examinePool.Add(bag);
                }
            }

            while (examinePool.Count > 0)
            {
                //	Because you don't adjust iterable contents 
                var tempList = examinePool.ToList();
                foreach (var bag in tempList)
                {
                    //	throw the current bag into ones we know we're counting
                    donePool.Add(bag);
                    //	Add bags that can contain this bag to be examined as well.
                    examinePool.UnionWith(bag.Contained);
                    //	Remove this bag from consideration in the next iteration
                    examinePool.Remove(bag);
                }
            }

            return donePool.Count.ToString();
        }

        public override string SolvePart2()
        {
            var node = _bags.Find(n => n.Name == "shiny gold");
            return node != null
                       ? node.CountInside().ToString()
                       : "-1";
        }

        public class Bag
        {
            public readonly string Name;
            private readonly Dictionary<Bag, int> _contains;
            public readonly List<string> References;
            public readonly List<Bag> Contained;

            public Bag(string s)
            {
                string[] parts = s.Split('|');
                Name = parts[0];

                _contains = new Dictionary<Bag, int>();
                Contained = new List<Bag>();
                string[] contains = parts[1].Split(':');
                References = contains.ToList();
            }

            public void AddContainer(Bag b)
            {
                Contained.Add(b);
            }

            public void AddContents(int amount, Bag b)
            {
                _contains[b] = amount;
            }

            public int CountInside()
            {
                //	Sum the quantity of each color bag,
                //	plus multiply the quantity of each color bag with how many bags it has to contain. 
		    
                return _contains.Values.ToList().Sum() +
                       _contains.Where(c => c.Value > 0)
                                .Sum(contain => contain.Value * contain.Key.CountInside());
            }
        }
    }
}
