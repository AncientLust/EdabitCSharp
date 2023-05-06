class ThreeSumProblemClass
{
    public static List<int[]> ThreeSum(int[] arr)
    {
        if (arr.Length < 3)
        {
            return new List<int[]>();
        }

        // Collect all possible distinct combinations
        List<int[]> triplets = new List<int[]> ();
        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    var triplet = new int[] { arr[i], arr[j], arr[k] };

                    bool containsTriplet = triplets.Any(t => t[0] == triplet[0] && t[1] == triplet[1] && t[2] == triplet[2]);

                    if (!containsTriplet)
                    {
                        triplets.Add(triplet);
                    }
                }
            }
        }

        // Filter out triplets where sum != 0
        for (int i = 0; i < triplets.Count;)
        {
            if (triplets[i].Sum() != 0)
            {
                triplets.RemoveAt(i);
                continue;
            }

            i++;
        }
        
        return triplets;
    }
}