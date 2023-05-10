class UlamSequenceClass
{
    public static int Ulam(int n)
    {
        List<int> ulamSequence = new List<int> { 1, 2 };

        int skipCount = 1;
        int nextNumber;
        while (ulamSequence.Count < n)
        {
            nextNumber = ulamSequence.Last() + skipCount;
            int count = 0;
            for (int i = 0; i <= ulamSequence.Count - 1; i++)
            {
                for (int j = i; j <= ulamSequence.Count - 1; j++)
                {
                    if (i == j)
                        continue;

                    if (ulamSequence[i] + ulamSequence[j] == nextNumber)
                        count++;
                }
            }

            if (count == 1)
            {
                ulamSequence.Add(nextNumber);
                skipCount = 1;
            }
            else
            {
                skipCount++;
            }
        }

        return ulamSequence.Last();
    }
}