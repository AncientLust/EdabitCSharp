class MaxieAndMinnieClass
{
    public static long[] MaxMin(long n)
    {
        string number = n.ToString();
        List<string> swaps = new List<string>();

        for (int i = 0; i < number.Length - 1; i++)
        {
            for (int j = i + 1 ; j < number.Length; j++)
            {
                if (number[i] != number[j]) 
                {
                    char[] chars = number.ToCharArray();
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;

                    string swapped = new string(chars);
                    swaps.Add(swapped);
                }
            }
        }

        List<long> longs = new List<long> { n };
        foreach (var permutation in swaps)
        {
            if (!permutation.StartsWith("0"))
            {
                longs.Add(long.Parse(permutation));
            }
        }

        return new long[] { longs.Max(), longs.Min() };
    }
}