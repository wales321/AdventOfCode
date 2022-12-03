namespace Day2
{
    public class CodeLookup : Dictionary<string, Move>
    {
        public CodeLookup()
        {
            this.Add("A", Move.Rock);
            this.Add("B", Move.Paper);
            this.Add("C", Move.Scissors);
            this.Add("X", Move.Rock);
            this.Add("Y", Move.Paper);
            this.Add("Z", Move.Scissors);
        }
    }

    public class OutcomeLookup : Dictionary<string, Outcome>
    {
        public OutcomeLookup()
        {
            this.Add("X", Outcome.Lose);
            this.Add("Y", Outcome.Draw);
            this.Add("Z", Outcome.Win);
        }
    }
}
