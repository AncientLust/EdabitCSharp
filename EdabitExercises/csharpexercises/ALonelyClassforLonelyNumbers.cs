class ALonelyClassforLonelyNumbers
{
    public static string LoneliestNumber(int lo, int hi)
    {
        int loneliestNumber = 0;
        int highestDistance = 0;
        int closestPrimeNumber = 0;

        int i = hi;
        while (i >= lo)
        {
            int nextPrime = NextPrime(i);
            int previousPrime = PreviousPrime(i);
            int previousPrimeDistance = i - previousPrime;
            int nextPrimeDistance = nextPrime - i;
            int distance = i <= 2 ? nextPrimeDistance : Math.Min(previousPrimeDistance, nextPrimeDistance);

            if (highestDistance == 0)
            {
                highestDistance = distance;
                loneliestNumber = i;
                closestPrimeNumber = previousPrimeDistance == nextPrimeDistance ? nextPrime : Math.Min(previousPrime, nextPrime);
            }
            else if (distance >= highestDistance)
            {
                highestDistance = distance;
                loneliestNumber = i;
                closestPrimeNumber = previousPrimeDistance == nextPrimeDistance ? nextPrime : Math.Min(previousPrime, nextPrime);
            }

            i--;
        }

        return $"number: {loneliestNumber}, distance: {highestDistance}, closest: {closestPrimeNumber}";
    }


    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2 || number == 3)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    private static int NextPrime(int num)
    {
        num++;
        while (!IsPrime(num)) 
        {
            num++;
        }

        return num;
    }

    private static int PreviousPrime(int num)
    {
        if (num <= 2)
        {
            return 2;
        }

        num--;
        while (!IsPrime(num))
        {
            num--;
        }

        return num;
    }
}