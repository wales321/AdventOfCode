namespace Day4
{
    public class ElfPair
    {
        public ElfPair(string pair)
        {
            var pairSplit = pair.Split(',');
            var firstElfSection = pairSplit[0].Split('-');
            var secondElfSection = pairSplit[1].Split('-');

            FirstElf = new Range(firstElfSection);
            SecondElf = new Range(secondElfSection);
        }

        public Range FirstElf { get; }

        public Range SecondElf { get; }

        internal bool FullyContainsAssignments()
        {
            if (FirstElf.Min >= SecondElf.Min && FirstElf.Max <= SecondElf.Max)
                return true;

            if (SecondElf.Min >= FirstElf.Min && SecondElf.Max <= FirstElf.Max)
                return true;

            return false;
        }

        internal bool ContainsOverlaps()
        {
            var firstRange = Enumerable.Range(FirstElf.Min, (FirstElf.Max - FirstElf.Min) + 1);
            var secondRange = Enumerable.Range(SecondElf.Min, (SecondElf.Max - SecondElf.Min) + 1);

            return firstRange.Intersect(secondRange).Any();
        }
    }
}
