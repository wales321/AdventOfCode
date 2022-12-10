namespace Day10
{
    internal class Instruction
    {
        private int cycleCount;
        private int maxCycles;
        private int incrementValue;

        public Instruction(string instructionText)
        {
            var split = instructionText.Split(" ");
            Command = split[0];

            if(Command == Constants.AddX)
            {
                incrementValue = int.Parse(split[1]);
                maxCycles = 2;
            }
            else if(Command == Constants.Noop)
            {
                incrementValue = 0;
                maxCycles = 1;
            }

            Complete = false;
            cycleCount = 0;
        }

        public int ExecuteCycle(int valueToIncrement)
        {
            cycleCount++;
            Complete = cycleCount == maxCycles;

            if (Complete)
                valueToIncrement += incrementValue;

            return valueToIncrement;
        }


        public bool Complete { get; set; }
        public string Command { get; set; }        
    }
}
