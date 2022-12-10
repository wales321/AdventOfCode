using Day10;

string input = "noop\r\nnoop\r\naddx 5\r\naddx 3\r\naddx -2\r\nnoop\r\naddx 5\r\naddx 4\r\nnoop\r\naddx 3\r\nnoop\r\naddx 2\r\naddx -17\r\naddx 18\r\naddx 3\r\naddx 1\r\nnoop\r\naddx 5\r\nnoop\r\naddx 1\r\naddx 2\r\naddx 5\r\naddx -40\r\nnoop\r\naddx 5\r\naddx 2\r\naddx 3\r\nnoop\r\naddx 2\r\naddx 3\r\naddx -2\r\naddx 2\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 5\r\naddx 2\r\naddx 3\r\naddx -2\r\naddx 2\r\naddx -24\r\naddx 31\r\naddx 2\r\naddx -33\r\naddx -6\r\naddx 5\r\naddx 2\r\naddx 3\r\nnoop\r\naddx 2\r\naddx 3\r\nnoop\r\naddx 2\r\naddx -1\r\naddx 6\r\nnoop\r\nnoop\r\naddx 1\r\naddx 4\r\nnoop\r\nnoop\r\naddx -15\r\naddx 20\r\nnoop\r\naddx -23\r\naddx 27\r\nnoop\r\naddx -35\r\naddx 1\r\nnoop\r\nnoop\r\naddx 5\r\naddx 11\r\naddx -10\r\naddx 4\r\naddx 1\r\nnoop\r\naddx 2\r\naddx 2\r\nnoop\r\naddx 3\r\nnoop\r\naddx 3\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 2\r\naddx 11\r\naddx -4\r\naddx 2\r\naddx -38\r\naddx -1\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 5\r\naddx 2\r\naddx -7\r\naddx 8\r\naddx 2\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 5\r\naddx 2\r\naddx -25\r\naddx 26\r\naddx 2\r\naddx 8\r\naddx -1\r\naddx 2\r\naddx -2\r\naddx -37\r\naddx 5\r\naddx 3\r\naddx -1\r\naddx 5\r\nnoop\r\naddx 22\r\naddx -21\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx 13\r\naddx -12\r\naddx 4\r\nnoop\r\nnoop\r\naddx 5\r\naddx 1\r\nnoop\r\nnoop\r\naddx 2\r\nnoop\r\naddx 3\r\nnoop\r\nnoop";
var split = input.Split(Environment.NewLine);

var instructions = split.ToInstructionQueue();

Dictionary<int, int> signalStrengths = new Dictionary<int, int>()
{
    {20, 0 }, {60, 0 }, {100, 0 }, {140, 0 }, {180, 0 }, {220, 0 }
};

Instruction? currentInstruction = null;
int pixel = 0;
int xRegister = 1;
int cycleCount = 0;

while (true)
{
    PrintToScreen(xRegister);
    cycleCount++;

    if(currentInstruction == null || currentInstruction.Complete)
    {
        if (!instructions.TryDequeue(out currentInstruction))
            break;
    }

    if (signalStrengths.ContainsKey(cycleCount))
        signalStrengths[cycleCount] = cycleCount * xRegister;

    xRegister = currentInstruction.ExecuteCycle(xRegister);
}

void PrintToScreen(int spriteCenter)
{
    var sprite = Enumerable.Range(spriteCenter - 1, 3);
    if (sprite.Contains(pixel))
        Console.Write("# ");
    else
        Console.Write(". ");

    pixel++;
    if(pixel > 39)
    {
        pixel = 0;
        Console.WriteLine("");
    }
}

Console.WriteLine($"X = {xRegister}");
Console.WriteLine($"Signal strenth sum = {signalStrengths.Sum(x => x.Value)}");