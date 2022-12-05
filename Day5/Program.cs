﻿using Day5;

string input = "move 7 from 6 to 8\r\nmove 5 from 2 to 6\r\nmove 2 from 4 to 1\r\nmove 1 from 4 to 5\r\nmove 5 from 7 to 6\r\nmove 7 from 6 to 3\r\nmove 5 from 9 to 2\r\nmove 6 from 2 to 3\r\nmove 2 from 7 to 9\r\nmove 20 from 3 to 1\r\nmove 11 from 1 to 6\r\nmove 1 from 9 to 8\r\nmove 3 from 8 to 2\r\nmove 8 from 1 to 5\r\nmove 10 from 8 to 4\r\nmove 7 from 6 to 4\r\nmove 1 from 8 to 3\r\nmove 8 from 1 to 7\r\nmove 16 from 4 to 8\r\nmove 1 from 9 to 8\r\nmove 1 from 5 to 2\r\nmove 4 from 7 to 4\r\nmove 5 from 6 to 7\r\nmove 1 from 6 to 1\r\nmove 8 from 7 to 4\r\nmove 1 from 6 to 9\r\nmove 12 from 4 to 5\r\nmove 3 from 2 to 5\r\nmove 1 from 6 to 2\r\nmove 1 from 3 to 7\r\nmove 1 from 3 to 2\r\nmove 1 from 9 to 3\r\nmove 1 from 7 to 8\r\nmove 1 from 7 to 5\r\nmove 1 from 3 to 2\r\nmove 4 from 5 to 7\r\nmove 5 from 5 to 7\r\nmove 1 from 4 to 3\r\nmove 1 from 3 to 9\r\nmove 3 from 1 to 8\r\nmove 1 from 9 to 1\r\nmove 2 from 2 to 1\r\nmove 2 from 2 to 7\r\nmove 8 from 8 to 1\r\nmove 3 from 5 to 2\r\nmove 8 from 7 to 5\r\nmove 7 from 1 to 3\r\nmove 3 from 1 to 7\r\nmove 1 from 1 to 5\r\nmove 1 from 3 to 7\r\nmove 7 from 5 to 8\r\nmove 2 from 2 to 8\r\nmove 1 from 3 to 2\r\nmove 1 from 2 to 4\r\nmove 1 from 4 to 8\r\nmove 13 from 8 to 1\r\nmove 13 from 5 to 9\r\nmove 2 from 5 to 2\r\nmove 7 from 9 to 3\r\nmove 12 from 8 to 3\r\nmove 4 from 9 to 3\r\nmove 1 from 3 to 4\r\nmove 2 from 2 to 3\r\nmove 1 from 1 to 6\r\nmove 1 from 2 to 3\r\nmove 1 from 5 to 9\r\nmove 7 from 7 to 4\r\nmove 10 from 1 to 8\r\nmove 1 from 1 to 4\r\nmove 1 from 9 to 5\r\nmove 2 from 5 to 1\r\nmove 1 from 6 to 5\r\nmove 3 from 8 to 9\r\nmove 5 from 4 to 3\r\nmove 4 from 4 to 1\r\nmove 7 from 1 to 6\r\nmove 2 from 5 to 7\r\nmove 35 from 3 to 4\r\nmove 4 from 9 to 1\r\nmove 19 from 4 to 8\r\nmove 1 from 7 to 6\r\nmove 1 from 9 to 2\r\nmove 10 from 4 to 5\r\nmove 2 from 4 to 7\r\nmove 3 from 4 to 3\r\nmove 1 from 2 to 8\r\nmove 1 from 1 to 9\r\nmove 3 from 3 to 6\r\nmove 4 from 8 to 6\r\nmove 4 from 5 to 2\r\nmove 2 from 8 to 3\r\nmove 3 from 5 to 9\r\nmove 12 from 6 to 1\r\nmove 8 from 8 to 6\r\nmove 2 from 9 to 1\r\nmove 1 from 4 to 1\r\nmove 1 from 3 to 8\r\nmove 3 from 7 to 8\r\nmove 2 from 9 to 7\r\nmove 1 from 6 to 7\r\nmove 10 from 6 to 8\r\nmove 4 from 2 to 5\r\nmove 1 from 3 to 7\r\nmove 7 from 5 to 7\r\nmove 13 from 8 to 1\r\nmove 29 from 1 to 4\r\nmove 8 from 7 to 8\r\nmove 1 from 1 to 3\r\nmove 3 from 7 to 6\r\nmove 1 from 1 to 9\r\nmove 15 from 4 to 1\r\nmove 1 from 3 to 6\r\nmove 10 from 1 to 6\r\nmove 10 from 6 to 7\r\nmove 1 from 4 to 9\r\nmove 1 from 9 to 1\r\nmove 1 from 9 to 7\r\nmove 6 from 7 to 8\r\nmove 1 from 1 to 6\r\nmove 5 from 6 to 5\r\nmove 21 from 8 to 9\r\nmove 5 from 1 to 9\r\nmove 2 from 9 to 5\r\nmove 3 from 5 to 6\r\nmove 3 from 7 to 9\r\nmove 4 from 4 to 6\r\nmove 6 from 8 to 7\r\nmove 6 from 6 to 3\r\nmove 2 from 7 to 9\r\nmove 1 from 7 to 2\r\nmove 6 from 3 to 2\r\nmove 1 from 6 to 4\r\nmove 4 from 5 to 9\r\nmove 1 from 4 to 5\r\nmove 9 from 4 to 6\r\nmove 7 from 6 to 4\r\nmove 10 from 9 to 2\r\nmove 5 from 7 to 5\r\nmove 10 from 2 to 7\r\nmove 2 from 5 to 4\r\nmove 2 from 5 to 9\r\nmove 4 from 9 to 4\r\nmove 1 from 8 to 6\r\nmove 7 from 7 to 2\r\nmove 1 from 5 to 4\r\nmove 2 from 7 to 1\r\nmove 1 from 5 to 7\r\nmove 3 from 6 to 2\r\nmove 4 from 4 to 5\r\nmove 1 from 2 to 7\r\nmove 10 from 4 to 7\r\nmove 3 from 7 to 3\r\nmove 17 from 9 to 4\r\nmove 1 from 1 to 4\r\nmove 1 from 1 to 5\r\nmove 5 from 2 to 7\r\nmove 1 from 9 to 2\r\nmove 5 from 4 to 8\r\nmove 2 from 9 to 7\r\nmove 4 from 8 to 1\r\nmove 3 from 4 to 8\r\nmove 1 from 2 to 5\r\nmove 1 from 9 to 2\r\nmove 6 from 4 to 8\r\nmove 3 from 7 to 5\r\nmove 1 from 4 to 9\r\nmove 1 from 9 to 1\r\nmove 3 from 1 to 9\r\nmove 4 from 8 to 5\r\nmove 2 from 9 to 8\r\nmove 4 from 2 to 5\r\nmove 8 from 7 to 2\r\nmove 5 from 8 to 5\r\nmove 2 from 7 to 8\r\nmove 1 from 3 to 5\r\nmove 1 from 1 to 2\r\nmove 1 from 1 to 6\r\nmove 2 from 3 to 6\r\nmove 5 from 2 to 8\r\nmove 4 from 7 to 1\r\nmove 7 from 8 to 5\r\nmove 1 from 1 to 5\r\nmove 3 from 8 to 3\r\nmove 1 from 9 to 3\r\nmove 7 from 2 to 3\r\nmove 2 from 2 to 8\r\nmove 2 from 4 to 8\r\nmove 1 from 8 to 5\r\nmove 1 from 1 to 4\r\nmove 2 from 4 to 7\r\nmove 2 from 7 to 1\r\nmove 3 from 2 to 3\r\nmove 3 from 5 to 2\r\nmove 1 from 8 to 3\r\nmove 3 from 3 to 2\r\nmove 5 from 2 to 1\r\nmove 17 from 5 to 8\r\nmove 9 from 8 to 1\r\nmove 11 from 3 to 5\r\nmove 8 from 8 to 5\r\nmove 2 from 8 to 5\r\nmove 16 from 1 to 4\r\nmove 13 from 4 to 7\r\nmove 6 from 5 to 2\r\nmove 2 from 4 to 8\r\nmove 5 from 7 to 9\r\nmove 2 from 1 to 2\r\nmove 7 from 7 to 1\r\nmove 1 from 1 to 4\r\nmove 1 from 9 to 8\r\nmove 7 from 2 to 8\r\nmove 1 from 4 to 7\r\nmove 2 from 9 to 4\r\nmove 1 from 4 to 1\r\nmove 1 from 3 to 5\r\nmove 2 from 9 to 8\r\nmove 11 from 8 to 7\r\nmove 2 from 6 to 5\r\nmove 1 from 6 to 9\r\nmove 1 from 1 to 9\r\nmove 1 from 9 to 1\r\nmove 4 from 1 to 4\r\nmove 2 from 1 to 8\r\nmove 1 from 1 to 2\r\nmove 1 from 9 to 5\r\nmove 2 from 4 to 3\r\nmove 2 from 2 to 7\r\nmove 2 from 3 to 9\r\nmove 1 from 9 to 1\r\nmove 1 from 9 to 1\r\nmove 5 from 5 to 1\r\nmove 19 from 5 to 6\r\nmove 5 from 1 to 4\r\nmove 1 from 2 to 9\r\nmove 1 from 1 to 3\r\nmove 7 from 5 to 8\r\nmove 1 from 3 to 6\r\nmove 8 from 7 to 3\r\nmove 7 from 4 to 8\r\nmove 3 from 8 to 5\r\nmove 1 from 4 to 1\r\nmove 1 from 9 to 4\r\nmove 1 from 4 to 9\r\nmove 1 from 5 to 2\r\nmove 2 from 5 to 6\r\nmove 2 from 8 to 2\r\nmove 7 from 8 to 1\r\nmove 1 from 1 to 7\r\nmove 3 from 6 to 9\r\nmove 2 from 3 to 2\r\nmove 1 from 2 to 1\r\nmove 1 from 8 to 7\r\nmove 2 from 9 to 6\r\nmove 2 from 9 to 5\r\nmove 1 from 5 to 6\r\nmove 1 from 2 to 8\r\nmove 2 from 1 to 7\r\nmove 1 from 4 to 3\r\nmove 3 from 2 to 5\r\nmove 7 from 1 to 3\r\nmove 10 from 3 to 4\r\nmove 3 from 5 to 4\r\nmove 1 from 3 to 8\r\nmove 3 from 3 to 2\r\nmove 1 from 8 to 1\r\nmove 1 from 1 to 3\r\nmove 3 from 8 to 3\r\nmove 5 from 4 to 6\r\nmove 1 from 2 to 3\r\nmove 4 from 6 to 4\r\nmove 1 from 5 to 7\r\nmove 4 from 3 to 4\r\nmove 1 from 2 to 8\r\nmove 12 from 7 to 6\r\nmove 1 from 8 to 2\r\nmove 2 from 2 to 7\r\nmove 1 from 8 to 4\r\nmove 23 from 6 to 3\r\nmove 14 from 3 to 6\r\nmove 15 from 4 to 6\r\nmove 1 from 8 to 6\r\nmove 10 from 3 to 7\r\nmove 2 from 4 to 2\r\nmove 11 from 7 to 8\r\nmove 2 from 2 to 6\r\nmove 44 from 6 to 9\r\nmove 21 from 9 to 3\r\nmove 12 from 3 to 6\r\nmove 1 from 7 to 4\r\nmove 1 from 4 to 7\r\nmove 9 from 3 to 2\r\nmove 2 from 8 to 6\r\nmove 3 from 2 to 4\r\nmove 17 from 9 to 1\r\nmove 3 from 4 to 6\r\nmove 2 from 2 to 9\r\nmove 4 from 9 to 2\r\nmove 10 from 6 to 9\r\nmove 1 from 7 to 6\r\nmove 4 from 9 to 5\r\nmove 4 from 2 to 4\r\nmove 14 from 1 to 5\r\nmove 4 from 4 to 3\r\nmove 3 from 2 to 9\r\nmove 9 from 9 to 7\r\nmove 1 from 2 to 5\r\nmove 9 from 8 to 5\r\nmove 8 from 7 to 2\r\nmove 4 from 3 to 8\r\nmove 5 from 6 to 2\r\nmove 3 from 1 to 6\r\nmove 1 from 7 to 1\r\nmove 4 from 2 to 4\r\nmove 3 from 6 to 4\r\nmove 3 from 8 to 3\r\nmove 13 from 5 to 2\r\nmove 2 from 3 to 5\r\nmove 12 from 5 to 9\r\nmove 1 from 3 to 5\r\nmove 1 from 5 to 9\r\nmove 1 from 8 to 3\r\nmove 4 from 9 to 5\r\nmove 6 from 4 to 5\r\nmove 12 from 9 to 7\r\nmove 1 from 9 to 3\r\nmove 1 from 3 to 2\r\nmove 12 from 5 to 6\r\nmove 12 from 7 to 2\r\nmove 1 from 3 to 7\r\nmove 1 from 4 to 8\r\nmove 33 from 2 to 8\r\nmove 1 from 7 to 5\r\nmove 1 from 1 to 2\r\nmove 4 from 5 to 4\r\nmove 3 from 2 to 5\r\nmove 34 from 8 to 6\r\nmove 1 from 4 to 3\r\nmove 1 from 5 to 7\r\nmove 1 from 7 to 5\r\nmove 3 from 4 to 9\r\nmove 2 from 9 to 7\r\nmove 1 from 9 to 4\r\nmove 1 from 3 to 7\r\nmove 1 from 5 to 8\r\nmove 1 from 5 to 1\r\nmove 1 from 5 to 7\r\nmove 1 from 4 to 8\r\nmove 1 from 1 to 4\r\nmove 1 from 4 to 2\r\nmove 3 from 7 to 5\r\nmove 2 from 8 to 5\r\nmove 1 from 2 to 8\r\nmove 4 from 6 to 2\r\nmove 1 from 8 to 6\r\nmove 1 from 7 to 9\r\nmove 29 from 6 to 7\r\nmove 4 from 2 to 3\r\nmove 2 from 5 to 8\r\nmove 1 from 9 to 5\r\nmove 2 from 8 to 1\r\nmove 23 from 7 to 5\r\nmove 2 from 6 to 1\r\nmove 23 from 5 to 6\r\nmove 1 from 3 to 6\r\nmove 4 from 5 to 9\r\nmove 2 from 1 to 3\r\nmove 5 from 3 to 8\r\nmove 2 from 6 to 5\r\nmove 2 from 1 to 4\r\nmove 1 from 9 to 8\r\nmove 1 from 9 to 1\r\nmove 1 from 4 to 6\r\nmove 2 from 5 to 6\r\nmove 6 from 7 to 8\r\nmove 2 from 9 to 2\r\nmove 18 from 6 to 5\r\nmove 21 from 6 to 4\r\nmove 1 from 1 to 6\r\nmove 2 from 6 to 7\r\nmove 2 from 7 to 9\r\nmove 2 from 2 to 8\r\nmove 7 from 4 to 3\r\nmove 12 from 5 to 3\r\nmove 1 from 9 to 5\r\nmove 1 from 9 to 4\r\nmove 6 from 5 to 2\r\nmove 17 from 3 to 4\r\nmove 3 from 4 to 3\r\nmove 1 from 2 to 4\r\nmove 5 from 2 to 8\r\nmove 1 from 5 to 8\r\nmove 19 from 8 to 7\r\nmove 1 from 3 to 6\r\nmove 1 from 8 to 4\r\nmove 1 from 6 to 1\r\nmove 15 from 4 to 6\r\nmove 1 from 1 to 4\r\nmove 3 from 3 to 5\r\nmove 4 from 6 to 7\r\nmove 1 from 4 to 7\r\nmove 10 from 6 to 7\r\nmove 16 from 4 to 5\r\nmove 24 from 7 to 2\r\nmove 8 from 7 to 8\r\nmove 1 from 4 to 2\r\nmove 6 from 8 to 7\r\nmove 1 from 8 to 7\r\nmove 1 from 6 to 9\r\nmove 14 from 5 to 4\r\nmove 9 from 7 to 8\r\nmove 4 from 5 to 1\r\nmove 2 from 1 to 5\r\nmove 3 from 8 to 6\r\nmove 2 from 6 to 9\r\nmove 2 from 2 to 8\r\nmove 6 from 2 to 7\r\nmove 3 from 4 to 6\r\nmove 1 from 3 to 4\r\nmove 3 from 5 to 7\r\nmove 1 from 6 to 9\r\nmove 5 from 7 to 2\r\nmove 4 from 9 to 1\r\nmove 1 from 7 to 9\r\nmove 9 from 8 to 4\r\nmove 5 from 1 to 2\r\nmove 2 from 6 to 1\r\nmove 6 from 4 to 7\r\nmove 1 from 7 to 3\r\nmove 1 from 3 to 9\r\nmove 1 from 9 to 7\r\nmove 1 from 6 to 7\r\nmove 9 from 4 to 5\r\nmove 7 from 7 to 9\r\nmove 3 from 7 to 5\r\nmove 1 from 9 to 2\r\nmove 6 from 9 to 8\r\nmove 4 from 4 to 5\r\nmove 1 from 4 to 2\r\nmove 1 from 4 to 2\r\nmove 2 from 1 to 2\r\nmove 1 from 9 to 8\r\nmove 10 from 2 to 4\r\nmove 8 from 2 to 7\r\nmove 12 from 2 to 9\r\nmove 6 from 7 to 4\r\nmove 1 from 1 to 2\r\nmove 8 from 9 to 8\r\nmove 7 from 5 to 1\r\nmove 9 from 4 to 3\r\nmove 14 from 8 to 4\r\nmove 1 from 8 to 4\r\nmove 1 from 1 to 5\r\nmove 1 from 5 to 2\r\nmove 3 from 2 to 4\r\nmove 1 from 7 to 1\r\nmove 1 from 7 to 3\r\nmove 2 from 1 to 7\r\nmove 3 from 5 to 7\r\nmove 2 from 7 to 6\r\nmove 1 from 6 to 5\r\nmove 3 from 7 to 1\r\nmove 1 from 6 to 8\r\nmove 1 from 8 to 7\r\nmove 1 from 3 to 6\r\nmove 1 from 7 to 1\r\nmove 4 from 1 to 4\r\nmove 6 from 3 to 2\r\nmove 3 from 1 to 2\r\nmove 3 from 3 to 6\r\nmove 3 from 2 to 6\r\nmove 6 from 6 to 5\r\nmove 1 from 1 to 4\r\nmove 1 from 9 to 6\r\nmove 5 from 2 to 1\r\nmove 3 from 1 to 2\r\nmove 2 from 9 to 8\r\nmove 3 from 1 to 5\r\nmove 1 from 9 to 7\r\nmove 25 from 4 to 1\r\nmove 1 from 1 to 7\r\nmove 2 from 8 to 3\r\nmove 13 from 1 to 9\r\nmove 2 from 3 to 5\r\nmove 8 from 5 to 9\r\nmove 4 from 2 to 1\r\nmove 2 from 6 to 7\r\nmove 10 from 5 to 9\r\nmove 4 from 7 to 2\r\nmove 2 from 2 to 3\r\nmove 9 from 9 to 2\r\nmove 4 from 4 to 5\r\nmove 4 from 5 to 4\r\nmove 5 from 1 to 4\r\nmove 10 from 4 to 5\r\nmove 22 from 9 to 1\r\nmove 2 from 2 to 7\r\nmove 3 from 2 to 1\r\nmove 6 from 2 to 6\r\nmove 1 from 7 to 1\r\nmove 10 from 5 to 7\r\nmove 15 from 1 to 4\r\nmove 13 from 1 to 5\r\nmove 3 from 6 to 8\r\nmove 1 from 8 to 9";

var moves = input.Split(Environment.NewLine);

Process(moves, Cranes.Model9001);

static void Process(string[] moves, Cranes craneModel)
{
    List<Move> moveCommands = new List<Move>();

    foreach(var requestString in moves)
    {
        moveCommands.Add(Move.ToMove(requestString));
    }

    var stacks = new StackProvider();
    stacks.MoveContainers(moveCommands, craneModel);
}
