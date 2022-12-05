using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Move
    {
        public int Count { get; set; }
        public Stack From { get; set; }
        public Stack To { get; set; }

        public static Move ToMove(string input)
        {
            var moves = input.Split(" ");
            return new Move()
            {
                Count = int.Parse(moves[1]),
                From = (Stack)Enum.Parse(typeof(Stack), moves[3]),
                To = (Stack)Enum.Parse(typeof(Stack), moves[5])
            };
        }
    }
}
