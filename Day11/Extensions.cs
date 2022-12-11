namespace Day11
{
    public static class Extensions
    {
        public static List<Monkey> ToMonkeyList(this string input)
        {
            var monkeys = new List<Monkey>();
            var split = input.Split(Environment.NewLine + Environment.NewLine);

            foreach(var monkeyText in split)
            {
                var monkeyAttributes = monkeyText.Split(Environment.NewLine);
                var monkeyNumber = monkeyAttributes.ElementAt(0).Split(new String[] { "Monkey ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                var startingItems = monkeyAttributes.ElementAt(1).Split("  Starting items: ", StringSplitOptions.RemoveEmptyEntries)
                    .First().Split(',', StringSplitOptions.RemoveEmptyEntries);
                var operations = monkeyAttributes.ElementAt(2).Split("  Operation: new = old ", StringSplitOptions.RemoveEmptyEntries)
                    .First().Split(" ");
                var testValue = monkeyAttributes.ElementAt(3).Split("  Test: divisible by ", StringSplitOptions.RemoveEmptyEntries);
                var trueValue = monkeyAttributes.ElementAt(4).Split("    If true: throw to monkey ", StringSplitOptions.RemoveEmptyEntries);
                var falseValue = monkeyAttributes.ElementAt(5).Split("    If false: throw to monkey ", StringSplitOptions.RemoveEmptyEntries);
                
                var monkey = new Monkey()
                {
                    MonkeyNumber = int.Parse(monkeyNumber.First()),
                    Items = new Queue<long>(startingItems.Select(x => long.Parse(x.Trim())).ToList()),
                    OperationValue = operations[1],
                    Divisor = int.Parse(testValue.First()),
                    TrueConditionMonkeyId = int.Parse(trueValue.First()),
                    FalseConditionMonkeyId = int.Parse(falseValue.First())
                };

                if (operations.First() == "+")
                    monkey.Operation = Add;
                else
                    monkey.Operation = Multiply;

                monkeys.Add(monkey);
            }

            return monkeys;
        }

        static Func<long, long, long> Add = (a, b) => a + b;
        static Func<long, long, long> Multiply = (a, b) => a * b;
    }
}
