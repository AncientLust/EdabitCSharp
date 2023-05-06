class PrimalStrengthClass
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static string PrimalStrength(int n)
    {
        // Calculate the nearest lower prime number
        int nearestLower = n - 1;
        while (!IsPrime(nearestLower))
        {
            nearestLower--;
        }

        // Calculate the nearest higher prime number
        int nearestHigher = n + 1;
        while (!IsPrime(nearestHigher))
        {
            nearestHigher++;
        }

        if (n - nearestLower > nearestHigher - n)
        {
            return "Strong";
        }
        else if (n - nearestLower < nearestHigher - n)
        {
            return "Weak";
        }
        else
        {
            return "Balanced";
        }
    }
}