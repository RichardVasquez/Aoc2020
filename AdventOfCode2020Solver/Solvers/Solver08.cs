using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver08 : AbstractAocSolver, IAocSolver
    {
        public List<Instruction> BaseInstructions; 
        public Solver08(int n) : base(n) { }

        public override void Solve()
        {
            BaseInstructions = ProblemData.Get().ToLines(true)
                                          .Select(k => new Instruction(k)).ToList();
            
            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
            
            Console.WriteLine(SolvePart1());
            Console.WriteLine(SolvePart2());
        }

        private string SolvePart1()
        {
            var game = new Machine(BaseInstructions);
            game.Run();
            return $"{game.Accumulator}";
        }

        private string SolvePart2()
        {
            var accumulator = 0;
            for (var i = 0; i < BaseInstructions.Count; i++)
            {
                var edited = new List<Instruction>(BaseInstructions)
                             {
                                 [i] = SwapInstruction(BaseInstructions[i])
                             };

                var game = new Machine(edited);
                game.Run();

                if (!game.Error || game.ProgramIndex != game.OpCount)
                {
                    continue;
                }
                accumulator = game.Accumulator;
                break;
            }

            return $"{accumulator}";
        }
        
        private static Instruction SwapInstruction(Instruction i)
        {
            return i.Operation switch
            {
                OpCode.Jmp => new Instruction(OpCode.Nop, i.Value),
                OpCode.Nop => new Instruction(OpCode.Jmp, i.Value),
                _ => i
            };
        }


        public struct Instruction
        {
            public OpCode Operation;
            public int Value;
        
            private const int OpWidth = 3;

            public Instruction(OpCode op, int val) : this()
            {
                Operation = op;
                Value = val;
            }
            public Instruction(string s) : this()
            {
                var parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int mul = parts[1][0] switch
                {
                    '+' => 1,
                    '-' => -1,
                    _ => 0
                };

                Value = mul * Convert.ToInt32(parts[1].Substring(1));

                Operation = parts[0] switch
                {
                    "acc" => OpCode.Acc,
                    "jmp" => OpCode.Jmp,
                    "nop" => OpCode.Nop,
                    _ => OpCode.Nul
                };
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append(Operation.ToString().ToUpper().PadRight(OpWidth))
                  .Append(' ')
                  .Append
                       (
                        Value < 0
                            ? ""
                            : "+"
                       )
                  .Append(Value);

                return sb.ToString();
            }
        }
        public class Machine
        {
            public int Accumulator;
            public int ProgramIndex;
            public bool Error;
            public int? Answer;
            public bool LoopingHalt;
            public int OpCount => _instructions.Count;

            private List<Instruction> _instructions;

            public Instruction this[int i]
            {
                get => _instructions[i];
                set => _instructions[i] = value;
            }

            public Machine(IEnumerable<Instruction> instructions)
            {
                _instructions = instructions.ToList();
                Accumulator = 0;
                ProgramIndex = 0;
                Answer = null;
                Error = false;
                LoopingHalt = false;
            }

            public void Run()
            {
                if (Error)
                {
                    return;
                }

                try
                {
                    var visited = new HashSet<int>();

                    while (!LoopingHalt)
                    {
                        switch (_instructions[ProgramIndex].Operation)
                        {
                            case OpCode.Nop:
                                OpNop();
                                break;
                            case OpCode.Acc:
                                OpAcc(_instructions[ProgramIndex]);
                                break;
                            case OpCode.Jmp:
                                OpJmp(_instructions[ProgramIndex]);
                                break;
                        }

                        if (visited.Contains(ProgramIndex))
                        {
                            Answer = Accumulator;
                            LoopingHalt = true;
                            break;
                        }

                        visited.Add(ProgramIndex);
                    }
                }
                catch
                {
                    Error = true;
                }
            }
		
            private void OpNop()
            {
                ProgramIndex++;
            }

            private void OpAcc(Instruction i)
            {
                Accumulator += i.Value;
                ProgramIndex++;
            }

            private void OpJmp(Instruction i)
            {
                ProgramIndex += i.Value;
            }
        }        
        
        public enum OpCode
        {
            Nul = 0,
            Acc = 1,
            Jmp = 2,
            Nop = 3
        }

    }
}
