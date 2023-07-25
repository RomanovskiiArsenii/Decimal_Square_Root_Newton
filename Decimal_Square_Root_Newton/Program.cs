class Program
{
    public static decimal SquareRoot(long num)
    {
        decimal initialGuess = num / 2;
        for (int i = 0; i < 100; i++)
        {
            decimal nextGuess = (initialGuess + num / initialGuess) / 2;
            if (Math.Abs(nextGuess - initialGuess) < 1e-28M) return nextGuess;
            initialGuess = nextGuess;
        }
        return initialGuess;
    }

    static void Main()
    {
        Console.WriteLine(SquareRoot(4503599627370497));
    }
}
