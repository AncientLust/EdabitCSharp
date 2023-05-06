using System.Numerics;

class TheSmallestNumber
{
    public static string Smallest(int n)
    {
        // Generate sequence of numbers from 0 to n
        List<BigInteger> numbers = new List<BigInteger>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        // Find the LCM Using the Division Method
        // https://www.calculatorsoup.com/calculators/math/lcm.php
        List<BigInteger> primes = new List<BigInteger>();

        int prime = 2;
        while (numbers.Count(x => x == 1) != numbers.Count) 
        {
            while (numbers.Count(x => x % prime == 0) != 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % prime == 0)
                    {
                        numbers[i] /= prime;
                    }
                }

                primes.Add(prime);
            }

            prime = NextPrime(prime);
        }


        // Calculate the result
        BigInteger result = 1;
        foreach (var item in primes)
        {
            result *= item; 
        }
        
        return result.ToString();
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
}