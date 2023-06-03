using System.Text.RegularExpressions;

public class SimplifiedProperFractions
{
    public static int SimPropFrac(int maxDen)
    {
        int result = 0;
        for (int i = 2; i <= maxDen; i++)
            result += Phi(i);
        return result;
    }

    private static int Phi(int n)
    {
        int result = n;
        for (int p = 2; p * p <= n; ++p)
        {
            if (n % p == 0)
            {
                while (n % p == 0)
                    n /= p;
                result -= result / p;
            }
        }
        if (n > 1)
            result -= result / n;
        return result;
    }
}