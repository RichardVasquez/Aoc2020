using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver22 : AbstractAocSolver
    {
        private List<string> _cardBlobs;
        
        public Solver22(int n) : base(n) { }

        public override void Solve()
        {
            _cardBlobs = ProblemData.Get().ToBlobs();

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            var playerCards = MakeHands();
            
            while (playerCards.All(q=>q.Count!=0))
            {
                int p1 = playerCards[0].Dequeue();
                int p2 = playerCards[1].Dequeue();

                if (p1 > p2)
                {
                    playerCards[0].Enqueue(p1);
                    playerCards[0].Enqueue(p2);
                }
                else
                {
                    playerCards[1].Enqueue(p2);
                    playerCards[1].Enqueue(p1);
                    
                }
            }

            var winner = playerCards[0];
            if (playerCards[0].Count == 0)
            {
                winner = playerCards[1];
            }

            var final = winner.ToList();
            int cardCount = final.Count;
            var total = 0;
            for (var i = 0; i < cardCount; i++)
            {
                total += (cardCount - i) * final[i];
            }
	        
            return $"{total}";
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.String")]
        public override string SolvePart2()
        {
            var playerCards = MakeHands();
            PlayRecursive(playerCards, 0);

            var winner = playerCards[0];
            if (playerCards[0].Count == 0)
            {
                winner = playerCards[1];
            }

            var final = winner.ToList();
            int cardCount = final.Count;
            var total = 0;
            for (var i = 0; i < cardCount; i++)
            {
                total += (cardCount - i) * final[i];
            }
            return $"{total}";
        }

        private static List<Queue<int>> PlayRecursive(List<Queue<int>> hands, int level)
        {
	        var prevRounds = new HashSet<string>();

	        while (hands.All(q => q.Count != 0))
	        {
		        if (level != 0)
		        {
			        var l1 = hands[0].ToList();
			        var l2 = hands[1].ToList();

			        string n1 = string.Join('.', l1.Select(l => l.ToString()));
			        string n2 = string.Join('.', l2.Select(l => l.ToString()));
			        var uniqueCheck = $"{n1}|{n2}";
			        if (prevRounds.Contains(uniqueCheck))
			        {
				        //p1 wins
				        var q1 = new Queue<int>();
				        q1.Enqueue(0);
				        return new List<Queue<int>> {q1, new Queue<int>()};
			        }

			        prevRounds.Add(uniqueCheck);
		        }

		        int p1 = hands[0].Dequeue();
		        int p2 = hands[1].Dequeue();

		        if (hands[0].Count >= p1 && hands[1].Count >= p2)
		        {
			        var recurseHand = new List<Queue<int>>();

			        var tempList1 = hands[0].ToList().Take(p1).ToList();
			        var tempList2 = hands[1].ToList().Take(p2).ToList();
			        var tempQ1 = new Queue<int>();
			        var tempQ2 = new Queue<int>();

			        foreach (int i in tempList1)
			        {
				        tempQ1.Enqueue(i);
			        }

			        foreach (int i in tempList2)
			        {
				        tempQ2.Enqueue(i);
			        }

			        recurseHand.AddRange(new[] {tempQ1, tempQ2});
			        var val = PlayRecursive(recurseHand, level + 1);

			        if (val[0].Count == 0)
			        {
				        hands[1].Enqueue(p2);
				        hands[1].Enqueue(p1);
			        }
			        else
			        {
				        hands[0].Enqueue(p1);
				        hands[0].Enqueue(p2);
			        }
		        }
		        else
		        {
			        if (p1 > p2)
			        {
				        hands[0].Enqueue(p1);
				        hands[0].Enqueue(p2);
			        }
			        else
			        {
				        hands[1].Enqueue(p2);
				        hands[1].Enqueue(p1);
				        
			        }
		        }
	        }

	        var winner = new Queue<int>();
	        winner.Enqueue(0);
	        var loser = new Queue<int>();

	        return hands[0].Count == 0
		               ? new List<Queue<int>> {loser, winner}
		               : new List<Queue<int>> {winner, loser};
        }

        private List<Queue<int>> MakeHands()
        {
            var playerCards = new List<Queue<int>>();

            foreach (string s in _cardBlobs)
            {
                string[] parts = s.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string[] numbers = parts[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var tempQueue = new Queue<int>();
                foreach (string number in numbers)
                {
                    tempQueue.Enqueue(Convert.ToInt32(number));
                }
                playerCards.Add(tempQueue);
            }

            return playerCards;
        }

    }
}
