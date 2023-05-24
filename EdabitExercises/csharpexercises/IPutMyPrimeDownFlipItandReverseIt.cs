class IPutMyPrimeDownFlipItandReverseIt
{
    public static string Bemirp(int n)
    {
        if (IsBemirp(n)) return "B";
        if (IsEmirp(n)) return "E";
        if (IsPrime(n)) return "P";
        return "C";
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    private static bool IsEmirp(int n)
    {
        int reversedNumber = int.Parse(n.ToString().Reverse().ToArray());
        return IsPrime(n) && IsPrime(reversedNumber) && n != reversedNumber;
    }

    private static bool IsBemirp(int n)
    {
        // Flip the number
        string flippedNumber = n.ToString().Replace("6", "T").Replace("9", "6").Replace("T", "9");

        return IsEmirp(n) && IsPrime(int.Parse(flippedNumber));
    }
}