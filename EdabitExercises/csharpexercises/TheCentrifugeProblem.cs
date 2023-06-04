public class TheCentrifugeProblem
{
    public static bool Centrifuge(int n, int k)
    {
        List<int> primes = PrimeFactors(n);

        bool[] expressible = new bool[n + 1];
        expressible[0] = true;

        foreach (var prime in primes)
        {
            for (int i = prime; i <= n; i++)
            {
                expressible[i] |= expressible[i - prime];
            }
        }

        return expressible[k] && expressible[n - k];
    }

    private static List<int> PrimeFactors(int n)
    {
        var primes = new List<int>();

        for (int i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                primes.Add(i);
                n /= i;
            }
        }

        if (n > 1)
        {
            primes.Add(n);
        }

        return primes;
    }
}