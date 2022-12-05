namespace Day5
{
    public class StackProvider
    {
        public Dictionary<Stack, Stack<string>> StackLookup;

        private readonly Stack<string> stackOne;
        private readonly Stack<string> stackTwo;
        private readonly Stack<string> stackThree;
        private readonly Stack<string> stackFour;
        private readonly Stack<string> stackFive;
        private readonly Stack<string> stackSix;
        private readonly Stack<string> stackSevern;
        private readonly Stack<string> stackEight;
        private readonly Stack<string> stackNine;

        public StackProvider()
        {
            stackOne = new Stack<string>();
            stackTwo = new Stack<string>();
            stackThree = new Stack<string>();
            stackFour = new Stack<string>();
            stackFive = new Stack<string>();
            stackSix = new Stack<string>();
            stackSevern = new Stack<string>();
            stackEight = new Stack<string>();
            stackNine = new Stack<string>();

            stackOne.Push("N");
            stackOne.Push("C");
            stackOne.Push("R");
            stackOne.Push("T");
            stackOne.Push("M");
            stackOne.Push("Z");
            stackOne.Push("P");
            
            stackTwo.Push("D");
            stackTwo.Push("N");
            stackTwo.Push("T");
            stackTwo.Push("S");
            stackTwo.Push("B");
            stackTwo.Push("Z");
            
            stackThree.Push("M");
            stackThree.Push("H");
            stackThree.Push("Q");
            stackThree.Push("R");
            stackThree.Push("F");
            stackThree.Push("C");
            stackThree.Push("T");
            stackThree.Push("G");
            
            stackFour.Push("G");
            stackFour.Push("R");
            stackFour.Push("Z");
            
            stackFive.Push("Z");
            stackFive.Push("N");
            stackFive.Push("R");
            stackFive.Push("H");
            
            stackSix.Push("F");
            stackSix.Push("H");
            stackSix.Push("S");
            stackSix.Push("W");
            stackSix.Push("P");
            stackSix.Push("Z");
            stackSix.Push("L");
            stackSix.Push("D");
            
            stackSevern.Push("W");
            stackSevern.Push("D");
            stackSevern.Push("Z");
            stackSevern.Push("R");
            stackSevern.Push("C");
            stackSevern.Push("G");
            stackSevern.Push("M");
            
            stackEight.Push("S");
            stackEight.Push("J");
            stackEight.Push("F");
            stackEight.Push("L");
            stackEight.Push("H");
            stackEight.Push("W");
            stackEight.Push("Z");
            stackEight.Push("Q");
            
            stackNine.Push("S");
            stackNine.Push("Q");
            stackNine.Push("P");
            stackNine.Push("W");
            stackNine.Push("N");

            StackLookup = new Dictionary<Stack, Stack<string>>
            {
                { Stack.One, stackOne },
                { Stack.Two, stackTwo },
                { Stack.Three, stackThree },
                { Stack.Four, stackFour },
                { Stack.Five, stackFive },
                { Stack.Six, stackSix },
                { Stack.Severn, stackSevern },
                { Stack.Eight, stackEight },
                { Stack.Nine, stackNine }
            };
        }

        public void MoveContainers(List<Move> moves, Cranes craneModel)
        {
            foreach (var move in moves)
            {
                if (craneModel == Cranes.Model9000)
                    ApplyMove9000(move);
                else
                    ApplyMove9001(move);
            }
        }

        private void ApplyMove9000(Move containerMove)
        {
            for (int i = 0; i < containerMove.Count; i++)
            {
                var from = StackLookup[containerMove.From];
                var to = StackLookup[containerMove.To];

                string container = from.Pop();
                to.Push(container);
            }
        }

        private void ApplyMove9001(Move containerMove)
        {
            List<string> poppedItems = new List<string>();

            var from = StackLookup[containerMove.From];
            var to = StackLookup[containerMove.To];

            for (int i = 0; i < containerMove.Count; i++)
            {
                poppedItems.Add(from.Pop());
            }

            poppedItems.Reverse();

            for (int i = 0; i < poppedItems.Count; i++)
            {
                to.Push(poppedItems.ElementAt(i));
            }
        }
    }


}
