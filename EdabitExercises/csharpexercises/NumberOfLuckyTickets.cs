using System.Collections.Generic;
using System.Linq;
using System;

class NumberOfLuckyTicketsClass
{
    private static int SumDigitsOfLong(long value)
    {
        int sum = 0;
        while (value > 0)
        {
            sum += (int)(value % 10);
            value /= 10;
        }

        return sum;
    }

    public static long LuckyTicket(int n)
    {
        /* The idea is to:
         * - Take the half of the number N/2
         * - Group all sums and their counts inside the dictionary
         * - Sum squares of all counts
         * 
         * When n = 4, there are 4*4 possible cases to get sum = 4 for both sides:
         * 12 03    |    21 03    |    30 03    |    03 03    
         * 12 30    |    21 30    |    30 30    |    03 30
         * 12 12    |    21 12    |    30 12    |    03 12
         * 12 21    |    21 21    |    30 21    |    03 21
         */

        // Take the half of the number N/2
        string halfNumberString = "";
        for (int i = 0; i < n / 2; i++)
        {
            halfNumberString += "9";
        }

        // Group all sums and their counts inside the dictionary
        long luckyCases = 1; // Zero always a lucky case
        long halfNumber = (long)Math.Pow(10, n / 2) - 1;
        Dictionary<int, int> sumsDict = new Dictionary<int, int>();

        int count = 0;
        int sum = 0;
        for (long i = 0; i < halfNumber; i++)
        {
            sum = SumDigitsOfLong(i);
            if (sumsDict.TryGetValue(sum, out count))
            {
                sumsDict[sum] = count + 1;
            }
            else
            {
                sumsDict[sum] = 1;
            }
        }

        // Sum squares of all counts
        luckyCases += sumsDict.Values.Sum(v => (long)v * v);

        return luckyCases;
    }
}