namespace Day11
{
    public class Monkey
    {
        public Monkey()
        {
            Items = new Queue<long>();
            InspectedItemCount = 0;
        }

        public int MonkeyNumber { get; set; }
        public Queue<long> Items { get; set; }
        public Func<long, long, long> Operation { get; set; }
        public string OperationValue { get; set; }
        public int Divisor { get; set; }

        public int TrueConditionMonkeyId { get; set; }
        public int FalseConditionMonkeyId { get; set; }

        public long InspectedItemCount { get; private set; }

        /*
         * Returns a dictionary of items and the monkey to throw them to
         * */
        internal List<Tuple<long, long>> Inspect()
        {
            List<Tuple<long, long>> thrownItems = new List<Tuple<long, long>>();
            while (Items.TryDequeue(out long initialWorry))
            {
                InspectedItemCount++;

                var worryLevel = initialWorry;

                // Apply worry level
                if (int.TryParse(OperationValue, out int opValue))
                {
                    worryLevel = Operation(worryLevel, opValue);
                }
                else
                {
                    worryLevel = Operation(worryLevel, worryLevel);
                }

                worryLevel = (int)Math.Floor(worryLevel / 3.0);

                if ((worryLevel % Divisor) == 0)
                    thrownItems.Add(new Tuple<long, long>(worryLevel, TrueConditionMonkeyId));
                else
                    thrownItems.Add(new Tuple<long, long>(worryLevel, FalseConditionMonkeyId));

            }

            return thrownItems;
        }

        internal List<Tuple<long, long>> InspectPart2(List<Monkey> monkeys)
        {
            var worryMultiplier = monkeys.Aggregate(1, (i, monkey) => i * monkey.Divisor);

            List<Tuple<long, long>> thrownItems = new List<Tuple<long, long>>();
            while (Items.TryDequeue(out long initialWorry))
            {
                InspectedItemCount++;

                var worryLevel = initialWorry;

                // Apply worry level
                if (int.TryParse(OperationValue, out int opValue))
                {
                    worryLevel = Operation(worryLevel, opValue);
                }
                else
                {
                    worryLevel = Operation(worryLevel, worryLevel);
                }

                worryLevel = worryLevel % worryMultiplier;

                if ((worryLevel % Divisor) == 0)
                    thrownItems.Add(new Tuple<long, long>(worryLevel, TrueConditionMonkeyId));
                else
                    thrownItems.Add(new Tuple<long, long>(worryLevel, FalseConditionMonkeyId));

            }

            return thrownItems;
        }
    }
}
