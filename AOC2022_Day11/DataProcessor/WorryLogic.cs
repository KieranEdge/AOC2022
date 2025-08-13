namespace AOC2022_11.DataProcessor
{
    public static class WorryLogic
    {
        public static long WorryFactor(long initialWorry, long worryFactor, char logicalOperator, bool isSquare)
        {
            if (isSquare)
            {
                return initialWorry * initialWorry; // long math
            }

            return logicalOperator switch
            {
                '+' => initialWorry + worryFactor,
                '-' => initialWorry - worryFactor,
                '*' => initialWorry * worryFactor,
                '/' => initialWorry / worryFactor, // not used in AoC but harmless
                _ => throw new InvalidOperationException($"Unknown op '{logicalOperator}'")
            };
        }

        public static bool WorryTest(long newWorry, int testDivisor)
            => newWorry % testDivisor == 0;
    }
}