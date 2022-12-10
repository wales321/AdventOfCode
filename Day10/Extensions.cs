namespace Day10
{
    internal static class Extensions
    {
        public static Queue<Instruction> ToInstructionQueue(this string[] source)
        {
            var instructions = source.Select(x => new Instruction(x));            
            return new Queue<Instruction>(instructions);
        }
    }
}
