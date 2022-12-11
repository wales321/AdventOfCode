using Day11;

string input = "Monkey 0:\r\n  Starting items: 73, 77\r\n  Operation: new = old * 5\r\n  Test: divisible by 11\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 5\r\n\r\nMonkey 1:\r\n  Starting items: 57, 88, 80\r\n  Operation: new = old + 5\r\n  Test: divisible by 19\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 0\r\n\r\nMonkey 2:\r\n  Starting items: 61, 81, 84, 69, 77, 88\r\n  Operation: new = old * 19\r\n  Test: divisible by 5\r\n    If true: throw to monkey 3\r\n    If false: throw to monkey 1\r\n\r\nMonkey 3:\r\n  Starting items: 78, 89, 71, 60, 81, 84, 87, 75\r\n  Operation: new = old + 7\r\n  Test: divisible by 3\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 0\r\n\r\nMonkey 4:\r\n  Starting items: 60, 76, 90, 63, 86, 87, 89\r\n  Operation: new = old + 2\r\n  Test: divisible by 13\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 7\r\n\r\nMonkey 5:\r\n  Starting items: 88\r\n  Operation: new = old + 1\r\n  Test: divisible by 17\r\n    If true: throw to monkey 4\r\n    If false: throw to monkey 7\r\n\r\nMonkey 6:\r\n  Starting items: 84, 98, 78, 85\r\n  Operation: new = old * old\r\n  Test: divisible by 7\r\n    If true: throw to monkey 5\r\n    If false: throw to monkey 4\r\n\r\nMonkey 7:\r\n  Starting items: 98, 89, 78, 73, 71\r\n  Operation: new = old + 4\r\n  Test: divisible by 2\r\n    If true: throw to monkey 3\r\n    If false: throw to monkey 2";

var monkeys = input.ToMonkeyList();

int maxRounds = 10000;

for (int i = 0; i < maxRounds; i++)
{   
    foreach(var monkey in monkeys)
    {
        var thrownItems = monkey.InspectPart2(monkeys);
        foreach(var item in thrownItems)
        {
            monkeys.First(x => x.MonkeyNumber == item.Item2).Items.Enqueue(item.Item1); 
        }
    }
}

var ordered = monkeys.OrderByDescending(x => x.InspectedItemCount);
var monkeyBusiness = ordered.ElementAt(0).InspectedItemCount * ordered.ElementAt(1).InspectedItemCount;
Console.WriteLine($"Monkey busines: {monkeyBusiness}");
